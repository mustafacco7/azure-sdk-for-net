// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class CreateLinkedIntegrationRuntimeContent : IUtf8JsonSerializable, IJsonModel<CreateLinkedIntegrationRuntimeContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CreateLinkedIntegrationRuntimeContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CreateLinkedIntegrationRuntimeContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CreateLinkedIntegrationRuntimeContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CreateLinkedIntegrationRuntimeContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(SubscriptionId))
            {
                writer.WritePropertyName("subscriptionId"u8);
                writer.WriteStringValue(SubscriptionId);
            }
            if (Optional.IsDefined(DataFactoryName))
            {
                writer.WritePropertyName("dataFactoryName"u8);
                writer.WriteStringValue(DataFactoryName);
            }
            if (Optional.IsDefined(DataFactoryLocation))
            {
                writer.WritePropertyName("dataFactoryLocation"u8);
                writer.WriteStringValue(DataFactoryLocation.Value);
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        CreateLinkedIntegrationRuntimeContent IJsonModel<CreateLinkedIntegrationRuntimeContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CreateLinkedIntegrationRuntimeContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CreateLinkedIntegrationRuntimeContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCreateLinkedIntegrationRuntimeContent(document.RootElement, options);
        }

        internal static CreateLinkedIntegrationRuntimeContent DeserializeCreateLinkedIntegrationRuntimeContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<string> subscriptionId = default;
            Optional<string> dataFactoryName = default;
            Optional<AzureLocation> dataFactoryLocation = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("subscriptionId"u8))
                {
                    subscriptionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataFactoryName"u8))
                {
                    dataFactoryName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataFactoryLocation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dataFactoryLocation = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new CreateLinkedIntegrationRuntimeContent(name.Value, subscriptionId.Value, dataFactoryName.Value, Optional.ToNullable(dataFactoryLocation), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CreateLinkedIntegrationRuntimeContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CreateLinkedIntegrationRuntimeContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CreateLinkedIntegrationRuntimeContent)} does not support '{options.Format}' format.");
            }
        }

        CreateLinkedIntegrationRuntimeContent IPersistableModel<CreateLinkedIntegrationRuntimeContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CreateLinkedIntegrationRuntimeContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCreateLinkedIntegrationRuntimeContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CreateLinkedIntegrationRuntimeContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<CreateLinkedIntegrationRuntimeContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
