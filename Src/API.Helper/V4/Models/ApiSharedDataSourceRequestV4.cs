namespace Syncfusion.Dashboard.Server.Api.Helper.V4.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Net;
    using System.Runtime.Serialization;

    /// <summary>
    /// Details about the dashboard passed to get their shared data sources.
    /// </summary>
    [Serializable]
    [DataContract]
    public class ApiSharedDataSourceRequestV4
    {
        /// <summary>
        /// User ID.
        /// </summary>
        [Required]
        [DataMember]
        public int UserId
        {
            get;
            set;
        }

        /// <summary>
        /// Dashboard ID.
        /// </summary>
        [Required]
        [DataMember]
        public Guid DashboardId
        {
            get;
            set;
        }

        /// <summary>
        /// Dashboard location.
        /// </summary>
        [DataMember]
        public string DashboardPath
        {
            get;
            set;
        }
        [DataMember]
        public string Message { get; set; }

        [DataMember]
        public HttpStatusCode StatusCode { get; set; }
    }
}
