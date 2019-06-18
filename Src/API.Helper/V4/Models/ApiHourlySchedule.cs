namespace Syncfusion.Dashboard.Server.Api.Helper.V4.Models
{
    using System;
    using System.Net;
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;

    /// <summary>
    /// Runs the schedules on an hourly basis.
    /// </summary>
    [DataContract]
    [Serializable]
    public class ApiHourlySchedule
    {
        /// <summary>
        /// Specifies the hour interval. Based on this interval the schedule will run continuously until the end time. The format should be `HH:mm`.
        /// </summary>
        [DataMember]
        [Required]
        public string ScheduleInterval { get; set; }

        [DataMember]
        public string Message { get; set; }

        [DataMember]
        public HttpStatusCode StatusCode { get; set; }
    }
}
