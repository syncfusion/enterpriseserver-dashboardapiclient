namespace Syncfusion.Dashboard.Server.Api.Helper.V2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Net;
    using System.Runtime.Serialization;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Widget details.
    /// </summary>
    [Serializable]
    [DataContract]
    public class ApiWidgetUpdate
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
        [DataMember]
        public string Message { get; set; }

        [DataMember]
        public HttpStatusCode StatusCode { get; set; }
    }
}
