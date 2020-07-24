namespace Syncfusion.Dashboard.Server.Api.Helper.V3.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;
    using System.Collections.Generic;
    using System.Net;

    public class DashboardParameterModel
    {
        [DataMember(Name = "currentUserDetail")]
        public CurrentUserType CurrentUserDetail { get; set; }
        [DataMember(Name = "data")]
        public List<DisplayValueMember> Data { get; set; }
        [DataMember(Name = "dataType")]
        public DashboardParameterDataType DataType { get; set; }
        [DataMember(Name = "defaultRange")]
        public List<string> DefaultRange { get; set; }
        [DataMember(Name = "defaultSelectedRelativeDate")]
        public string DefaultSelectedRelativeDate { get; set; }
        [DataMember(Name = "value")]
        public string DefaultValue { get; set; }
        [DataMember(Name = "valueCollection")]
        public List<string> DefaultValueCollection { get; set; }
        [DataMember(Name = "endDate")]
        public string EndDate { get; set; }
        [DataMember(Name = "id")]
        public string Id { get; set; }
        [DataMember(Name = "isCustomDateRange")]
        public bool IsCustomDateRange { get; set; }
        [DataMember(Name = "isCustomDateRangeDefaultValue")]
        public bool IsCustomDateRangeDefaultValue { get; set; }
        [DataMember(Name = "isDateRange")]
        public bool IsDateRange { get; set; }
        [DataMember(Name = "isMultiSelectionListMode")]
        public bool IsMultiSelectionListMode { get; set; }
        [DataMember(Name = "mode")]
        public ParameterMode Mode { get; set; }
        [DataMember(Name = "parameterName")]
        public string ParameterName { get; set; }
        [DataMember(Name = "relativeDateItems")]
        public string RelativeDateItems { get; set; }
        [DataMember(Name = "selectedRelativeDate")]
        public string SelectedRelativeDate { get; set; }
        [DataMember(Name = "showInParameterDialog")]
        public bool ShowInParameterDialog { get; set; }
        [DataMember(Name = "showInPromptDialog")]
        public bool ShowInPromptDialog { get; set; }
        [DataMember(Name = "startDate")]
        public string StartDate { get; set; }
        [DataMember(Name = "defaultValue")]
        public string Value { get; set; }
        [DataMember(Name = "defaultValueCollection")]
        public List<string> ValueCollection { get; set; }

        public string Message { get; set; }

        [DataMember]
        public HttpStatusCode StatusCode { get; set; }
    }

}
