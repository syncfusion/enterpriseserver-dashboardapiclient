using Newtonsoft.Json;
using Syncfusion.Dashboard.Server.Api.Helper.Authentication;
using Syncfusion.Dashboard.Server.Api.Helper.V4.Models;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace Syncfusion.Dashboard.Server.API.Helper.V4.EndPoints
{
    public class ItemsEndPoint3
    {
        private readonly ServerClientV4 _serverClientV4;
        private readonly string _baseUrl;

        public ItemsEndPoint3(ServerClientV4 serverClientV4)
        {
            _serverClientV4 = serverClientV4;
            _baseUrl = _serverClientV4.BaseUrl;
        }

        /// <summary>
        /// This method returns list of items for the itemtype category, dashboard, datasource, widget and file.
        /// </summary>
        /// <param name="itemType">Item type (category, dashboard, datasource, widget and file.)</param>
        /// <param name="serverPath">Category path</param>
        /// <returns>List of items for the itemtype.</returns>

        public List<ApiItemsV4> GetItems([FromUri] ItemTypeV4 itemType, [FromUri] string serverPath = null)
        {
            var requestUrl = _baseUrl + "/items";
            var items = new List<ApiItemsV4>();
            var param = new Dictionary<string, object>();
            param.Add("itemtype", itemType);
            var result = _serverClientV4.Get(items, requestUrl, param);
            if (result != null)
            {
                return JsonConvert.DeserializeObject<List<ApiItemsV4>>(result.Content);
            }
            else
            {
                return items;
            }
        }

        /// <summary>
        /// This method returns item details for the values Category Id, Dashboard Id, Datasource Id and Widget Id.
        /// </summary>
        /// <param name="id">The id values may be Category Id, Dashboard Id, Datasource Id and Widget Id.</param>
        /// <returns>Item details for the values.</returns>

        public ApiSpecifiedItemDetailV4 GetItemDetail(Guid id)
        {
            var overrideUrl = _baseUrl + "/items/" + id;
            var itemDetail = new ApiSpecifiedItemDetailV4();
            var result = _serverClientV4.Get(itemDetail, overrideUrl);
            if (result != null)
            {
                return JsonConvert.DeserializeObject<ApiSpecifiedItemDetailV4>(result.Content);
            }
            else
            {
                return itemDetail;
            }
        }

        /// <summary>
        /// This method returns shared datasources of a specific dashboard.
        /// </summary>
        /// <param name="apiSharedDataSourceRequest">Details(User id, Dashboard id, dashboard path) about the dashboard to get their shared data sources.</param>
        /// <returns>Shared datasources of a specific dashboard.</returns>

        public List<ApiSharedDataSourceResponse> GetSharedDataSources(
            ApiSharedDataSourceRequestV4 apiSharedDataSourceRequest)
        {
            var requestUrl = _baseUrl + "/dashboards/shared-datasources";
            var datasource = new List<ApiSharedDataSourceResponse>();
            var result = _serverClientV4.Post(apiSharedDataSourceRequest, requestUrl);
            if (result != null)
            {
                return JsonConvert.DeserializeObject<List<ApiSharedDataSourceResponse>>(result.Content);
            }
            else
            {
                return datasource;
            }
        }

        /// <summary>
        /// Returns list of slideshows from the server
        /// </summary>
        /// <remarks>
        /// Server retrieves all the slideshows for the current user.
        /// </remarks>
        /// <returns>The response is sent as ApiResponse object</returns>

        public List<SlideshowResponse> GetSlideshows()
        {
            var requestUrl = _baseUrl + "/slideshow";
            var slideshows = new List<SlideshowResponse>();
            var result = _serverClientV4.Get(slideshows, requestUrl);
            if (result != null)
            {
                return JsonConvert.DeserializeObject<List<SlideshowResponse>>(result.Content);
            }
            else
            {
                return slideshows;
            }
        }

        /// <summary>
        /// Returns slideshow details from the server for a specified slideshow
        /// </summary>
        /// <remarks>
        /// Server retrieves the respective item details for the slideshow id provided in id parameter for the current user.
        /// </remarks>
        /// <param name="id">Slideshow ID</param>
        /// <returns>The response is sent as ApiResponse object</returns>
        
        public SlideshowResponse GetSlideshowDetail(Guid id)
        {
            var requestUrl = _baseUrl + "/slideshow/" + id;
            var slideshow = new SlideshowResponse();
            var result = _serverClientV4.Get(slideshow, requestUrl);
            if (result != null)
            {
                return JsonConvert.DeserializeObject<SlideshowResponse>(result.Content);
            }
            else
            {
                return slideshow;
            }
        }

        /// <summary>
        /// This method is used to add new dashboard to the server.
        /// </summary>
        /// <param name="apiDashboardAdd">Dashboard details (Dashboard name, Dashboard description, IsPublic, Item in an array of bytes) to be added.</param>
        /// <returns>Status of adding dashboard to the server.</returns>

        public ApiItemResponse AddDashboard(ApiDashboardAddV4 apiDashboardAdd)
        {
            var result = _serverClientV4.Post(apiDashboardAdd, _baseUrl + "/dashboards");
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
        ///  This method is used to add new widget to the server.
        /// </summary>
        /// <param name="apiWidgetAdd">Widget details(Widget name, widget description, IsPublic, items in an array of bytes) to be added.</param>
        /// <returns>Status of adding widget to the server.</returns>

        public ApiItemResponse AddWidget(ApiWidgetAddV4 apiWidgetAdd)
        {
            var result = _serverClientV4.Post(apiWidgetAdd, _baseUrl + "/dashboards/widgets");
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
        /// Add a new slideshow to the server
        /// </summary>
        /// <remarks>
        /// Users who have a create access for slideshow, can add a new slideshow to the server by providing respective slideshow details in the request body.
        /// </remarks>
        /// <param name="apiSlideshowAdd">Details about the slideshow passed will be added to the server.</param>
        /// <returns>The response is sent as ApiResponse object</returns>

        public ApiItemResponse AddSlideshow(ApiSlideshowAdd apiSlideshowAdd)
        {
            var result = _serverClientV4.Post(apiSlideshowAdd, _baseUrl + "/slideshow");
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
        /// This method is used to update the existing dashboard on the server.
        /// </summary>
        /// <param name="apiDashboardUpdate">Dashboard details (Dashboard name, Dashboard description, IsPublic, Item in an array of bytes) to be updated.</param>
        /// <returns>Status of updating the dashboard on the server.</returns>

        public ApiItemResponse UpdateDashboard(ApiDashboardUpdateV4 apiDashboardUpdate)
        {
            var requestUrl = _baseUrl + "/dashboards";
            var result = _serverClientV4.Put(apiDashboardUpdate, requestUrl);
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
        /// This method is used to update the existing widget on the server.
        /// </summary>
        /// <param name="apiWidgetUpdate">Widegt details (Widget name, widget description, IsPublic, items in an array of bytes) to be updated.</param>
        /// <returns>Status of updating the widget on the server.</returns>

        public ApiItemResponse UpdateWidget(ApiWidgetUpdateV4 apiWidgetUpdate)
        {
            var requestUrl = _baseUrl + "/dashboards/widgets";
            var result = _serverClientV4.Put(apiWidgetUpdate, requestUrl);
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
        /// This method is to map the Dashboard Datasource
        /// </summary>
        /// <param name="apiDashboardDataSourceUpdate">DashboardDataSource object which is sent as request</param>
        /// <returns>The response is sent as ItemResponse object</returns>

        public ApiItemResponse UpdateDashboardDataSources(ApiDashboardDataSourceUpdate apiDashboardDataSourceUpdate)
        {
            var requestUrl = _baseUrl + "/dashboards/shared-datasources";
            var result = _serverClientV4.Put(apiDashboardDataSourceUpdate, requestUrl);
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
        /// Update Slideshow
        /// </summary>
        /// <remarks>
        /// Users who have write access for slideshow can update an existing slideshow to the server by providing details of the respective slideshow in the request body.
        /// </remarks>
        /// <param name="id">Slideshow ID.</param>
        /// <param name="apiSlideshowEdit">Details about the slideshow passed will be updated to the server.</param>
        /// <returns>The response is sent as ApiResponse object</returns>

        public ApiItemResponse EditSlideshow(Guid id, ApiSlideshowEdit apiSlideshowEdit)
        {
            var requestUrl = _baseUrl + "/slideshow/" + id;
            var result = _serverClientV4.Put(apiSlideshowEdit, requestUrl);
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
        /// Deletes the slideshow
        /// </summary>
        /// <remarks>
        /// Users who have a delete access for slideshow, can delete the slideshow on the server by providing slideshow id parameter.
        /// </remarks>
        /// <param name="id">Slideshow ID.</param>
        /// <returns>The response is sent as ApiResponse object</returns>

        public ApiItemResponse DeleteSlideshow(Guid id)
        {
            var requestUrl = _baseUrl + "/slideshow/" + id;
            var result = _serverClientV4.Delete(new SlideInfo(), requestUrl);
            if (result != null)
            {
                return JsonConvert.DeserializeObject<ApiItemResponse>(result.Content);
            }
            else
            {
                return new ApiItemResponse
                {
                    ApiStatus = true,
                    StatusMessage = "Slide has been deleted successfully."
                };
            }
        }
    }
}