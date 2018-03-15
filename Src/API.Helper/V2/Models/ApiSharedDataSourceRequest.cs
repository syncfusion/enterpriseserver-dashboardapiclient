namespace Syncfusion.Dashboard.Server.Api.Helper.V2.Models
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
    public class ApiSharedDataSourceRequest
    {
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
