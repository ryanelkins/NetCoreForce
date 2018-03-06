using System.Runtime.Serialization;

namespace NetCoreForce.Client.BulkApi
{
    public enum LineEnding
    {
        /// <summary>
        /// LF — linefeed character
        /// </summary>
        [EnumMember(Value = "LF")]
        Lf,

        /// <summary>
        /// CRLF — carriage return character followed by a linefeed character
        /// </summary>
        [EnumMember(Value = "CRLF")]
        CrLf
    }
}