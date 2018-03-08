using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using NetCoreForce.Client.Attributes;

namespace NetCoreForce.Client.Models
{
    [JsonConverter(typeof(AggregateResultJsonConverter))]
    public class AggregateResultRecord
    {
        [JsonProperty(PropertyName = "attributes")]
        public AggregateResultAttributes Attributes { get; set; }

        public Dictionary<string, string> Values { get; set; }

        public AggregateResultRecord()
        {
            // this.Attributes = new AggregateResultAttributes();
            // this.Values = new Dictionary<string, string>();
        }
    }
}