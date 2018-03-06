using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

namespace NetCoreForce.Client.BulkApi
{
    /// <summary>
    /// Bulk API Job Info
    /// </summary>
    public class CreateJobRequest
    {
        /// <summary>
        /// The column delimiter used for CSV job data. The default value is COMMA
        /// Optional
        /// </summary>
        /// <seealso cref="NetCoreForce.Client.BulkApi.ColumnDelimiter"/>  
        /// <returns></returns>
        [JsonProperty(PropertyName = "columnDelimiter")]
        [JsonConverter(typeof(StringEnumConverter))]
        public ColumnDelimiter? ColumnDelimiter { get; set; }


        /// <summary>
        /// The content type for the job. The only valid value (and the default) is CSV.
        /// Optional
        /// </summary>
        /// <seealso cref="NetCoreForce.Client.BulkApi.ContentType"/>
        [JsonProperty(PropertyName = "contentType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public ContentType? ContentType { get; set; }

        /// <summary>
        /// The external ID field in the object being updated. Only needed for upsert operations. Field values must also exist in CSV job data.
        /// Required for upsert operations
        /// </summary>
        [JsonProperty(PropertyName = "externalIdFieldName")]
        public string ExternalIdFieldName { get; set; }

        /// <summary>
        /// The line ending used for CSV job data, marking the end of a data row. The default is LF.
        /// Optional
        /// </summary>
        /// <seealso cref="NetCoreForce.Client.BulkApi.LineEnding"/>
        [JsonProperty(PropertyName = "lineEnding")]
        [JsonConverter(typeof(StringEnumConverter))]
        public LineEnding? LineEnding { get; set; }

        /// <summary>
        /// The object type for the data being processed. Use only a single object type per job.
        /// Required
        /// </summary>
        [JsonProperty(PropertyName = "object")]
        public string Object { get; set; }

        /// <summary>
        /// The processing operation for the job
        /// Required
        /// </summary>
        /// <seealso cref="NetCoreForce.Client.BulkApi.Operation"/>
        [JsonProperty(PropertyName = "operation")]
        [JsonConverter(typeof(StringEnumConverter))]
        public Operation? Operation { get; set; }

        public CreateJobRequest()
        {
            //Set defaults
            // this.ColumnDelimiter = "COMMA";
            // this.ContentType = "CSV";
            // this.LineEnding = "LF";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="objectName">The object type for the data being processed. Use only a single object type per job.</param>
        /// <param name="operation">The processing operation for the job. <see cref="Operation"/></param>
        /// <param name="externalIdFieldName">The external ID field in the object being updated. Only needed for upsert operations. Field values must also exist in CSV job data.</param>
        public CreateJobRequest(string objectName, Operation operation, string externalIdFieldName = null)
        {
            this.Object = objectName;
            this.Operation = operation;
            this.ExternalIdFieldName = externalIdFieldName;
        }

    }
}