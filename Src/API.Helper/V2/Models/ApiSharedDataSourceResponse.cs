using System.Net;
using System.Runtime.Serialization;

namespace Syncfusion.Dashboard.Server.Api.Helper.V2.Models
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
        [DataMember]
        public string Message { get; set; }

        [DataMember]
        public HttpStatusCode StatusCode { get; set; }
    }
}
