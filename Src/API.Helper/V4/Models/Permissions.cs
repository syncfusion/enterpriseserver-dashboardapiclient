namespace Syncfusion.Dashboard.Server.Api.Helper.V4.Models
{
    using System;
    using System.Net;
    using System.Runtime.Serialization;

    /// <summary>
    /// Permission details.
    /// </summary>
    [Serializable]
    [DataContract]
    public class Permissions
    {
        /// <summary>
        /// Specifies the read permission of the slideshow.
        /// </summary>
        [DataMember]
        public bool CanRead
        {
            get;
            set;
        }

        /// <summary>
        /// Specifies the write permission of the slideshow.
        /// </summary>
        [DataMember]
        public bool CanWrite
        {
            get;
            set;
        }

        /// <summary>
        /// Specifies the delete permission of the slideshow.
        /// </summary>
        [DataMember]
        public bool CanDelete
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
