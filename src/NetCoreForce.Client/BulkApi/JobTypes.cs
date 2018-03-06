namespace NetCoreForce.Client.BulkApi
{
    public static class JobTypes
    {
        /// <summary>
        /// BigObjectIngest — BigObjects job
        /// </summary>
        public const string BigObjectIngest = "BigObjectIngest";

        /// <summary>
        /// Classic — Bulk API 1.0 job
        /// </summary>
        public const string Classic = "Classic";

        /// <summary>
        /// V2Ingest — Bulk API 2.0 job
        /// </summary>
        public const string V2Ingest = "V2Ingest";
    }
}