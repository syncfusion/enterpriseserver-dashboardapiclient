using Syncfusion.Dashboard.Server.API.Helper.V4.EndPoints;

namespace Syncfusion.Dashboard.Server.API.Helper.V4
{
    public sealed class ServerClientV4 : ServerApiHelper
    {
        public ServerClientV4()
        {
           BaseUrl = BaseUrl + "/api/v4.0";
        }

        public ItemsEndPoint3 ItemsEndPoint3()
        {
            return new ItemsEndPoint3(this);
        }
		
		public ScheduleEndPoint ScheduleEndPoint()
        {
            return new ScheduleEndPoint(this);
        }
    }
}