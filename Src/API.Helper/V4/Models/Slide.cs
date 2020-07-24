namespace Syncfusion.Dashboard.Server.Api.Helper.V4.Models
{
    using System.Net;
    using System.Runtime.Serialization;
    /// <summary>
    /// Slideshow details.
    /// </summary>
    public class Slide
    {
        /// <summary>
        /// Slideshow OrderNumber.
        /// </summary>
        public int OrderNumber
        {
            get;
            set;
        }

        /// <summary>
        /// Item type.
        /// </summary>
        public ItemTypeV4 ItemType
        {
            get;
            set;
        }

        /// <summary>
        /// Slideshow information.
        /// </summary>
        public SlideInfo ItemInfo
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