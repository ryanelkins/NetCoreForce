namespace NetCoreForce.Client.BulkApi
{
    public static class JobStates
    {
        /// <summary>
        /// Open — The job has been created, and data can be added to the job.
        /// </summary>
        public const string Open = "Open";

        /// <summary>
        /// UploadComplete — No new data can be added to this job. You can’t edit or save a closed job.
        /// </summary>
        public const string UploadComplete = "UploadComplete";

        /// <summary>
        /// Aborted — The job has been aborted. You can abort a job if you created it or if you have the “Manage Data Integrations” permission.
        /// </summary>
        public const string Aborted = "Aborted";

        /// <summary>
        /// JobComplete — The job was processed by Salesforce.
        /// </summary>
        public const string JobComplete = "JobComplete";

        /// <summary>
        /// Failed — The job has failed. Job data that was successfully processed isn’t rolled back.
        /// </summary>
        public const string Failed = "Failed";
    }
}