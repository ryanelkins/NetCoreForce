using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace NetCoreForce.Client.BulkApi
{
    /// <summary>
    /// Bulk API Close Job Response
    /// </summary>
    public class GetAllJobsResponse
    {
        /// <summary>
        /// Indicates whether there are more jobs to get. If false, use the nextRecordsUrl value to retrieve the next group of jobs.
        /// </summary>
        [JsonProperty(PropertyName = "done")]
        public bool Done { get; set; }

        /// <summary>
        /// Contains information for each retrieved job.
        /// </summary>
        [JsonProperty(PropertyName = "records")]
        public List<JobInfo> Records { get; set; }

        /// <summary>
        /// A URL that contains a query locator used to get the next set of results in a subsequent request if done isn’t true.
        /// </summary>
        [JsonProperty(PropertyName = "nextRecordsUrl")]
        public string NextRecordsUrl { get; set; }
    }
}