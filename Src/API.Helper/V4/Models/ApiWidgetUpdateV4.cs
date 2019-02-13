namespace Syncfusion.Dashboard.Server.Api.Helper.V4.Models
{
    using System;
    using System.Net;
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;

    /// <summary>
    /// Widget details.
    /// </summary>
    [Serializable]
    [DataContract]
    public class ApiWidgetUpdateV4
    {
        /// <summary>
        /// Widget ID.
        /// </summary>
        [DataMember]
        [Required]
        public Guid WidgetId
        {
            get;
            set;
        }

        /// <summary>
        /// Widget name.
        /// </summary>
        [DataMember]
        public string Name { get; set; }

        /// <summary>
        /// Widget description.
        /// </summary>
        [DataMember]
        public string Description { get; set; }

        /// <summary>
        /// Specify true to set item as public.
        /// </summary>
        [DataMember]
        public bool IsPublic
        {
            get;
            set;
        }

        /// <summary>
        /// Comments about update.
        /// </summary>
        [DataMember]
        public string VersionComment
        {
            get;
            set;
        }

        /// <summary>
        /// Provide items in an array of bytes.
        /// </summary>
        [DataMember]
        public byte[] ItemContent
        {
            get;
            set;
        }

        /// <summary>
        /// Assign true to Unlist Widget
        /// </summary>
        [DataMember]
        public bool IsUnlisted
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
