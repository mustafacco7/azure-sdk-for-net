// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    [PersistableModelProxy(typeof(UnknownLinkedService))]
    public partial class DataFactoryLinkedServiceProperties : IUtf8JsonSerializable, IJsonModel<DataFactoryLinkedServiceProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataFactoryLinkedServiceProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DataFactoryLinkedServiceProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataFactoryLinkedServiceProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataFactoryLinkedServiceProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(LinkedServiceType);
            if (Optional.IsDefined(ConnectVia))
            {
                writer.WritePropertyName("connectVia"u8);
                writer.WriteObjectValue(ConnectVia);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsCollectionDefined(Parameters))
            {
                writer.WritePropertyName("parameters"u8);
                writer.WriteStartObject();
                foreach (var item in Parameters)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(Annotations))
            {
                writer.WritePropertyName("annotations"u8);
                writer.WriteStartArray();
                foreach (var item in Annotations)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item);
#else
                    using (JsonDocument document = JsonDocument.Parse(item))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
                writer.WriteEndArray();
            }
            foreach (var item in AdditionalProperties)
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
            writer.WriteEndObject();
        }

        DataFactoryLinkedServiceProperties IJsonModel<DataFactoryLinkedServiceProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataFactoryLinkedServiceProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataFactoryLinkedServiceProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataFactoryLinkedServiceProperties(document.RootElement, options);
        }

        internal static DataFactoryLinkedServiceProperties DeserializeDataFactoryLinkedServiceProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AmazonMWS": return AmazonMwsLinkedService.DeserializeAmazonMwsLinkedService(element);
                    case "AmazonRdsForOracle": return AmazonRdsForOracleLinkedService.DeserializeAmazonRdsForOracleLinkedService(element);
                    case "AmazonRdsForSqlServer": return AmazonRdsForSqlServerLinkedService.DeserializeAmazonRdsForSqlServerLinkedService(element);
                    case "AmazonRedshift": return AmazonRedshiftLinkedService.DeserializeAmazonRedshiftLinkedService(element);
                    case "AmazonS3": return AmazonS3LinkedService.DeserializeAmazonS3LinkedService(element);
                    case "AmazonS3Compatible": return AmazonS3CompatibleLinkedService.DeserializeAmazonS3CompatibleLinkedService(element);
                    case "AppFigures": return AppFiguresLinkedService.DeserializeAppFiguresLinkedService(element);
                    case "Asana": return AsanaLinkedService.DeserializeAsanaLinkedService(element);
                    case "AzureBatch": return AzureBatchLinkedService.DeserializeAzureBatchLinkedService(element);
                    case "AzureBlobFS": return AzureBlobFSLinkedService.DeserializeAzureBlobFSLinkedService(element);
                    case "AzureBlobStorage": return AzureBlobStorageLinkedService.DeserializeAzureBlobStorageLinkedService(element);
                    case "AzureDataExplorer": return AzureDataExplorerLinkedService.DeserializeAzureDataExplorerLinkedService(element);
                    case "AzureDataLakeAnalytics": return AzureDataLakeAnalyticsLinkedService.DeserializeAzureDataLakeAnalyticsLinkedService(element);
                    case "AzureDataLakeStore": return AzureDataLakeStoreLinkedService.DeserializeAzureDataLakeStoreLinkedService(element);
                    case "AzureDatabricks": return AzureDatabricksLinkedService.DeserializeAzureDatabricksLinkedService(element);
                    case "AzureDatabricksDeltaLake": return AzureDatabricksDeltaLakeLinkedService.DeserializeAzureDatabricksDeltaLakeLinkedService(element);
                    case "AzureFileStorage": return AzureFileStorageLinkedService.DeserializeAzureFileStorageLinkedService(element);
                    case "AzureFunction": return AzureFunctionLinkedService.DeserializeAzureFunctionLinkedService(element);
                    case "AzureKeyVault": return AzureKeyVaultLinkedService.DeserializeAzureKeyVaultLinkedService(element);
                    case "AzureML": return AzureMLLinkedService.DeserializeAzureMLLinkedService(element);
                    case "AzureMLService": return AzureMLServiceLinkedService.DeserializeAzureMLServiceLinkedService(element);
                    case "AzureMariaDB": return AzureMariaDBLinkedService.DeserializeAzureMariaDBLinkedService(element);
                    case "AzureMySql": return AzureMySqlLinkedService.DeserializeAzureMySqlLinkedService(element);
                    case "AzurePostgreSql": return AzurePostgreSqlLinkedService.DeserializeAzurePostgreSqlLinkedService(element);
                    case "AzureSearch": return AzureSearchLinkedService.DeserializeAzureSearchLinkedService(element);
                    case "AzureSqlDW": return AzureSqlDWLinkedService.DeserializeAzureSqlDWLinkedService(element);
                    case "AzureSqlDatabase": return AzureSqlDatabaseLinkedService.DeserializeAzureSqlDatabaseLinkedService(element);
                    case "AzureSqlMI": return AzureSqlMILinkedService.DeserializeAzureSqlMILinkedService(element);
                    case "AzureStorage": return AzureStorageLinkedService.DeserializeAzureStorageLinkedService(element);
                    case "AzureSynapseArtifacts": return AzureSynapseArtifactsLinkedService.DeserializeAzureSynapseArtifactsLinkedService(element);
                    case "AzureTableStorage": return AzureTableStorageLinkedService.DeserializeAzureTableStorageLinkedService(element);
                    case "Cassandra": return CassandraLinkedService.DeserializeCassandraLinkedService(element);
                    case "CommonDataServiceForApps": return CommonDataServiceForAppsLinkedService.DeserializeCommonDataServiceForAppsLinkedService(element);
                    case "Concur": return ConcurLinkedService.DeserializeConcurLinkedService(element);
                    case "CosmosDb": return CosmosDBLinkedService.DeserializeCosmosDBLinkedService(element);
                    case "CosmosDbMongoDbApi": return CosmosDBMongoDBApiLinkedService.DeserializeCosmosDBMongoDBApiLinkedService(element);
                    case "Couchbase": return CouchbaseLinkedService.DeserializeCouchbaseLinkedService(element);
                    case "CustomDataSource": return CustomDataSourceLinkedService.DeserializeCustomDataSourceLinkedService(element);
                    case "Dataworld": return DataworldLinkedService.DeserializeDataworldLinkedService(element);
                    case "Db2": return Db2LinkedService.DeserializeDb2LinkedService(element);
                    case "Drill": return DrillLinkedService.DeserializeDrillLinkedService(element);
                    case "Dynamics": return DynamicsLinkedService.DeserializeDynamicsLinkedService(element);
                    case "DynamicsAX": return DynamicsAXLinkedService.DeserializeDynamicsAXLinkedService(element);
                    case "DynamicsCrm": return DynamicsCrmLinkedService.DeserializeDynamicsCrmLinkedService(element);
                    case "Eloqua": return EloquaLinkedService.DeserializeEloquaLinkedService(element);
                    case "FileServer": return FileServerLinkedService.DeserializeFileServerLinkedService(element);
                    case "FtpServer": return FtpServerLinkedService.DeserializeFtpServerLinkedService(element);
                    case "GoogleAdWords": return GoogleAdWordsLinkedService.DeserializeGoogleAdWordsLinkedService(element);
                    case "GoogleBigQuery": return GoogleBigQueryLinkedService.DeserializeGoogleBigQueryLinkedService(element);
                    case "GoogleCloudStorage": return GoogleCloudStorageLinkedService.DeserializeGoogleCloudStorageLinkedService(element);
                    case "GoogleSheets": return GoogleSheetsLinkedService.DeserializeGoogleSheetsLinkedService(element);
                    case "Greenplum": return GreenplumLinkedService.DeserializeGreenplumLinkedService(element);
                    case "HBase": return HBaseLinkedService.DeserializeHBaseLinkedService(element);
                    case "HDInsight": return HDInsightLinkedService.DeserializeHDInsightLinkedService(element);
                    case "HDInsightOnDemand": return HDInsightOnDemandLinkedService.DeserializeHDInsightOnDemandLinkedService(element);
                    case "Hdfs": return HdfsLinkedService.DeserializeHdfsLinkedService(element);
                    case "Hive": return HiveLinkedService.DeserializeHiveLinkedService(element);
                    case "HttpServer": return HttpLinkedService.DeserializeHttpLinkedService(element);
                    case "Hubspot": return HubspotLinkedService.DeserializeHubspotLinkedService(element);
                    case "Impala": return ImpalaLinkedService.DeserializeImpalaLinkedService(element);
                    case "Informix": return InformixLinkedService.DeserializeInformixLinkedService(element);
                    case "Jira": return JiraLinkedService.DeserializeJiraLinkedService(element);
                    case "LakeHouse": return LakeHouseLinkedService.DeserializeLakeHouseLinkedService(element);
                    case "Magento": return MagentoLinkedService.DeserializeMagentoLinkedService(element);
                    case "MariaDB": return MariaDBLinkedService.DeserializeMariaDBLinkedService(element);
                    case "Marketo": return MarketoLinkedService.DeserializeMarketoLinkedService(element);
                    case "MicrosoftAccess": return MicrosoftAccessLinkedService.DeserializeMicrosoftAccessLinkedService(element);
                    case "MongoDb": return MongoDBLinkedService.DeserializeMongoDBLinkedService(element);
                    case "MongoDbAtlas": return MongoDBAtlasLinkedService.DeserializeMongoDBAtlasLinkedService(element);
                    case "MongoDbV2": return MongoDBV2LinkedService.DeserializeMongoDBV2LinkedService(element);
                    case "MySql": return MySqlLinkedService.DeserializeMySqlLinkedService(element);
                    case "Netezza": return NetezzaLinkedService.DeserializeNetezzaLinkedService(element);
                    case "OData": return ODataLinkedService.DeserializeODataLinkedService(element);
                    case "Odbc": return OdbcLinkedService.DeserializeOdbcLinkedService(element);
                    case "Office365": return Office365LinkedService.DeserializeOffice365LinkedService(element);
                    case "Oracle": return OracleLinkedService.DeserializeOracleLinkedService(element);
                    case "OracleCloudStorage": return OracleCloudStorageLinkedService.DeserializeOracleCloudStorageLinkedService(element);
                    case "OracleServiceCloud": return OracleServiceCloudLinkedService.DeserializeOracleServiceCloudLinkedService(element);
                    case "Paypal": return PaypalLinkedService.DeserializePaypalLinkedService(element);
                    case "Phoenix": return PhoenixLinkedService.DeserializePhoenixLinkedService(element);
                    case "PostgreSql": return PostgreSqlLinkedService.DeserializePostgreSqlLinkedService(element);
                    case "Presto": return PrestoLinkedService.DeserializePrestoLinkedService(element);
                    case "QuickBooks": return QuickBooksLinkedService.DeserializeQuickBooksLinkedService(element);
                    case "Quickbase": return QuickbaseLinkedService.DeserializeQuickbaseLinkedService(element);
                    case "Responsys": return ResponsysLinkedService.DeserializeResponsysLinkedService(element);
                    case "RestService": return RestServiceLinkedService.DeserializeRestServiceLinkedService(element);
                    case "Salesforce": return SalesforceLinkedService.DeserializeSalesforceLinkedService(element);
                    case "SalesforceMarketingCloud": return SalesforceMarketingCloudLinkedService.DeserializeSalesforceMarketingCloudLinkedService(element);
                    case "SalesforceServiceCloud": return SalesforceServiceCloudLinkedService.DeserializeSalesforceServiceCloudLinkedService(element);
                    case "SalesforceServiceCloudV2": return SalesforceServiceCloudV2LinkedService.DeserializeSalesforceServiceCloudV2LinkedService(element);
                    case "SalesforceV2": return SalesforceV2LinkedService.DeserializeSalesforceV2LinkedService(element);
                    case "SapBW": return SapBWLinkedService.DeserializeSapBWLinkedService(element);
                    case "SapCloudForCustomer": return SapCloudForCustomerLinkedService.DeserializeSapCloudForCustomerLinkedService(element);
                    case "SapEcc": return SapEccLinkedService.DeserializeSapEccLinkedService(element);
                    case "SapHana": return SapHanaLinkedService.DeserializeSapHanaLinkedService(element);
                    case "SapOdp": return SapOdpLinkedService.DeserializeSapOdpLinkedService(element);
                    case "SapOpenHub": return SapOpenHubLinkedService.DeserializeSapOpenHubLinkedService(element);
                    case "SapTable": return SapTableLinkedService.DeserializeSapTableLinkedService(element);
                    case "ServiceNow": return ServiceNowLinkedService.DeserializeServiceNowLinkedService(element);
                    case "Sftp": return SftpServerLinkedService.DeserializeSftpServerLinkedService(element);
                    case "SharePointOnlineList": return SharePointOnlineListLinkedService.DeserializeSharePointOnlineListLinkedService(element);
                    case "Shopify": return ShopifyLinkedService.DeserializeShopifyLinkedService(element);
                    case "Smartsheet": return SmartsheetLinkedService.DeserializeSmartsheetLinkedService(element);
                    case "Snowflake": return SnowflakeLinkedService.DeserializeSnowflakeLinkedService(element);
                    case "SnowflakeV2": return SnowflakeV2LinkedService.DeserializeSnowflakeV2LinkedService(element);
                    case "Spark": return SparkLinkedService.DeserializeSparkLinkedService(element);
                    case "SqlServer": return SqlServerLinkedService.DeserializeSqlServerLinkedService(element);
                    case "Square": return SquareLinkedService.DeserializeSquareLinkedService(element);
                    case "Sybase": return SybaseLinkedService.DeserializeSybaseLinkedService(element);
                    case "TeamDesk": return TeamDeskLinkedService.DeserializeTeamDeskLinkedService(element);
                    case "Teradata": return TeradataLinkedService.DeserializeTeradataLinkedService(element);
                    case "Twilio": return TwilioLinkedService.DeserializeTwilioLinkedService(element);
                    case "Vertica": return VerticaLinkedService.DeserializeVerticaLinkedService(element);
                    case "Warehouse": return WarehouseLinkedService.DeserializeWarehouseLinkedService(element);
                    case "Web": return WebLinkedService.DeserializeWebLinkedService(element);
                    case "Xero": return XeroLinkedService.DeserializeXeroLinkedService(element);
                    case "Zendesk": return ZendeskLinkedService.DeserializeZendeskLinkedService(element);
                    case "Zoho": return ZohoLinkedService.DeserializeZohoLinkedService(element);
                }
            }
            return UnknownLinkedService.DeserializeUnknownLinkedService(element);
        }

        BinaryData IPersistableModel<DataFactoryLinkedServiceProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataFactoryLinkedServiceProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DataFactoryLinkedServiceProperties)} does not support '{options.Format}' format.");
            }
        }

        DataFactoryLinkedServiceProperties IPersistableModel<DataFactoryLinkedServiceProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataFactoryLinkedServiceProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDataFactoryLinkedServiceProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataFactoryLinkedServiceProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataFactoryLinkedServiceProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
