namespace Syncfusion.Dashboard.Server.Api.Helper.V4.Models
{
    using System;
    using System.Net;
    using System.Runtime.Serialization;

    /// <summary>
    /// Mapping information of datasource
    /// </summary>
    public class DataSourceMappingInfo
    {
        /// <summary>
        /// Datasource ID
        /// </summary>
        public Guid DataSourceId
        {
            get;
            set;
        }

        /// <summary>
        /// Datasource name
        /// </summary>
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