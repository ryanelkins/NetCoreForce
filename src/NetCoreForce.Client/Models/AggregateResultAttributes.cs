using Newtonsoft.Json;

namespace NetCoreForce.Client.Models
{
    public class AggregateResultAttributes
    {
        /// <summary>
        /// This record’s type.
        /// typically "AggregateResult"
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }
    }
}