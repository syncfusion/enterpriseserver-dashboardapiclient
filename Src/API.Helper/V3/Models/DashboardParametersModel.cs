namespace Syncfusion.Dashboard.Server.Api.Helper.V3.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;
    using System.Collections.Generic;
    using System.Net;

    public class DashboardParametersModel
    {

        [DataMember(Name = "data")]
        public List<DashboardParameterModel> Data { get; set; }
        [DataMember(Name = "showIcon")]
        public bool ShowIcon { get; set; }
        [DataMember]
        public string Message { get; set; }

        [DataMember]
        public HttpStatusCode StatusCode { get; set; }
    }

}
