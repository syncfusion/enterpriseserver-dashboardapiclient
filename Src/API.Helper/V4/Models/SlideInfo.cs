namespace Syncfusion.Dashboard.Server.Api.Helper.V4.Models
{
    using System;
    using System.Net;
    using System.Runtime.Serialization;

    /// <summary>
    /// Slideshow information.
    /// </summary>
    public class SlideInfo
    {
        /// <summary>
        /// Id of Slideshow.
        /// </summary>
        public Guid Id
        {
            get;
            set;
        }

        /// <summary>
        /// Name of the Slideshow.
        /// </summary>
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// Category Id.
        /// </summary>
        public Guid? CategoryId
        {
            get;
            set;
        }

        /// <summary>
        /// Category Name.
        /// </summary>
        public string CategoryName
        {
            get;
            set;
        }

        /// <summary>
        /// Tab Id.
        /// </summary>
        public Guid? TabId
        {
            get;
            set;
        }

        /// <summary>
        /// Tab Name.
        /// </summary>
        public string TabName
        {
            get;
            set;
        }

        /// <summary>
        /// Id of the View.
        /// </summary>
        public Guid? ViewId
        {
            get;
            set;
        }

        /// <summary>
        /// Name of the View.
        /// </summary>
        public string ViewName
        {
            get;
            set;
        }

        /// <summary>
        /// Returns true if the dashboard is multi-dashboard.
        /// </summary>
        public bool IsMultiDashboard
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