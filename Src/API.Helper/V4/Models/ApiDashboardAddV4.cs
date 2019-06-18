namespace Syncfusion.Dashboard.Server.Api.Helper.V4.Models
{
    using System;
    using System.Net;
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;

    /// <summary>
    /// Dashboard details.
    /// </summary>
    [Serializable]
    [DataContract]
    public class ApiDashboardAddV4
    {
        /// <summary>
        /// Dashboard name.
        /// </summary>
        [DataMember]
        [Required]
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// Dashboard description.
        /// </summary>
        [DataMember]
        public string Description
        {
            get;
            set;
        }

        /// <summary>
        /// Category ID.
        /// </summary>
        [DataMember]
        [Required]
        public Guid CategoryId
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

        /// <summary>
        /// Assign true to Unlist Dashboard
        /// </summary>
        [DataMember]
        public bool IsUnlisted
        {
            get;
            set;
        }

        /// <summary>
        /// Assign true to IsWebDesignerCompatible Dashboard
        /// </summary>
        [DataMember]
        public bool? IsWebDesignerCompatible
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
