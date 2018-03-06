using Newtonsoft.Json;
using System;

namespace NetCoreForce.Client.BulkApi
{
    /// <summary>
    /// Bulk API Job Info
    /// </summary>
    public class JobInfo
    {
        /// <summary>
        /// The API version that the job was created in.
        /// </summary>
        [JsonProperty(PropertyName = "apiVersion")]
        public string ApiVersion { get; set; }

        /// <summary>
        /// The column delimiter used for CSV job data. The default value is COMMA
        /// Optional
        /// </summary>
        /// <seealso cref="ColumnDelimiters"/>  
        [JsonProperty(PropertyName = "columnDelimiter")]
        public string ColumnDelimiter { get; set; }

        /// <summary>
        /// The concurrency mode for the job.
        /// </summary>
        /// <seealso cref="ConcurrencyModes"/>  
        [JsonProperty(PropertyName = "concurrencyMode")]
        public string ConcurrencyMode { get; set; }

        /// <summary>
        /// The format of the data being processed. Only CSV is supported.
        /// </summary>
        [JsonProperty(PropertyName = "contentType")]
        public string ContentType { get; set; }

        /// <summary>
        /// The URL to use for Upload Job Data requests for this job. Only valid if the job is in Open state.
        /// </summary>
        [JsonProperty(PropertyName = "contentUrl")]
        public string ContentUrl { get; set; }

        /// <summary>
        /// The ID of the user who created the job.
        /// </summary>
        [JsonProperty(PropertyName = "createdById")]
        public string CreatedById { get; set; }

        /// <summary>
        /// The date and time in the UTC time zone when the job was created.
        /// </summary>
        [JsonProperty(PropertyName = "createdDate")]
        public DateTimeOffset? CreatedDate { get; set; }

        /// <summary>
        /// Unique ID for this job.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// The job’s type. Values include:
        /// <para>
        /// BigObjectIngest—BigObjects job
        /// Classic—Bulk API 1.0 job
        /// V2Ingest—Bulk API 2.0 job
        ///</para>
        /// </summary>
        [JsonProperty(PropertyName = "jobType")]
        public string jobType { get; set; }

        /// <summary>
        /// The line ending used for CSV job data
        /// </summary>
        /// <seealso cref="LineEndings"/>
        [JsonProperty(PropertyName = "lineEnding")]
        public string LineEnding { get; set; }

        /// <summary>
        /// The object type for the data being processed.
        /// </summary>
        [JsonProperty(PropertyName = "object")]
        public string Object { get; set; }

        /// <summary>
        /// The processing operation for the job
        /// </summary>
        /// <seealso cref="Operations"/>
        [JsonProperty(PropertyName = "operation")]
        public string Operation { get; set; }

        /// <summary>
        /// The current state of processing for the job
        /// <para>
        /// Open — The job has been created, and data can be added to the job.
        /// UploadComplete — No new data can be added to this job. You can’t edit or save a closed job.
        /// Aborted — The job has been aborted. You can abort a job if you created it or if you have the “Manage Data Integrations” permission.
        /// JobComplete — The job was processed by Salesforce.
        /// Failed — The job has failed. Job data that was successfully processed isn’t rolled back.
        /// </para>
        /// </summary>
        /// <seealso cref="JobStates"/>
        [JsonProperty(PropertyName = "state")]
        public string State { get; set; }

        /// <summary>
        /// Date and time in the UTC time zone when the job finished.
        /// </summary>
        [JsonProperty(PropertyName = "systemModstamp")]
        public DateTimeOffset? SystemModstamp { get; set; }

    }
}