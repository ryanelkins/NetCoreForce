using System.Runtime.Serialization;

namespace NetCoreForce.Client.BulkApi
{
    public enum Operation
    {
        /// <summary>
        /// Insert
        /// </summary>
        [EnumMember(Value = "insert")]
        Insert,

        /// <summary>
        /// Delete
        /// </summary>
        [EnumMember(Value = "delete")]
        Delete,

        /// <summary>
        /// Update
        /// </summary>
        [EnumMember(Value = "update")]
        Update,

        /// <summary>
        /// Upsert
        /// </summary>
        [EnumMember(Value = "upsert")]
        Upsert
    }
}