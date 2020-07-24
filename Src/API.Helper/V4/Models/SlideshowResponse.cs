namespace Syncfusion.Dashboard.Server.Api.Helper.V4.Models
{
    using System;
    using System.Net;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    using Newtonsoft.Json;

    /// <summary>
    /// Slideshow details.
    /// </summary>
    [Serializable]
    [DataContract]
    public class SlideshowResponse
    {
        /// <summary>
        /// Id of an slideshow.
        /// </summary>
        [DataMember]
        public Guid Id
        {
            get;
            set;
        }

        /// <summary>
        /// Name of an slideshow.
        /// </summary>
        [DataMember]
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// Duration of an slideshow.
        /// </summary>
        [DataMember]
        public int Duration
        {
            get;
            set;
        }

        /// <summary>
        /// Created By details.
        /// </summary>
        [DataMember]
        public ItemUser CreatedBy
        {
            get;
            set;
        }

        /// <summary>
        /// Modified By details.
        /// </summary>
        [DataMember]
        public ItemUser ModifiedBy
        {
            get;
            set;
        }

        /// <summary>
        /// Slideshow created date.
        /// </summary>
        [DataMember]
        public string CreatedDate
        {
            get;
            set;
        }

        /// <summary>
        /// Slideshow modified date.
        /// </summary>
        [DataMember]
        public string ModifiedDate
        {
            get;
            set;
        }

        /// <summary>
        /// Slides information.
        /// </summary>
        [DataMember]
        public List<Slide> Slides
        {
            get;
            set;
        }

        /// <summary>
        /// Permissions for the slideshow.
        /// </summary>
        [DataMember]
        [JsonProperty("Permissions")]
        public Permissions Permissions
        {
            get;
            set;
        }

        /// <summary>
        /// Active status of the slideshow.
        /// </summary>
        [DataMember]
        public bool IsActive
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
