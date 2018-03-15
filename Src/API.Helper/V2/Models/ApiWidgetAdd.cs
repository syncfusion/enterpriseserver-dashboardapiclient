namespace Syncfusion.Dashboard.Server.Api.Helper.V2.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;
    using System.ComponentModel.DataAnnotations;
    using System.Text;
    using System.Threading.Tasks;
    using System.Net;

    /// <summary>
    /// Widget details.
    /// </summary>
    [Serializable]
    [DataContract]
    public class ApiWidgetAdd
    {
        /// <summary>
        /// Widget name.
        /// </summary>
        [DataMember]
        [Required]
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// Widget description.
        /// </summary>
        [DataMember]
        public string Description
        {
            get;
            set;
        }

        /// <summary>
        /// Specify true to set the item as a public.
        /// </summary>
        [DataMember]
        public bool IsPublic
        {
            get;
            set;
        }

        /// <summary>
        /// Provide items in an array of bytes.
        /// </summary>
        [DataMember]
        [Required]
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
