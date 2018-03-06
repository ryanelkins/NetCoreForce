using System.Runtime.Serialization;

namespace NetCoreForce.Client.BulkApi
{
    public enum ColumnDelimiter
    {
        /// <summary>
        /// Comma character (,) - default
        /// </summary>
        [EnumMember(Value = "COMMA")]
        Comma = 0,

        /// <summary>
        /// Backquote character (`)
        /// </summary>
        [EnumMember(Value = "BACKQUOTE")]
        Backquote,

        /// <summary>
        /// Caret character (^)
        /// </summary>
        [EnumMember(Value = "CARET")]
        Caret,        

        /// <summary>
        /// Pipe character (|)
        /// </summary>
        [EnumMember(Value = "PIPE")]
        Pipe,

        /// <summary>
        /// semicolon character (;)
        /// </summary>
        [EnumMember(Value = "SEMICOLON")]
        Semicolon,

        /// <summary>
        /// tab character
        /// </summary>
        [EnumMember(Value = "TAB")]
        Tab
    }
}