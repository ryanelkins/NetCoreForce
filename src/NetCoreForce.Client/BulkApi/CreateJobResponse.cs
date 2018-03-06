using Newtonsoft.Json;
using System;

namespace NetCoreForce.Client.BulkApi
{
    /// <summary>
    /// Bulk API Create Job Response
    /// </summary>
    public class CreateJobResponse : JobInfo
    {
        /// <summary>
        /// The name of the external ID field for an upsert.
        /// </summary>
        [JsonProperty(PropertyName = "externalIdFieldName")]
        public string ExternalIdFieldName { get; set; }

    }
}