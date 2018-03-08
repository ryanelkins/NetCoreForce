using NetCoreForce.Client;
using NetCoreForce.Client.Models;
using NetCoreForce.Client.Attributes;
using Newtonsoft.Json;
using Xunit;

namespace NetCoreForce.Client.Tests
{
    public class AggregateJsonConverterTests
    {
        const string _responseContent = "{\"totalSize\":5,\"done\":true,\"records\":[{\"attributes\":{\"type\":\"AggregateResult\"},\"MailingCountry\":\"GB\",\"expr0\":1036},{\"attributes\":{\"type\":\"AggregateResult\"},\"MailingCountry\":\"CA\",\"expr0\":1017},{\"attributes\":{\"type\":\"AggregateResult\"},\"MailingCountry\":\"FR\",\"expr0\":1015},{\"attributes\":{\"type\":\"AggregateResult\"},\"MailingCountry\":\"US\",\"expr0\":1004},{\"attributes\":{\"type\":\"AggregateResult\"},\"MailingCountry\":\"DE\",\"expr0\":926}]}";
        // const string _shortResponseContent = "{\"totalSize\":5,\"done\":true,\"records\":[{\"attributes\":{\"type\":\"AggregateResult\"},\"MailingCountry\":\"GB\",\"expr0\":1036}]}";
        
        [Fact]
        public void DeserializeAggregate()
        {
            var agResult = JsonConvert.DeserializeObject<QueryResult<AggregateResultRecord>>(_responseContent, new AggregateResultJsonConverter());

            Assert.NotNull(agResult);
            Assert.Equal(5, agResult.TotalSize);
            Assert.True(agResult.Done);
            Assert.Equal("AggregateResult", agResult.Records[0].Attributes.Type);
            Assert.Equal("GB", agResult.Records[0].Values["MailingCountry"]);
            Assert.Equal("1036", agResult.Records[0].Values["expr0"]);
        }

        [Fact]
        public void DeserializeAggregateNoRecords()
        {
            string content = "{\"totalSize\":0,\"done\":true,\"records\":[]}";

            var agResult = JsonConvert.DeserializeObject<QueryResult<AggregateResultRecord>>(content, new AggregateResultJsonConverter());

            Assert.NotNull(agResult);
            Assert.Equal(0, agResult.TotalSize);
            Assert.True(agResult.Done);
        }

        [Fact]
        public void DeserializeAggregateNullValue()
        {
            string content = "{\"totalSize\":1,\"done\":true,\"records\":[{\"attributes\":{\"type\":\"AggregateResult\"},\"MailingCountry\":null,\"expr0\": 16}]}";

            var agResult = JsonConvert.DeserializeObject<QueryResult<AggregateResultRecord>>(content, new AggregateResultJsonConverter());

            Assert.NotNull(agResult);
            Assert.Equal(1, agResult.TotalSize);
            Assert.True(agResult.Done);
            Assert.Null(agResult.Records[0].Values["MailingCountry"]);
        }
    }
}
