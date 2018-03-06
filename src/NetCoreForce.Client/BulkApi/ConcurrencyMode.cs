using System.Runtime.Serialization;

namespace NetCoreForce.Client.BulkApi
{
    public enum ConcurrencyMode
    {
        /// <summary>
        /// Parallel: Process records in parallel mode. This is the default value.
        /// </summary>
        [EnumMember(Value = "Parallel")]
        Parallel = 0,

        /// <summary>
        /// Serial: Process records in serial mode.
        /// Processing in parallel can cause database contention. When this is severe, the job can fail.
        /// If you’re experiencing this issue, submit the job with serial concurrency mode.
        /// This mode guarantees that records are processed serially, but can significantly increase the processing time.
        /// </summary>
        [EnumMember(Value = "Serial")]
        Serial,
    }
}