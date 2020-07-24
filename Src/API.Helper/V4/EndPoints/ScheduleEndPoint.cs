using Newtonsoft.Json;
using Syncfusion.Dashboard.Server.Api.Helper.Authentication;
using Syncfusion.Dashboard.Server.Api.Helper.V4.Models;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace Syncfusion.Dashboard.Server.API.Helper.V4.EndPoints
{
    public class ScheduleEndPoint
    {
        private readonly ServerClientV4 _serverClientV4;
        private readonly string _baseUrl;

        public ScheduleEndPoint(ServerClientV4 serverClientV4)
        {
            _serverClientV4 = serverClientV4;
            _baseUrl = _serverClientV4.BaseUrl;
        }

        /// <summary>
        /// Add Schedule
        /// </summary>
        /// <remarks>Users who have create access for schedule can add new schedule to the server by providing respective schedule details in the request body.</remarks>
        /// <param name="apiScheduleRequest">Details about the schedule passed will be added to the server.</param>
        /// <returns>The response is sent as a ApiScheduleResponse object</returns>

        public ApiScheduleResponse AddSchedule(ApiDashboardScheduleRequest apiDashboardScheduleRequest)
        {
            var result = _serverClientV4.Post(apiDashboardScheduleRequest, _baseUrl + "/dashboard/schedule");
            var response = new ApiScheduleResponse();
            if (result != null)
            {
                return JsonConvert.DeserializeObject<ApiScheduleResponse>(result.Content);
            }
            else
            {
                return response;
            }
        }

        /// <summary>
        /// Update Schedule
        /// </summary>
        /// <remarks>Users who have write access for schedule can update an existing schedule to the server by providing details of the respective schedule in the request body.</remarks>
        /// <param name="scheduleid">Schedule ID.</param>
        /// <param name="apiUpdateScheduleRequest">Details about the schedule passed will be updated to the server.</param>
        /// <returns>The response is sent as a ApiScheduleResponse object</returns>

        public ApiScheduleResponse UpdateSchedule(Guid scheduleid, ApiUpdateScheduleRequest apiUpdateScheduleRequest)
        {
            var requestUrl = _baseUrl + "/dashboard/schedule/" + scheduleid;
            var result = _serverClientV4.Put(apiUpdateScheduleRequest, requestUrl);
            var response = new ApiScheduleResponse();
            if (result != null)
            {
                return JsonConvert.DeserializeObject<ApiScheduleResponse>(result.Content);
            }
            else
            {
                return response;
            }
        }
    }
}