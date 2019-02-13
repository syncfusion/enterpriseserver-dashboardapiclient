using System;
using System.Net;
using System.Runtime.Serialization;

namespace Syncfusion.Dashboard.Server.Api.Helper.V4.Models
{
    /// <summary>
    /// Details of Shared DataSources.
    /// </summary>
    public class ApiSharedDataSourceResponse
    {
        /// <summary>
        /// Datasource name.
        /// </summary>
        public string DataSourceName
        {
            get;
            set;
        }

        /// <summary>
        /// Datasource location.
        /// </summary>
        public string DataSourcePath
        {
            get;
            set;
        }

        /// <summary>
        /// Datasource Id.
        /// </summary>
        public Guid DataSourceId
        {
            get;
            set;
        }

        /// <summary>
        /// Assign true to Unlist Dashboard
        /// </summary>
        [DataMember]
        public bool IsEmbeded
        {
            get;
            set;
        }

        /// <summary>
        /// Can Read the Datasource
        /// </summary>
        [DataMember]
        public bool CanRead
        {
            get;
            set;
        }

        /// <summary>
        /// Can Write the Datasource
        /// </summary>
        [DataMember]
        public bool CanWrite
        {
            get;
            set;
        }

        /// <summary>
        /// Can Delete the Datasource
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
