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
    /// Datasource details.
    /// </summary>
    [Serializable]
    [DataContract]
    public class ApiDataSourceUpdate
    {
        /// <summary>
        /// Datasource ID.
        /// </summary>
        [DataMember]
        [Required]
        public Guid DataSourceId
        {
            get;
            set;
        }

        /// <summary>
        /// Datasource name.
        /// </summary>
        [DataMember]
        public string Name { get; set; }

        /// <summary>
        /// Datasource description.
        /// </summary>
        [DataMember]
        public string Description { get; set; }

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
