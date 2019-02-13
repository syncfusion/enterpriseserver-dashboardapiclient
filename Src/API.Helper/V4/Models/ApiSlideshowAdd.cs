namespace Syncfusion.Dashboard.Server.Api.Helper.V4.Models
{
    using System;
    using System.Net;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;

    /// <summary>
    /// Slideshow details.
    /// </summary>
    [Serializable]
    [DataContract]
    public class ApiSlideshowAdd
    {
        /// <summary>
        /// Slideshow name.
        /// </summary>
        [DataMember]
        [Required]
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// Time interval between slides.
        /// </summary>
        [DataMember]
        [Required]
        public int Duration
        {
            get;
            set;
        }

        /// <summary>
        /// Slides list.
        /// </summary>
        [DataMember]
        [Required]
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