using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

namespace NetCoreForce.Client.BulkApi
{
    /// <summary>
    /// Bulk API Close or Abort Job Request
    /// </summary>
    public class CloseJobRequest
    {
        private JobState _jobState;
        /// <summary>
        /// The state to update the job to. Use UploadComplete to close a job, or Aborted to abort a job.
        /// </summary>
        /// <seealso cref="NetCoreForce.Client.BulkApi.JobState"/>
        [JsonProperty(PropertyName = "state")]
        [JsonConverter(typeof(StringEnumConverter))]
        // public JobState? State { get; set; }
        public JobState State
        {
            get
            {
                return this._jobState;
            }
            set
            {
                if (value == JobState.UploadComplete || value == JobState.Aborted)
                {
                    this._jobState = value;
                }
                else
                {
                    throw new ArgumentException("Valid values are UploadComplete or Aborted", "State");
                }
            }
        }

        public CloseJobRequest()
        {
        }

        public CloseJobRequest(JobState state)
        {
            this.State = state;
        }

    }
}