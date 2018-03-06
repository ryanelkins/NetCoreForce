using System;
using System.Collections.Generic;
using NetCoreForce.Client.Models;

namespace NetCoreForce.Client.BulkApi
{
    public static class BulkApiUriFormatter
    {
        /// <summary>
        /// Bulk API Create Job
        /// </summary>
        public static Uri CreateJobUrlUrl(string instanceUrl, string apiVersion)
        {
            if (string.IsNullOrEmpty(instanceUrl)) throw new ArgumentNullException("instanceUrl");
            if (string.IsNullOrEmpty(apiVersion)) throw new ArgumentNullException("apiVersion");

            // https://developer.salesforce.com/docs/atlas.en-us.api_bulk_v2.meta/api_bulk_v2/create_job.htm

            Uri uri = new Uri(new Uri(instanceUrl), string.Format("/services/data/{0}/jobs/ingest", apiVersion));

            return uri;
        }

        /// <summary>
        /// Bulk API Upload Job Data
        /// </summary>
        public static Uri UploadJobDataUrl(string instanceUrl, string apiVersion, string jobId)
        {
            if (string.IsNullOrEmpty(instanceUrl)) throw new ArgumentNullException("instanceUrl");
            if (string.IsNullOrEmpty(apiVersion)) throw new ArgumentNullException("apiVersion");
            if (string.IsNullOrEmpty(apiVersion)) throw new ArgumentNullException("jobId");

            // https://developer.salesforce.com/docs/atlas.en-us.api_bulk_v2.meta/api_bulk_v2/upload_job_data.htm

            Uri uri = new Uri(new Uri(instanceUrl), string.Format("/services/data/{0}/jobs/ingest/{1}/batches", apiVersion, jobId));

            return uri;
        }

        /// <summary>
        /// Bulk API Job
        /// <para>Used for Info, Close/Abort, Delete</para>
        /// </summary>
        public static Uri JobUrl(string instanceUrl, string apiVersion, string jobId)
        {
            if (string.IsNullOrEmpty(instanceUrl)) throw new ArgumentNullException("instanceUrl");
            if (string.IsNullOrEmpty(apiVersion)) throw new ArgumentNullException("apiVersion");
            if (string.IsNullOrEmpty(apiVersion)) throw new ArgumentNullException("jobId");

            // https://developer.salesforce.com/docs/atlas.en-us.api_bulk_v2.meta/api_bulk_v2/upload_job_data.htm

            Uri uri = new Uri(new Uri(instanceUrl), string.Format("/services/data/{0}/jobs/ingest/{1}", apiVersion, jobId));

            return uri;
        }
        
        /// <summary>
        /// Get All Jobs
        /// </summary>
        /// <param name="instanceUrl">SFDC instance URL, e.g. "https://na99.salesforce.com"</param>
        /// <param name="apiVersion">SFDC API version, e.g. "v41.0"</param>
        /// <param name="concurrencyMode">Optional. Filters jobs based on concurrency mode.</param>
        /// <param name="isPkChunkingEnabled">Optional. If set to true, filters jobs with PK chunking enabled.</param>
        /// <param name="jobType">Optional. Filters jobs based on job type</param>
        /// <param name="queryLocator">Optional. Use queryLocator with a locator value to get a specific set of job results. Get All Jobs returns up to 1000 result rows per request, along with a nextRecordsUrl value that contains the locator value used to get the next set of results.</param>
        public static Uri GetAllJobsUrl(string instanceUrl, string apiVersion,
            ConcurrencyMode? concurrencyMode = null,
            bool? isPkChunkingEnabled = null,
            JobType? jobType = null,
            string queryLocator = null)
        {
            if (string.IsNullOrEmpty(instanceUrl)) throw new ArgumentNullException("instanceUrl");
            if (string.IsNullOrEmpty(apiVersion)) throw new ArgumentNullException("apiVersion");

            Uri baseUri = new Uri(new Uri(instanceUrl), string.Format("/services/data/{0}/jobs/ingest", apiVersion));

            string uri = baseUri.ToString();

            if (concurrencyMode.HasValue)
            {
                uri = QueryHelpers.AddQueryString(uri, "concurrencyMode", concurrencyMode.ToString());
            }

            if (isPkChunkingEnabled.HasValue)
            {
                uri = QueryHelpers.AddQueryString(uri, "isPkChunkingEnabled", isPkChunkingEnabled.ToString());
            }

            if (jobType.HasValue)
            {
                uri = QueryHelpers.AddQueryString(uri, "jobType", jobType.ToString());
            }

            if (!string.IsNullOrEmpty(queryLocator))
            {
                uri = QueryHelpers.AddQueryString(uri, "queryLocator", queryLocator);
            }

            return new Uri(uri);
        }

        /// <summary>
        /// Bulk API Job
        /// <para>Used for Info, Close/Abort, Delete</para>
        /// </summary>
        public static Uri JobSuccessfulRecordResultUrl(string instanceUrl, string apiVersion, string jobId)
        {
            if (string.IsNullOrEmpty(instanceUrl)) throw new ArgumentNullException("instanceUrl");
            if (string.IsNullOrEmpty(apiVersion)) throw new ArgumentNullException("apiVersion");
            if (string.IsNullOrEmpty(apiVersion)) throw new ArgumentNullException("jobId");

            Uri uri = new Uri(new Uri(instanceUrl), string.Format("/services/data/{0}/jobs/ingest/{1}/successfulResults", apiVersion, jobId));

            return uri;
        }
    }
}