using System;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;
using NetCoreForce.Client;
using NetCoreForce.Client.Attributes;
using NetCoreForce.Client.Models;
using NetCoreForce.Models;
using Newtonsoft.Json;

namespace NetCoreForce.FunctionalTests
{
    public class AggregateQueryTests : IClassFixture<ForceClientFixture>
    {
        ForceClientFixture forceClientFixture;

        public AggregateQueryTests(ForceClientFixture fixture)
        {
            this.forceClientFixture = fixture;
        }

        [Fact]
        public async Task AggregateQuery()
        {
            ForceClient client = await forceClientFixture.GetForceClient();

            // var result = await client.Query<object>("SELECT MailingCountry, COUNT(Id) Total FROM Contact GROUP BY MailingCountry ORDER BY Count(Id) DESC LIMIT 5");
            var result = await client.Query<AggregateResultRecord>("SELECT MailingCountry, COUNT(Id) FROM Contact GROUP BY MailingCountry ORDER BY Count(Id) DESC LIMIT 5");

            Assert.NotNull(result);

        }

        [Fact]
        public async Task AggregateQueryNoResults()
        {
            ForceClient client = await forceClientFixture.GetForceClient();

            var result = await client.Query<AggregateResultRecord>("SELECT MailingCountry, COUNT(Id) FROM Contact GROUP BY MailingCountry LIMIT 0");

            Assert.NotNull(result);
            Assert.Equal(0, result.Count);
        }

        // [Fact]
        // public async Task AggregateQueryWithNull()
        // {
        //     ForceClient client = await forceClientFixture.GetForceClient("http://localhost:8888");

        //     var result = await client.Query<AggregateResultRecord>("SELECT MailingCountry, COUNT(Id) FROM Contact GROUP BY MailingCountry");

        //     Assert.NotNull(result);
        // }
    }
}