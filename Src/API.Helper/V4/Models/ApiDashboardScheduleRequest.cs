﻿namespace Syncfusion.Dashboard.Server.Api.Helper.V4.Models
{
    using System;
    using System.Net;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;

    /// <summary>
    /// Details about the schedule passed will be added to the server.
    /// </summary>
    [Serializable]
    [DataContract]
    public class ApiDashboardScheduleRequest
    {
        /// <summary>
        /// Schedule name.
        /// </summary>
        [DataMember]
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Specifies the export type to schedule the report. Valid values: `Excel` `Html` `Pdf` `Word` `PPT` `CSV`.
        /// </summary>
        [DataMember]
        [Required]
        public string ExportType { get; set; }

        /// <summary>
        /// Specifies the UTC start date-time of schedule. The format should be ISO 8601 i.e. `yyyy-mm-ddTHH:mm:ssZ`.
        /// </summary>
        [DataMember]
        [Required]
        public string StartTime { get; set; }

        /// <summary>
        /// Sets the schedule with no end when specified as true. \n\n Note: By default, the NeverEnd is set to true. To set the end time for the schedule, fill the properties of either EndAfterOccurrence or EndDate; otherwise remains empty.
        /// </summary>
        [DataMember]
        public bool NeverEnd { get; set; }

        /// <summary>
        /// Specifies the number of occurrences after which the schedule will be completed. \n\n For example: If you provide 5, the schedule will end after the completion of 5 occurrences.
        /// </summary>
        [DataMember]
        public int EndAfterOccurrence { get; set; }

        /// <summary>
        /// Specifies the UTC end date-time of schedule after which schedule will be completed. The format should be ISO 8601 i.e. `yyyy-mm-ddTHH:mm:ssZ`. \n\n For example: If you provide the end date-time, the schedule will end once the end date-time is reached.
        /// </summary>
        [DataMember]
        public string EndDate { get; set; }

        /// <summary>
        /// Provides the list of username, email, or user IDs to the recipients who will get the schedules.
        /// </summary>
        [DataMember]
        public List<string> UserList { get; set; }

        /// <summary>
        /// Provides the list of group IDs to the recipients in the group list who will get the schedules.
        /// </summary>
        [DataMember]
        public List<int> GroupList { get; set; }

        /// <summary>
        /// Provides the list of email IDs to the email recipients who will get the schedules. 
        /// </summary>
        [DataMember]
        public List<string> ExternalRecipientsList { get; set; }

        /// <summary>
        /// Specifies the schedule type to schedule the report. Valid values: `Hourly` `Daily` `Weekly` `Monthly` `Yearly`. \n\n Note: If you chose the schedule type as `Monthly`, provide a values to the MonthlySchedule property, and leave the (HourlySchedule, DailySchedule, WeeklySchedule and YearlySchedule) property empty.
        /// </summary>
        [DataMember]
        [Required]
        public string ScheduleType { get; set; }

        /// <summary>
        /// Runs the schedules on an hourly basis.
        /// </summary>
        [DataMember]
        public ApiHourlySchedule HourlySchedule { get; set; }

        /// <summary>
        /// Runs the schedules on a daily basis. 
        /// </summary>
        [DataMember]
        public ApiDailySchedule DailySchedule { get; set; }

        /// <summary>
        /// Runs the schedule on a weekly basis.
        /// </summary>
        [DataMember]
        public ApiWeeklySchedule WeeklySchedule { get; set; }

        /// <summary>
        /// Runs the schedule on a monthly basis.
        /// </summary>
        [DataMember]
        public ApiMonthlySchedule MonthlySchedule { get; set; }

        /// <summary>
        /// Runs the schedules on a yearly basis.
        /// </summary>
        [DataMember]
        public ApiYearlySchedule YearlySchedule { get; set; }

        /// <summary>
        /// Item ID.
        /// </summary>
        [DataMember]
        [Required]
        public Guid ItemId { get; set; }

        /// <summary>
        /// Type of the Item
        /// </summary>
        [DataMember]
        public string ItemType { get; set; }

        [DataMember]
        public string Message { get; set; }

        [DataMember]
        public HttpStatusCode StatusCode { get; set; }
    }
}
