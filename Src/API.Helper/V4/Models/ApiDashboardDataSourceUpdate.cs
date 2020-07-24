namespace Syncfusion.Dashboard.Server.Api.Helper.V4.Models
{
    using System;
    using System.Net;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    public class ApiDashboardDataSourceUpdate
    {
        /// <summary>
        /// Dashboard Id
        /// </summary>
        public Guid DashboardId
        {
            get;
            set;
        }

        /// <summary>
        /// Datasource Details
        /// </summary>
        public List<DataSourceMappingInfo> DataSourceDetails
        {
            get;
            set;
        }

        public int? GroupId
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
