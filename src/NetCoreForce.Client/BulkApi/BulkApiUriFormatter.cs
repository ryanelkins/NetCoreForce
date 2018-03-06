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
        public static Uri CreateJobUrl(string instanceUrl, string apiVersion)
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
        public static Uri UploadJobData(string instanceUrl, string apiVersion, string jobId)
        {
            if (string.IsNullOrEmpty(instanceUrl)) throw new ArgumentNullException("instanceUrl");
            if (string.IsNullOrEmpty(apiVersion)) throw new ArgumentNullException("apiVersion");
            if (string.IsNullOrEmpty(apiVersion)) throw new ArgumentNullException("jobId");

            // https://developer.salesforce.com/docs/atlas.en-us.api_bulk_v2.meta/api_bulk_v2/upload_job_data.htm

            Uri uri = new Uri(new Uri(instanceUrl), string.Format("/services/data/{0}/jobs/ingest/{1}/batches", apiVersion, jobId));

            return uri;
        }

        /// <summary>
        /// Bulk API Job Resource
        /// <para>Used for Info, Close, Abort, Delete</para>
        /// </summary>
        public static Uri JobResource(string instanceUrl, string apiVersion, string jobId)
        {
            if (string.IsNullOrEmpty(instanceUrl)) throw new ArgumentNullException("instanceUrl");
            if (string.IsNullOrEmpty(apiVersion)) throw new ArgumentNullException("apiVersion");
            if (string.IsNullOrEmpty(apiVersion)) throw new ArgumentNullException("jobId");

            // https://developer.salesforce.com/docs/atlas.en-us.api_bulk_v2.meta/api_bulk_v2/upload_job_data.htm

            Uri uri = new Uri(new Uri(instanceUrl), string.Format("/services/data/{0}/jobs/ingest/{1}", apiVersion, jobId));

            return uri;
        }
    }
}