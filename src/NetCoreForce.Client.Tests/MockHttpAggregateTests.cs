using System;
using System.Net;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using NetCoreForce.Client;
using NetCoreForce.Client.Models;
using Xunit;
using NetCoreForce.Models;

namespace NetCoreForce.Client.Tests
{
    public class MockHttpAggregateTests
    {
        //test with empty response content

        [Fact]
        public async void ObjectById()
        {
            var mockHandler = new MockHttpClientHandler();

            HttpResponseMessage respMsg = MockResponse.GetResponse("aggregate_result.json", HttpStatusCode.OK);

            Uri requestUri = new Uri("https://na73.salesforce.com/services/data/v41.0/query?q=SELECT%20MailingCountry,%20COUNT(Id)%20FROM%20Contact%20GROUP%20BY%20MailingCountry");

            mockHandler.AddMockResponse(requestUri, respMsg);

            HttpClient httpClient = new HttpClient(mockHandler);

            ForceClient client = new ForceClient("https://na73.salesforce.com", "v41.0", "dummyToken", httpClient);

            var result = await client.Query<AggregateResultRecord>("SELECT MailingCountry, COUNT(Id) FROM Contact GROUP BY MailingCountry");

            Assert.NotNull(result);
            Assert.Equal(8, result.Count);
            Assert.Equal("AggregateResult", result[0].Attributes.Type);
            Assert.Equal("CA", result[0].Values["MailingCountry"]);
            Assert.Equal("1017", result[0].Values["expr0"]);
        }
    }
}
