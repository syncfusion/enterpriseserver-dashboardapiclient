using Newtonsoft.Json;
using Syncfusion.Dashboard.Server.Api.Helper.Authentication;
using Syncfusion.Dashboard.Server.Api.Helper.V3.Models;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace Syncfusion.Dashboard.Server.API.Helper.V3.EndPoints
{
    public class ItemsEndPoint2
    {
        private readonly ServerClientV3 _serverClientV3;
        private readonly string _baseUrl;

        public ItemsEndPoint2(ServerClientV3 serverClientV3)
        {
            _serverClientV3 = serverClientV3;
            _baseUrl = _serverClientV3.BaseUrl;
        }

        /// <summary>
        /// This method is used to add new file into the dashboard server.
        /// </summary>
        /// <param name="apiFileAdd">File details (File name, File description, Extension and ItemContent) to be added.</param>
        /// <returns>Status of adding file to the Server</returns>

        public ApiItemResponse AddFile(ApiFileAdd apiFileAdd)
        {
            var result = _serverClientV3.Post(apiFileAdd, _baseUrl + "/files");
            var response = new ApiItemResponse();
            if (result != null)
            {
                return JsonConvert.DeserializeObject<ApiItemResponse>(result.Content);
            }
            else
            {
                return response;
            }
        }

        /// <summary>
        /// This method is used to update the existing file into the dashboard server.
        /// </summary>
        /// <param name="apiFileAdd">Item type (category, dashboard, datasource, widget and schedule)</param>
        /// <param name="serverPath">Category path</param>
        /// <returns>List of items for the itemtype.</returns>

        public ApiItemResponse UpdateFile(ApiFileUpdate apiFileAdd)
        {
            var result = _serverClientV3.Put(apiFileAdd, _baseUrl + "/files");
            var response = new ApiItemResponse();
            if (result != null)
            {
                return JsonConvert.DeserializeObject<ApiItemResponse>(result.Content);
            }
            else
            {
                return response;
            }
        }

        /// <summary>
        /// Returns list of dashboard parameter for the dashboard
        /// </summary>
        /// <remarks>
        /// Server retrieves the list of parameters for the dashboard provided in query parameter itemRequest for the current user.
        /// </remarks>
        /// <param name="itemRequest">Item Request.</param>
        /// <returns>It returns list of dashboard parameter for the dashboard</returns>

        public DashboardParameterModel GetDashboardParameter(ItemRequest itemRequest)
        {
            var requestUrl = _baseUrl + "/dashboards/parameters";
            var result = _serverClientV3.Post(itemRequest, requestUrl);
            if (result != null)
            {
                return JsonConvert.DeserializeObject<DashboardParameterModel>(result.Content);
            }
            else
            {
                return new DashboardParameterModel();                
            }
        }
    }
}