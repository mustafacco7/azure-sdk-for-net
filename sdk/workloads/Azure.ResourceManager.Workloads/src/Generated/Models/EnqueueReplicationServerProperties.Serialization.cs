// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Workloads.Models
{
    public partial class EnqueueReplicationServerProperties : IUtf8JsonSerializable, IJsonModel<EnqueueReplicationServerProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<EnqueueReplicationServerProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<EnqueueReplicationServerProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EnqueueReplicationServerProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EnqueueReplicationServerProperties)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(ErsVersion))
            {
                writer.WritePropertyName("ersVersion"u8);
                writer.WriteStringValue(ErsVersion.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(InstanceNo))
            {
                writer.WritePropertyName("instanceNo"u8);
                writer.WriteStringValue(InstanceNo);
            }
            if (options.Format != "W" && Optional.IsDefined(Hostname))
            {
                writer.WritePropertyName("hostname"u8);
                writer.WriteStringValue(Hostname);
            }
            if (options.Format != "W" && Optional.IsDefined(KernelVersion))
            {
                writer.WritePropertyName("kernelVersion"u8);
                writer.WriteStringValue(KernelVersion);
            }
            if (options.Format != "W" && Optional.IsDefined(KernelPatch))
            {
                writer.WritePropertyName("kernelPatch"u8);
                writer.WriteStringValue(KernelPatch);
            }
            if (options.Format != "W" && Optional.IsDefined(IPAddress))
            {
                writer.WritePropertyName("ipAddress"u8);
                writer.WriteStringValue(IPAddress);
            }
            if (options.Format != "W" && Optional.IsDefined(Health))
            {
                writer.WritePropertyName("health"u8);
                writer.WriteStringValue(Health.Value.ToString());
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
        }

        EnqueueReplicationServerProperties IJsonModel<EnqueueReplicationServerProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EnqueueReplicationServerProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EnqueueReplicationServerProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeEnqueueReplicationServerProperties(document.RootElement, options);
        }

        internal static EnqueueReplicationServerProperties DeserializeEnqueueReplicationServerProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            EnqueueReplicationServerType? ersVersion = default;
            string instanceNo = default;
            string hostname = default;
            string kernelVersion = default;
            string kernelPatch = default;
            string ipAddress = default;
            SapHealthState? health = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ersVersion"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ersVersion = new EnqueueReplicationServerType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("instanceNo"u8))
                {
                    instanceNo = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("hostname"u8))
                {
                    hostname = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("kernelVersion"u8))
                {
                    kernelVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("kernelPatch"u8))
                {
                    kernelPatch = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ipAddress"u8))
                {
                    ipAddress = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("health"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    health = new SapHealthState(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new EnqueueReplicationServerProperties(
                ersVersion,
                instanceNo,
                hostname,
                kernelVersion,
                kernelPatch,
                ipAddress,
                health,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<EnqueueReplicationServerProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EnqueueReplicationServerProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(EnqueueReplicationServerProperties)} does not support writing '{options.Format}' format.");
            }
        }

        EnqueueReplicationServerProperties IPersistableModel<EnqueueReplicationServerProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EnqueueReplicationServerProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeEnqueueReplicationServerProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(EnqueueReplicationServerProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<EnqueueReplicationServerProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
