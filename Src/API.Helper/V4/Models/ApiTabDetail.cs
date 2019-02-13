namespace Syncfusion.Dashboard.Server.Api.Helper.V4.Models
{
    using System;
    using System.Net;
    using System.Runtime.Serialization;

    /// <summary>
    /// Specifies the details of the tab in a multi-tabbed dashboard
    /// </summary>
    [Serializable]
    [DataContract]
    public class ApiTabDetail
    {
        /// <summary>
        /// Specifies the dashboard ID of the multi-tabbed dashboard.
        /// </summary>
        [DataMember]
        public Guid? MultiTabDashboardId { get; set; }

        /// <summary>
        /// Specifies the dashboard ID of the tab.
        /// </summary>
        [DataMember]
        public Guid DashboardId { get; set; }

        /// <summary>
        /// Specifies the name of the tab.
        /// </summary>
        [DataMember]
        public string Name { get; set; }

        /// <summary>
        /// Date created of item in string format
        /// </summary>
        [DataMember]
        public string CreatedDate { get; set; }

        /// <summary>
        /// Date modified of item in string format
        /// </summary>
        [DataMember]
        public string ModifiedDate { get; set; }

        [DataMember]
        public string Message { get; set; }

        [DataMember]
        public HttpStatusCode StatusCode { get; set; }
    }
}
