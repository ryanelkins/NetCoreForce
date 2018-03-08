using System;
using System.Collections.Generic;
using System.Reflection;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NetCoreForce.Client.Models;

public class AggregateResultJsonConverter : JsonConverter
{
    public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
    {
        throw new System.NotImplementedException();
    }

    public override bool CanConvert(Type objectType)
    {
        return typeof(AggregateResultRecord).GetTypeInfo().IsAssignableFrom(objectType.GetTypeInfo());
    }

    public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
    {
        JObject item = JObject.Load(reader);

        var record = new AggregateResultRecord()
        {
            Values = new Dictionary<string, string>()
        };

        foreach (var child in item.Children())
        {
            if (child.Type == JTokenType.Property)
            {
                if (child.Path == "attributes")
                {
                    record.Attributes = JsonConvert.DeserializeObject<AggregateResultAttributes>(child.First.ToString());
                }
                else
                {
                    record.Values.Add(child.Path, child.First.Value<string>());
                }
            }
        }

        return record;
    }
}
