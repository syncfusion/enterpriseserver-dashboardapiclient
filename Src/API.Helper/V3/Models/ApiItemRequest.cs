namespace Syncfusion.Dashboard.Server.Api.Helper.V3.Models
{
    using System;
    using System.Collections.Generic;
    using Syncfusion.Dashboard.Server.Api.Helper.V2.Models;
    using Syncfusion.Dashboard.Server.Api.Helper.V4.Models;

    public class ItemRequest : ApiRequest
    {
        public string AjaxData
        {
            get;
            set;
        }

        public Guid? CategoryId
        {
            get;
            set;
        }

        public Guid ChildItemId
        {
            get;
            set;
        }

        public string Color
        {
            get;
            set;
        }

        public List<DataSetMappingInfo> DataSetMappingInfo
        {
            get;
            set;
        }

        public DataSourceDefinition DataSourceDefinition
        {
            get;
            set;
        }

        public DataSourceMappingInfo DataSourceDetails
        {
            get;
            set;
        }

        public List<DataSourceMappingInfo> DataSourceMappingInfo
        {
            get;
            set;
        }

        public string Description
        {
            get;
            set;
        }

        public ExportType ExportTypeId
        {
            get;
            set;
        }

        public bool FavoriteValue
        {
            get;
            set;
        }

        public int GroupId
        {
            get;
            set;
        }

        public List<int> GroupPermissionList
        {
            get;
            set;
        }

        public bool IsMultiDashboard
        {
            get;
            set;
        }

        public bool IsPublic
        {
            get;
            set;
        }

        public byte[] ItemContent
        {
            get;
            set;
        }

        public Guid ItemId
        {
            get;
            set;
        }

        public ItemType ItemType
        {
            get;
            set;
        }

        // Dashboard Filter API properties
        public Guid ItemViewId
        {
            get;
            set;
        }

        public string ItemViewName
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        public int PermissionId
        {
            get;
            set;
        }

        public string QueryString
        {
            get;
            set;
        }

        public Guid ReportId
        {
            get;
            set;
        }

        public string ReportName
        {
            get;
            set;
        }

        public string ServerPath
        {
            get;
            set;
        }

        public string UploadedReportName
        {
            get;
            set;
        }

        public int UserId
        {
            get;
            set;
        }

        public List<int> UserPermissionList
        {
            get;
            set;
        }

        public string VersionComment
        {
            get;
            set;
        }

        public int VersionId
        {
            get;
            set;
        }

        public string CategoryName
        {
            get;
            set;
        }

        public Guid DatasourceId
        {
            get;
            set;
        }

        public List<string> DatasourceIds
        {
            get;
            set;
        }

        public string PrefixForLookupTable
        {
            get;
            set;
        }
    }
}