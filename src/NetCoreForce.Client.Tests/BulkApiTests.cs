using NetCoreForce.Client;
using NetCoreForce.Client.Attributes;
using NetCoreForce.Client.BulkApi;
using Newtonsoft.Json;
using Xunit;
using System;

namespace NetCoreForce.Client.Tests
{

    public class BulkApiTests
    {
        [Fact]
        public void EnumSerialization()
        {
            var obj = new CreateJobRequest();
            obj.ColumnDelimiter = ColumnDelimiter.Caret;

            string serialized = JsonSerializer.SerializeForCreate(obj);           

            var ds = JsonSerializer.Deserialize<CreateJobRequest>(serialized);

            Assert.True(serialized.Contains("CARET"));
            Assert.Equal(ColumnDelimiter.Caret, ds.ColumnDelimiter);
        }

        [Fact]
        public void ValidCloseJobStates()
        {
            var req = new CloseJobRequest();

            req.State = JobState.UploadComplete;
            req.State = JobState.Aborted;            

            Assert.Throws<ArgumentException>(() => {
                req.State = JobState.Failed;
            });

            Assert.Throws<ArgumentException>(() => {
                req.State = JobState.JobComplete;
            });

            Assert.Throws<ArgumentException>(() => {
                req.State = JobState.Open;
            });

            Assert.Throws<ArgumentException>(() => {
                var req2 = new CloseJobRequest(JobState.Open);
            });
        }

        const string _apiVersion = "v41.0";
        const string _instanceUrl = "https://xxx.salesforce.com";

        [Fact]
        public void GetAllJobsUrl()
        {
            string expected = "https://xxx.salesforce.com/services/data/v41.0/jobs/ingest?concurrencyMode=Parallel&isPkChunkingEnabled=True&jobType=V2Ingest";
            string expectedLocalPath = "/services/data/v41.0/jobs/ingest";
            string expectedHost = "xxx.salesforce.com";

            var uri = BulkApiUriFormatter.GetAllJobsUrl(_instanceUrl, _apiVersion, ConcurrencyMode.Parallel, true, JobType.V2Ingest);
            Assert.Equal(expected, uri.AbsoluteUri);
            Assert.Equal(expectedLocalPath, uri.LocalPath);
            Assert.Equal(expectedHost, uri.Host);
        }
    }
}
