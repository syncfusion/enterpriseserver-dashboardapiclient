﻿namespace Syncfusion.Dashboard.Server.Api.Helper.V4.Models
{
    using System;
    using System.Net;
    using System.Runtime.Serialization;

    /// <summary>
    /// Response Details of schedules created.
    /// </summary>
    [Serializable]
    [DataContract]
    public class ApiScheduleResponse
    {
        /// <summary>
        /// Returns schedule name.
        /// </summary>
        [DataMember]
        public string ScheduleName { get; set; }

        /// <summary>
        /// Returns schedule ID.
        /// </summary>
        [DataMember]
        public Guid ScheduleId { get; set; }

        /// <summary>
        /// Returns the status message from the API.
        /// </summary>
        [DataMember]
        public string StatusMessage { get; set; }

        /// <summary>
        /// Returns the schedule type.
        /// </summary>
        [DataMember]
        public string ScheduleType { get; set; }

        /// <summary>
        /// Returns the schedule’s next run.
        /// </summary>
        [DataMember]
        public string NextRun { get; set; }

        [DataMember]
        public string Message { get; set; }

        [DataMember]
        public HttpStatusCode StatusCode { get; set; }
    }
}
