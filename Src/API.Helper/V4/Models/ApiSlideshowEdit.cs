namespace Syncfusion.Dashboard.Server.Api.Helper.V4.Models
{
    using System;
    using System.Net;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    /// <summary>
    /// Edit slideshow details.
    /// </summary>
    [Serializable]
    [DataContract]
    public class ApiSlideshowEdit
    {
        /// <summary>
        /// Slideshow name.
        /// </summary>
        [DataMember]
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// Time interval between slides.
        /// </summary>
        [DataMember]
        public int Duration
        {
            get;
            set;
        }

        /// <summary>
        /// Slides list.
        /// </summary>
        [DataMember]
        public List<Slide> Slides
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