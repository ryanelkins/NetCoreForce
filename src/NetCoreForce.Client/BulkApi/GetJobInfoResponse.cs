using Newtonsoft.Json;
using System;

namespace NetCoreForce.Client.BulkApi
{
    /// <summary>
    /// Get Job Info Response
    /// </summary>
    public class GetJobInfoResponse : JobInfo
    {
        /// <summary>
        /// The number of milliseconds taken to process triggers and other processes related to the job data.
        /// This doesn't include the time used for processing asynchronous and batch Apex operations.
        /// If there are no triggers, the value is 0.
        /// </summary>
        [JsonProperty(PropertyName = "apexProcessingTime")]
        public string ApexProcessingTime { get; set; }

        /// <summary>
        /// The number of milliseconds taken to actively process the job and includes apexProcessingTime,
        /// but doesn't include the time the job waited in the queue to be processed or the time required for serialization and deserialization.
        /// </summary>
        [JsonProperty(PropertyName = "apiActiveProcessingTime")]
        public string ApiActiveProcessingTime { get; set; }
    }
}