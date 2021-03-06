/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Taskrouter.V1.Workspace.Worker 
{

    /// <summary>
    /// ReadWorkerChannelOptions
    /// </summary>
    public class ReadWorkerChannelOptions : ReadOptions<WorkerChannelResource> 
    {
        /// <summary>
        /// The workspace_sid
        /// </summary>
        public string PathWorkspaceSid { get; }
        /// <summary>
        /// The worker_sid
        /// </summary>
        public string PathWorkerSid { get; }

        /// <summary>
        /// Construct a new ReadWorkerChannelOptions
        /// </summary>
        ///
        /// <param name="pathWorkspaceSid"> The workspace_sid </param>
        /// <param name="pathWorkerSid"> The worker_sid </param>
        public ReadWorkerChannelOptions(string pathWorkspaceSid, string pathWorkerSid)
        {
            PathWorkspaceSid = pathWorkspaceSid;
            PathWorkerSid = pathWorkerSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }

            return p;
        }
    }

    /// <summary>
    /// FetchWorkerChannelOptions
    /// </summary>
    public class FetchWorkerChannelOptions : IOptions<WorkerChannelResource> 
    {
        /// <summary>
        /// The workspace_sid
        /// </summary>
        public string PathWorkspaceSid { get; }
        /// <summary>
        /// The worker_sid
        /// </summary>
        public string PathWorkerSid { get; }
        /// <summary>
        /// The sid
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchWorkerChannelOptions
        /// </summary>
        ///
        /// <param name="pathWorkspaceSid"> The workspace_sid </param>
        /// <param name="pathWorkerSid"> The worker_sid </param>
        /// <param name="pathSid"> The sid </param>
        public FetchWorkerChannelOptions(string pathWorkspaceSid, string pathWorkerSid, string pathSid)
        {
            PathWorkspaceSid = pathWorkspaceSid;
            PathWorkerSid = pathWorkerSid;
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            return p;
        }
    }

    /// <summary>
    /// UpdateWorkerChannelOptions
    /// </summary>
    public class UpdateWorkerChannelOptions : IOptions<WorkerChannelResource> 
    {
        /// <summary>
        /// The workspace_sid
        /// </summary>
        public string PathWorkspaceSid { get; }
        /// <summary>
        /// The worker_sid
        /// </summary>
        public string PathWorkerSid { get; }
        /// <summary>
        /// The sid
        /// </summary>
        public string PathSid { get; }
        /// <summary>
        /// The capacity
        /// </summary>
        public int? Capacity { get; set; }
        /// <summary>
        /// The available
        /// </summary>
        public bool? Available { get; set; }

        /// <summary>
        /// Construct a new UpdateWorkerChannelOptions
        /// </summary>
        ///
        /// <param name="pathWorkspaceSid"> The workspace_sid </param>
        /// <param name="pathWorkerSid"> The worker_sid </param>
        /// <param name="pathSid"> The sid </param>
        public UpdateWorkerChannelOptions(string pathWorkspaceSid, string pathWorkerSid, string pathSid)
        {
            PathWorkspaceSid = pathWorkspaceSid;
            PathWorkerSid = pathWorkerSid;
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Capacity != null)
            {
                p.Add(new KeyValuePair<string, string>("Capacity", Capacity.Value.ToString()));
            }

            if (Available != null)
            {
                p.Add(new KeyValuePair<string, string>("Available", Available.Value.ToString().ToLower()));
            }

            return p;
        }
    }

}