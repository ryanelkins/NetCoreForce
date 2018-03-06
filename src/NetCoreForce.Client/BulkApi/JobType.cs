using System.Runtime.Serialization;

namespace NetCoreForce.Client.BulkApi
{
    public enum JobType
    {
        /// <summary>
        /// V2Ingest — Bulk API 2.0 job
        /// </summary>
        [EnumMember(Value = "V2Ingest")]
        V2Ingest = 0,

        /// <summary>
        /// BigObjectIngest — BigObjects job
        /// </summary>
        [EnumMember(Value = "BigObjectIngest")]
        BigObjectIngest,

        /// <summary>
        /// Classic — Bulk API 1.0 job
        /// </summary>
        [EnumMember(Value = "Classic")]
        Classic        
    }
}