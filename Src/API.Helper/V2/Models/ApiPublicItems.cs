namespace Syncfusion.Dashboard.Server.Api.Helper.V2.Models
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Runtime.Serialization;

    /// <summary>
    /// Details of public items.
    /// </summary>
    [Serializable]
    [DataContract]
    public class ApiPublicItems
    {
        /// <summary>
        /// Item ID.
        /// </summary>
        [DataMember]
        public Guid Id { get; set; }

        /// <summary>
        /// Item type.
        /// </summary>
        [DataMember]
        public string ItemType { get; set; }

        /// <summary>
        /// Item name.
        /// </summary>
        [DataMember]
        public string Name { get; set; }

        /// <summary>
        /// Item description.
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
        /// Category discription.
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
        /// Specifies the details of the tab in a multi-tabbed dashboard.
        /// </summary>
        [DataMember]
        public List<ApiTabDetail> TabDetail { get; set; }

        /// <summary>
        /// Returns true if it is a favorite item.
        /// </summary>
        [DataMember]
        public bool IsFavorite { get; set; }

        [DataMember]
        public string Message { get; set; }

        [DataMember]
        public HttpStatusCode StatusCode { get; set; }
    }
}
