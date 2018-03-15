namespace Syncfusion.Dashboard.Server.Api.Helper.V2.Models
{
    using System;
    using System.Net;
    using System.Runtime.Serialization;

    /// <summary>
    /// Details of favorite items.
    /// </summary>
    [Serializable]
    [DataContract]
    public class ApiFavoriteitems
    {
        /// <summary>
        /// Dashboard ID.
        /// </summary>
        [DataMember]
        public Guid DashboardId { get; set; }

        /// <summary>
        /// Dashboard name.
        /// </summary>
        [DataMember]
        public string Name { get; set; }

        /// <summary>
        /// Dashboard description.
        /// </summary>
        [DataMember]
        public string Description { get; set; }

        /// <summary>
        /// Category ID.
        /// </summary>
        [DataMember]
        public Guid? CategoryId { get; set; }

        /// <summary>
        /// Category name.
        /// </summary>
        [DataMember]
        public string CategoryName { get; set; }

        /// <summary>
        /// Category description.
        /// </summary>
        [DataMember]
        public string CategoryDescription { get; set; }

        /// <summary>
        /// Specifies the user ID of the item creator.
        /// </summary>
        [DataMember]
        public int CreatedById { get; set; }

        /// <summary>
        /// Specifies the display name of the user who created the item.
        /// </summary>
        [DataMember]
        public string CreatedByDisplayName { get; set; }

        /// <summary>
        /// Specifies the user ID of the item modifier.
        /// </summary>
        [DataMember]
        public int ModifiedById { get; set; }

        /// <summary>
        /// Specifies the full name of the user who modified the item.
        /// </summary>
        [DataMember]
        public string ModifiedByFullName { get; set; }

        /// <summary>
        /// Date created of item in string format.
        /// </summary>
        [DataMember]
        public string CreatedDate { get; set; }

        /// <summary>
        /// Date modified of item in string format.
        /// </summary>
        [DataMember]
        public string ModifiedDate { get; set; }

        /// <summary>
        /// Date created of item in date format.
        /// </summary>
        [DataMember]
        public DateTime ItemCreatedDate { get; set; }

        /// <summary>
        /// Date modified of item in date format.
        /// </summary>
        [DataMember]
        public DateTime ItemModifiedDate { get; set; }

        /// <summary>
        /// Returns true if the dashboard is a multi-tabbed dashboard.
        /// </summary>
        [DataMember]
        public bool IsMultiTabbedDashboard { get; set; }

        /// <summary>
        /// Returns true if the item is public.
        /// </summary>
        [DataMember]
        public bool IsPublic { get; set; }

        [DataMember]
        public string Message { get; set; }

        [DataMember]
        public HttpStatusCode StatusCode { get; set; }
    }
}
