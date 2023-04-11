﻿using Mtconnect.AdapterInterface.Contracts;
using Mtconnect.AdapterInterface.Contracts.Attributes;
using Mtconnect.AdapterInterface.DataItems;
using Mtconnect.AdapterInterface.DataItemTypes;
using Mtconnect.AdapterInterface.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.Serialization;
using System.Security.AccessControl;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace Mtconnect.AdapterInterface.DeviceConfiguration
{
    /// <summary>
    /// A factory for generating <c>Devices.xml</c> configuration files for MTConnect Agent(s).
    /// </summary>
    public class DeviceConfigurationFactory
    {
        const string XmlNs_M = "urn:mtconnect.org:MTConnectDevices:{{ version }}";
        const string XmlNs_Xsi = "http://www.w3.org/2001/XMLSchema-instance";
        const string XmlNs = "urn:mtconnect.org:MTConnectDevices:{{ version }}";
        const string XsiSchemaLocation = "urn:mtconnect.org:MTConnectDevices:{{ version }} http://www.mtconnect.org/schemas/MTConnectDevices_{{ version }}.xsd";

        /// <summary>
        /// Creates a valid MTConnect <c>MTConnectDevices</c> Response Document based on the configuration of the Adapter.
        /// </summary>
        /// <param name="adapter">Reference to the adapter to build the XML from.</param>
        /// <param name="devicePrefix">Optional scope for a specific device.</param>
        /// <returns>Valid <c>MTConnectDevices</c> Response Document, aka <c>Devices.xml</c> or Device Configuration file.</returns>
        public XmlDocument Create(Adapter adapter, string devicePrefix = null)
        {
            // Get the Adapter Version, used to set namespaces
            string adapterVersion = GetMaximumMtconnectVersion(adapter);

            // cache the type of IComponentModel
            Type componentModelType = typeof(IComponentModel);

            // Build namespaces
            XmlDocument xDoc = new XmlDocument();
            string xmlns_m = XmlNs_M.Replace("{{ version }}", adapterVersion);
            string xmlns_xsi = XmlNs_Xsi.Replace("{{ version }}", adapterVersion);
            string xmlns = XmlNs.Replace("{{ version }}", adapterVersion);
            string xsi_schemaLocation = XsiSchemaLocation.Replace("{{ version }}", adapterVersion);

            XmlNamespaceManager nsmgr = new XmlNamespaceManager(xDoc.NameTable);
            nsmgr.AddNamespace("m", xmlns_m);
            nsmgr.AddNamespace("xsi", xmlns_xsi);

            // Build XML Declaration (<?xml ?>
            xDoc.AppendChild(xDoc.CreateXmlDeclaration("1.0", "UTF-8", "yes"));

            // Build MTConnectDevices element
            var xRoot = xDoc.AppendChild(xDoc.CreateElement("MTConnectDevices"));
            xRoot.Attributes.Append(xDoc.CreateAttribute("xmlns:m", XNamespace.Xmlns.ToString())).Value = xmlns_m;
            xRoot.Attributes.Append(xDoc.CreateAttribute("xmlns:xsi", XNamespace.Xmlns.ToString())).Value = xmlns_xsi;
            xRoot.Attributes.Append(xDoc.CreateAttribute("xmlns")).Value = xmlns;
            xRoot.Attributes.Append(xDoc.CreateAttribute("xsi:schemaLocation", xmlns_xsi)).Value = xsi_schemaLocation;

            // Build Header element
            var xHeader = xRoot.AppendChild(xDoc.CreateElement("Header"));
            xHeader.Attributes.Append(xDoc.CreateAttribute("creationTime")).Value = DateTime.UtcNow.ToString("");// TODO: Ensure this is in the proper format
            xHeader.Attributes.Append(xDoc.CreateAttribute("sender")).Value = AppDomain.CurrentDomain.FriendlyName;
            xHeader.Attributes.Append(xDoc.CreateAttribute("instanceId")).Value = "1"; // QUESTION: Should this be '1' to be valid?
            xHeader.Attributes.Append(xDoc.CreateAttribute("bufferSize")).Value = "1"; // QUESTION: Should this be '1' to be valid?
            xHeader.Attributes.Append(xDoc.CreateAttribute("version")).Value = adapterVersion;
            xHeader.Attributes.Append(xDoc.CreateAttribute("assetBufferSize")).Value = "1"; // QUESTION: Should this be based on the memory allocation for the Adapter?
            xHeader.Attributes.Append(xDoc.CreateAttribute("assetCount")).Value = "0"; // QUESTION: Should this be based on the memory allocation for the Adapter?

            // Build Devices element
            var xDevices = xRoot.AppendChild(xDoc.CreateElement("Devices"));

            var dataItemsByDevice = adapter.DataItems.GroupBy(o => o.DevicePrefix).ToDictionary(g => g.Key, g => g.ToList());
            foreach (var deviceDataItems in dataItemsByDevice)
            {
                // If scoping by Device, then skip when the key doesn't match
                if (!string.IsNullOrEmpty(devicePrefix) && !devicePrefix.Equals(deviceDataItems.Key, StringComparison.OrdinalIgnoreCase))
                    continue;

                // Build Device element
                XmlElement xDevice = xDoc.CreateElement("Device");
                xDevices.AppendChild(xDevice);
                xDevice.Attributes.Append(xDoc.CreateAttribute("id")).Value = deviceDataItems.Key;
                // QUESTION: iso841Class was deprecated, but perhaps we should still include it in case a v1.0 Adapter is created?
                xDevice.Attributes.Append(xDoc.CreateAttribute("iso841Class")).Value = "1";
                // TODO: Add sampleInterval as a property within the Adapter or IAdapterSource.
                xDevice.Attributes.Append(xDoc.CreateAttribute("sampleInterval")).Value = "50";
                xDevice.Attributes.Append(xDoc.CreateAttribute("uuid")).Value = Guid.NewGuid().ToString();
                xDevice.Attributes.Append(xDoc.CreateAttribute("name")).Value = deviceDataItems.Key;

                // TODO: Source manufacturer information for the Description element

                // TODO: If IAdapterSource is used, then group DataItems by potential IAdapterDataModel implementations that represent Components.
                var dataModelTypes = adapter.GetDataModelTypes();
                if (dataModelTypes.Length > 0)
                {
                    foreach (var modelType in dataModelTypes)
                    {
                        AddComponents(xDevice, modelType, adapter, modelType.FullName);
                    }
                } else
                {
                    var xDataItems = xDevice.AppendChild(xDoc.CreateElement("DataItems"));

                    AddDataItems(xDataItems, deviceDataItems.Value);
                }
            }

            return xDoc;
        }
        private void AddComponents(XmlElement parentElement, Type type, Adapter adapter, string modelPath, string componentPrefix = null)
        {
            var dataItemsElement = parentElement.OwnerDocument.CreateElement("DataItems");
            var componentsElement = parentElement.OwnerDocument.CreateElement("Components");
            bool hasDataItems = false, hasComponents = false;

            foreach (var property in type.GetProperties())
            {
                var dataItemAttribute = property.GetCustomAttribute<DataItemAttribute>();
                
                // NOTE: IComponentModel is first because IComponentModel implements IAdapterDataModel
                if (typeof(IComponentModel).IsAssignableFrom(property.PropertyType))
                {
                    hasComponents = ProcessComponentModel(parentElement, adapter, $"{modelPath}[{property.Name}]", componentPrefix, componentsElement, property, dataItemAttribute);
                }
                else if (typeof(IAdapterDataModel).IsAssignableFrom(property.PropertyType))
                {
                    AddComponents(parentElement, property.PropertyType, adapter, $"{modelPath}[{property.Name}]", dataItemAttribute?.Name ?? $"{componentPrefix}{property.Name}_");
                }
                else if (typeof(DataItem).IsAssignableFrom(property.PropertyType) ||
                    dataItemAttribute != null ||
                    typeof(IDataItemValue).IsAssignableFrom(property.PropertyType))
                {
                    hasDataItems = ProcessDataItem(parentElement, adapter, $"{modelPath}[{property.Name}]", dataItemsElement, property, dataItemAttribute);
                }
            }

            if (hasDataItems)
                parentElement.AppendChild(dataItemsElement);
            if (hasComponents)
                parentElement.AppendChild(componentsElement);
        }

        private static bool ProcessDataItem(XmlElement parentElement, Adapter adapter, string modelPath, XmlElement dataItemsElement, PropertyInfo property, DataItemAttribute dataItemAttribute)
        {
            bool hasDataItems = true;
            // TODO: Handle property that meets the conditions
            XmlElement dataItemElement = null;
            DataItemValues dataItemValues = new DataItemValues();

            if (dataItemAttribute != null)
            {
                // Lookup DataItem from adapter
                // TODO: Getting the DataItem from the Adapter based on the PropertyInfo seems to half work. Need to improve comparison of PropertyInfo beyond defaults.
                var dataItem = adapter.DataItems.FirstOrDefault(o => o.ModelPath == modelPath);
                if (dataItem != null)
                {
                    dataItemValues.FoundDataItem = true;
                    dataItemValues.Category = dataItem.Category;
                    dataItemValues.Type = dataItem.ObservationalType;
                    dataItemValues.SubType = dataItem.ObservationalSubType;
                    dataItemValues.Name = dataItem.Name;
                    dataItemValues.Units = dataItem.Units;
                }
                // QUESTION: Is dataItemAttribute.Name an appropriate id?
                dataItemValues.Category = dataItemAttribute is EventAttribute
                    ? "EVENT"
                    : dataItemAttribute is SampleAttribute
                        ? "SAMPLE"
                        : dataItemAttribute is ConditionAttribute
                            ? "CONDITION"
                            : null;// "UNKNOWN";
                dataItemValues.Type = dataItemAttribute.Type;
                dataItemValues.SubType = dataItemAttribute.SubType;
                dataItemValues.Name = dataItemAttribute.Name;
                dataItemValues.Units = dataItemAttribute.Units;
            }

            if (typeof(DataItem).IsAssignableFrom(property.PropertyType))
            {
                var dataItem = adapter.DataItems.FirstOrDefault(o => o.ModelPath == modelPath);
                // QUESTION: Is dataItem.Name an appropriate id?
                if (dataItem != null)
                {
                    dataItemValues.FoundDataItem = true;
                    dataItemValues.Category = dataItem.Category;
                    dataItemValues.Type = dataItem.ObservationalType;
                    dataItemValues.SubType = dataItem.ObservationalSubType;
                    dataItemValues.Name = dataItem.Name;
                    dataItemValues.Units = dataItem.Units;
                }
            }
            else if (typeof(IDataItemValue).IsAssignableFrom(property.PropertyType))
            {
                var instance = FormatterServices.GetUninitializedObject(property.PropertyType) as IDataItemValue;
                // QUESTION: Is property.PropertyType.Name an appropriate id?
                if (instance != null)
                {
                    dataItemValues.Category = instance.Category;
                    dataItemValues.Type = instance.ObservationalType;
                    dataItemValues.SubType = instance.ObservationalSubType;
                    dataItemValues.Name = property.Name;
                    dataItemValues.Units = null;
                }
            }

            dataItemElement = CreateDataItemElement(parentElement.OwnerDocument, dataItemValues.Category, dataItemValues.Type, dataItemValues.SubType, dataItemValues.Name, dataItemValues.Units);

            if (dataItemElement != null)
                dataItemsElement.AppendChild(dataItemElement);
            return hasDataItems;
        }

        private bool ProcessComponentModel(XmlElement parentElement, Adapter adapter, string modelPath, string componentPath, XmlElement componentsElement, PropertyInfo property, DataItemAttribute dataItemAttribute)
        {
            bool hasComponents = true;
            var componentModelType = GetNearestComponentModelType(property.PropertyType);
            var componentElement = parentElement.OwnerDocument.CreateElement(componentModelType?.Name ?? property.PropertyType.Name);
            string id = property.Name.ToLower();
            if (dataItemAttribute != null)
            {
                id = dataItemAttribute.Name;
                if (id.EndsWith("_"))
                    id = id.Replace("_", string.Empty);
            }
            componentElement.SetAttribute("id", id.ToLower());
            componentElement.SetAttribute("name", property.Name);

            componentsElement.AppendChild(componentElement);

            AddComponents(componentElement, property.PropertyType, adapter, modelPath, dataItemAttribute?.Name ?? $"{componentPath}{property.Name}_");
            return hasComponents;
        }

        public static Type GetNearestComponentModelType(Type type)
        {
            Type currentType = type.BaseType;
            while (currentType != null)
            {
                if (typeof(IComponentModel).IsAssignableFrom(currentType))
                {
                    return currentType;
                }
                currentType = currentType.BaseType;
            }
            return null;
        }

        private static void AddDataItems(XmlNode xDataItems, IEnumerable<DataItem> dataItems)
        {
            foreach (var deviceDataItem in dataItems)
            {
                // Build DataItem element
                xDataItems.AppendChild(CreateDataItemElement(xDataItems.OwnerDocument, deviceDataItem.Category, deviceDataItem.ObservationalType, deviceDataItem.ObservationalSubType, deviceDataItem.Name, deviceDataItem.Units));
            }
        }

        private static XmlElement CreateDataItemElement(XmlDocument xDoc, string category, string type, string subType, string id, string nativeUnits = null, string description = null)
        {
            var xDataItem = xDoc.CreateElement("DataItem");

            xDataItem.SetAttribute("category", category.ToUpper());

            bool isDefined = false;
            switch (category.ToUpper())
            {
                case "SAMPLE":
                    isDefined = Enum.TryParse<SampleTypes>(type, true, out var _);
                    break;
                case "EVENT":
                    isDefined = Enum.TryParse<EventTypes>(type, true, out var _);
                    break;
                case "CONDITION":
                    isDefined = Enum.TryParse<ConditionTypes>(type, true, out var _)
                        || Enum.TryParse<SampleTypes>(type, true, out var _)
                        || Enum.TryParse<EventTypes>(type, true, out var _);
                    break;
                default:
                    break;
            }
            xDataItem.SetAttribute("type", isDefined && !type.StartsWith("x:") ? type : $"x:{type ?? id}");

            if (!string.IsNullOrEmpty(subType))
                xDataItem.SetAttribute("subType", subType);

            xDataItem.SetAttribute("id", id);

            xDataItem.SetAttribute("name", id);

            if (!string.IsNullOrEmpty(nativeUnits))
                xDataItem.SetAttribute("nativeUnits", nativeUnits);

            if (!string.IsNullOrEmpty(type) && UnitHelper.TypeLookup.TryGetValue(type, out var unit))
                xDataItem.SetAttribute("units", UnitHelper.ToString(unit));

            if (!string.IsNullOrEmpty(description))
                xDataItem.AppendChild(xDoc.CreateElement("Definition")).AppendChild(xDoc.CreateElement("Description")).InnerText = description;

            // TODO: Add coordinateSystem to DataItem and/or consider adding a CoordinateSystemAttribute to be used on IAdapterDataModel

            return xDataItem;
        }


        // TODO: Update DataItem to yield the enum of Type and SubType.
        // TODO: Update DataItem to internally manage the "Introduced" and "Deprecated" properties according to the Type/SubType
        private string GetMaximumMtconnectVersion(Adapter adapter)
        {
            return "2.2";
        }

        private class DataItemValues
        {
            // Compiler improvements
            private const string CATEGORY = "category";
            private const string TYPE = "type";
            private const string SUB_TYPE = "subType";
            private const string NAME = "name";
            private const string UNITS = "units";
            private const string DESCRIPTION = "description";

            private Dictionary<string, string> _values = new Dictionary<string, string>()
            {
                { CATEGORY, null },
                { TYPE, null },
                { SUB_TYPE, null },
                { NAME, null },
                { UNITS, null },
                { DESCRIPTION, null }
            };

            public string Category
            {
                get => _values[CATEGORY];
                set => SetValue(CATEGORY, value);
            }
            public string Type
            {
                get => _values[TYPE];
                set => SetValue(TYPE, value);
            }
            public string SubType
            {
                get => _values[SUB_TYPE];
                set => SetValue(SUB_TYPE, value);
            }
            public string Name
            {
                get => _values[NAME];
                set => SetValue(NAME, value);
            }
            public string Units
            {
                get => _values[UNITS];
                set => SetValue(UNITS, value);
            }
            public string Description
            {
                get => _values[DESCRIPTION];
                set => SetValue(DESCRIPTION, value);
            }

            public bool FoundDataItem { get; set; }

            private void SetValue(string key, string value)
            {
                if (!string.IsNullOrEmpty(_values[key]))
                    return;

                _values[key] = value;
            }
        }
    }

}
