namespace NetCoreForce.Client.BulkApi
{
    public static class ConcurrencyModes
    {
        /// <summary>
        /// Parallel: Process records in parallel mode. This is the default value.
        /// </summary>
        public const string Parallel = "Parallel";

        /// <summary>
        /// Serial: Process records in serial mode.
        /// Processing in parallel can cause database contention. When this is severe, the job can fail.
        /// If you’re experiencing this issue, submit the job with serial concurrency mode.
        /// This mode guarantees that records are processed serially, but can significantly increase the processing time.
        /// </summary>
        public const string Serial = "Serial";
    }
}