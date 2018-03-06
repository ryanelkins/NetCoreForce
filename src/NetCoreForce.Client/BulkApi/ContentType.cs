using System.Runtime.Serialization;

namespace NetCoreForce.Client.BulkApi
{
    public enum ContentType
    {
        /// <summary>
        /// CSV - Default and only option
        /// </summary>
        [EnumMember(Value = "CSV")]
        CSV = 0
    }
}