using Newtonsoft.Json;
using Syncfusion.Dashboard.Server.Api.Helper.Authentication;
using Syncfusion.Dashboard.Server.Api.Helper.V2.Models;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace Syncfusion.Dashboard.Server.API.Helper.V2.EndPoints
{
    public class ItemsEndPoint
    {
        private readonly ServerClientV2 _serverClientV2;
        private readonly string _baseUrl;

        public ItemsEndPoint(ServerClientV2 serverClientV2)
        {
            _serverClientV2 = serverClientV2;
            _baseUrl = _serverClientV2.BaseUrl;
        }

        /// <summary>
        /// This method returns list of items for the itemtype category, dashboard, datasource, widget and schedule.
        /// </summary>
        /// <param name="itemType">Item type (category, dashboard, datasource, widget and schedule)</param>
        /// <param name="serverPath">Category path</param>
        /// <returns>List of items for the itemtype.</returns>

        public List<ApiItems> GetItems([FromUri] ItemType itemType, [FromUri] string serverPath = null)
        {
            var requestUrl = _baseUrl + "/items";
            var items = new List<ApiItems>();
            var param = new Dictionary<string, object>();
            param.Add("itemtype", itemType);
            var result = _serverClientV2.Get(items, requestUrl, param);
            if (result != null)
            {
                return JsonConvert.DeserializeObject<List<ApiItems>>(result.Content);
            }
            else
            {
                return items;
            }   
        }

        /// <summary>
        /// This method returns item details for the values Category Id, Dashboard Id, Datasource Id, Widget Id and Schedule Id.
        /// </summary>
        /// <param name="id">The id values may be Category Id, Dashboard Id, Datasource Id, Widget Id and Schedule Id.</param>
        /// <returns>Item details for the values.</returns>

        public ApiSpecifiedItemDetail GetItemDetail(Guid id)
        {
            var overrideUrl = _baseUrl + "/items/" + id;
            var itemDetail = new ApiSpecifiedItemDetail();
            var result =  _serverClientV2.Get(itemDetail, overrideUrl);
            if(result != null)
            {
                return JsonConvert.DeserializeObject<ApiSpecifiedItemDetail>(result.Content);
            }
            else
            {
                return itemDetail;
            }   
        }

        /// <summary>
        /// This method returns shared datasources of a specific dashboard.
        /// </summary>
        /// <param name="apiSharedDataSourceRequest">Details(Dashboard id, dashboard path) about the dashboard to get their shared data sources.</param>
        /// <returns>Shared datasources of a specific dashboard.</returns>

        public List<ApiSharedDataSourceResponse> GetSharedDataSources(
            ApiSharedDataSourceRequest apiSharedDataSourceRequest)
        {
            var requestUrl = _baseUrl + "/dashboards/shared-datasources";
            var datasource = new List<ApiSharedDataSourceResponse>();
            var result =  _serverClientV2.Post(apiSharedDataSourceRequest, requestUrl);
            if(result != null)
            {
                return JsonConvert.DeserializeObject<List<ApiSharedDataSourceResponse>>(result.Content);
            }
            else
            {
                return datasource;
            }
        }

        /// <summary>
        /// This method returns the public items for the values dashboard and widget.
        /// </summary>
        /// <param name="itemType"></param>
        /// <returns>Public items for the values dashboard and widget.</returns>

        public List<ApiPublicItems> GetPublicItems([FromUri] ItemType itemType)
        {
            var requestUrl = _baseUrl + "/dashboards/public";
            var publicItems = new List<ApiPublicItems>();
            var param = new Dictionary<string, object>();
            param.Add("itemtype", itemType);
            var result = _serverClientV2.Get(publicItems, requestUrl, param);
            if(result != null)
            {
                return JsonConvert.DeserializeObject<List<ApiPublicItems>>(result.Content);
            }
            else
            {
                return publicItems;
            }
        }

        /// <summary>
        ///  This method returns list of favorite dashboards that belong to current user.
        /// </summary>
        /// <returns>List of favorite dashboards.</returns>

        public List<ApiFavoriteitems> GetFavoriteItems()
        {
            var requestUrl = _baseUrl + "/dashboards/favorite";
            var favoriteItems = new List<ApiFavoriteitems>();
            var result =  _serverClientV2.Get(favoriteItems, requestUrl);
            if(result != null)
            {
                return JsonConvert.DeserializeObject<List<ApiFavoriteitems>>(result.Content);
            }
            else
            {
                return favoriteItems;
            }
        }

        /// <summary>
        /// This method is used to add new category to the server.
        /// </summary>
        /// <param name="apiCategoryAdd">Category details (Category name and category description) to be added.</param>
        /// <returns>Status of adding category to the server.</returns>
        public ApiResponse AddCategory(ApiCategoryAdd apiCategoryAdd)
        {
            var result = _serverClientV2.Post(apiCategoryAdd, _baseUrl + "/categories");
            var response = new ApiResponse();
            if(result != null)
            {
                return JsonConvert.DeserializeObject<ApiResponse>(result.Content);
            }
            else
            {
                return new ApiResponse();
            }
        }

        /// <summary>
        /// This method is used to add new dashboard to the server.
        /// </summary>
        /// <param name="apiDashboardAdd">Dashboard details (Dashboard name, Dashboard description, IsPublic, Item in an array of bytes) to be added.</param>
        /// <returns>Status of adding dashboard to the server.</returns>

        public ApiItemResponse AddDashboard(ApiDashboardAdd apiDashboardAdd)
        {
            var result = _serverClientV2.Post(apiDashboardAdd, _baseUrl + "/dashboards");
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
        /// This method is used to add new datasource to the server.
        /// </summary>
        /// <param name="apiDataSourceAdd">Datasource details(Datasource name, Datasource description and item in an array of bytes) to be added.</param>
        /// <returns>Status of adding datasource to the server.</returns>

        public ApiItemResponse AddDataSource(ApiDataSourceAdd apiDataSourceAdd)
        {
            var result = _serverClientV2.Post(apiDataSourceAdd, _baseUrl + "/dashboards/data-sources");
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

        public ApiItemResponse AddWidget(ApiWidgetAdd apiWidgetAdd)
        {
            var result = _serverClientV2.Post(apiWidgetAdd, _baseUrl + "/dashboards/widgets");
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
        /// This method returns whether the item (category, dashboard, datasource, widget, schedule) already exists in the server.
        /// </summary>
        /// <param name="apiValidateItemName">Details about the item (Item name, category name, itemtype)</param>
        /// <returns>Returns whether the item already exists in the server.</returns>

        public bool IsItemNameExists(ApiValidateItemName apiValidateItemName)
        {
            var requestUrl = _baseUrl + "/items/is-name-exists";
            var param = new Dictionary<string, object>();
            param.Add("itemname", apiValidateItemName.ItemName);
            param.Add("itemtype", apiValidateItemName.ItemType);
            param.Add("categoryname", apiValidateItemName.CategoryName);
            var result = _serverClientV2.Post(apiValidateItemName, requestUrl,param);
            if(result != null)
            {
                return JsonConvert.DeserializeObject<bool>(result.Content);
            }
            else
            {
                return false;
            }  
        }

        /// <summary>
        /// This method is used to update the existing category on the server.
        /// </summary>
        /// <param name="apiCategoryUpdate">Category details (Category name and category description) to be updated.</param>
        /// <returns>Status of updating the category on the server.</returns>

        public ApiResponse UpdateCategory(ApiCategoryUpdate apiCategoryUpdate)
        {
            var requestUrl = _baseUrl + "/categories";
            var result = _serverClientV2.Put(apiCategoryUpdate, requestUrl);
            var response = new ApiResponse();
            if (result != null)
            {
                return JsonConvert.DeserializeObject<ApiResponse>(result.Content);
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

        public ApiItemResponse UpdateDashboard(ApiDashboardUpdate apiDashboardUpdate)
        {
            var requestUrl = _baseUrl + "/dashboards";
            var result = _serverClientV2.Put(apiDashboardUpdate, requestUrl);
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
        /// This method is used to update the existing datasource on the server.
        /// </summary>
        /// <param name="apiDataSourceUpdate">Datasource details(Datasource name, Datasource description and item in an array of bytes) to be updated.</param>
        /// <returns>Status of updating the datasource on the server.</returns>

        public ApiResponse UpdateDataSource(ApiDataSourceUpdate apiDataSourceUpdate)
        {
            var requestUrl = _baseUrl + "/dashboards/data-sources";
            var result = _serverClientV2.Put(apiDataSourceUpdate, requestUrl);
            var response = new ApiResponse();
            if (result != null)
            {
                return JsonConvert.DeserializeObject<ApiResponse>(result.Content);
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

        public ApiItemResponse UpdateWidget(ApiWidgetUpdate apiWidgetUpdate)
        {
            var requestUrl = _baseUrl + "/dashboards/widgets";
            var result = _serverClientV2.Put(apiWidgetUpdate, requestUrl);
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
        ///  This method is used to update the dashboard as favorite or non-favorite on the server.
        /// </summary>
        /// <param name="apiUpdateFavorite">Dashboard details (Dashboard Id and Favorite value to set the item as favorite) to be updated.</param>
        /// <returns>Status of updating the dashbaord as favorite or non-favorite on the server.</returns>
        
        public ApiResponse UpdateFavoriteItem(ApiUpdateFavorite apiUpdateFavorite)
        {
            var requestUrl = _baseUrl + "/dashboards/favorite";
            var result = _serverClientV2.Put(apiUpdateFavorite, requestUrl);
            var response = new ApiResponse();
            if (result != null)
            {
                return JsonConvert.DeserializeObject<ApiResponse>(result.Content);
            }
            else
            {
                return response;
            }
        }

        /// <summary>
        /// This method is used to export the dashboards for the users who have read access for dashboards.
        /// </summary>
        /// <param name="apiExportDashboard">Dashboard details (Dashboard Id, Server path, Export type).</param>
        /// <returns>Status of exporting the dashboard.</returns>
         
        public ApiExportDashboardResponse ExportDashboard(ApiExportDashboard apiExportDashboard)
        {
            var result = _serverClientV2.Post(apiExportDashboard, _baseUrl + "/dashboards/export");
            var response = new ApiExportDashboardResponse();
            if (result != null)
            {
                return JsonConvert.DeserializeObject<ApiExportDashboardResponse>(result.Content);
            }
            else
            {
                return response;
            }
        }

        /// <summary>
        /// This method is used to delete the item(Category, Dashboard, Datasource, Widget, Schedule) on the server.
        /// </summary>
        /// <param name="id">Item Id.</param>
        /// <returns>Status of deleting the items on the server.</returns>
         
        public ApiResponse DeleteItem(Guid id)
        {
            var requestUrl = _baseUrl + "/items/" + id;
            var result = _serverClientV2.Delete(new ApiItems(), requestUrl);
            if(result != null)
            {
                return JsonConvert.DeserializeObject<ApiResponse>(result.Content);
            }
            else
            {
                return new ApiResponse {
                ApiStatus = true,
                StatusMessage = "Item has been deleted successfully."};
            }
        }
    }
}