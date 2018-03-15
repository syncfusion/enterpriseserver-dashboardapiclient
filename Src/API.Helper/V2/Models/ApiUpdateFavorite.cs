namespace Syncfusion.Dashboard.Server.Api.Helper.V2.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Net;
    using System.Runtime.Serialization;

    /// <summary>
    /// Details about the favorite item.
    /// </summary>
    [Serializable]
    [DataContract]
    public class ApiUpdateFavorite
    {
        /// <summary>
        /// Dashboard ID.
        /// </summary>
        [DataMember]
        [Required]
        public Guid DashboardId { get; set; }

        /// <summary>
        /// Specify true to set the item as a favorite item.
        /// </summary>
        [DataMember]
        [Required]
        public bool Favorite { get; set; }

        [DataMember]
        public string Message { get; set; }

        [DataMember]
        public HttpStatusCode StatusCode { get; set; }
    }
}
