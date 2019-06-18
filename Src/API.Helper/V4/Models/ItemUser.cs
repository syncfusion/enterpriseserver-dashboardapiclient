namespace Syncfusion.Dashboard.Server.Api.Helper.V4.Models
{
    using System;
    using System.Net;
    using System.Runtime.Serialization;

    /// <summary>
    /// Item Created details.
    /// </summary>
    [Serializable]
    [DataContract]
    public class ItemUser
    {
        /// <summary>
        /// Item created by an ID.
        /// </summary>
        [DataMember]
        public int Id
        {
            get;
            set;
        }

        /// <summary>
        /// Item created by an Name.
        /// </summary>
        [DataMember]
        public string Name
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
