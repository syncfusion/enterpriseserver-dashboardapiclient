using Syncfusion.Dashboard.Server.API.Helper.V3.EndPoints;

namespace Syncfusion.Dashboard.Server.API.Helper.V3
{
    public sealed class ServerClientV3 : ServerApiHelper
    {
        public ServerClientV3()
        {
           BaseUrl = BaseUrl + "/api/v3.0";
        }

        public ItemsEndPoint2 ItemsEndPoint2()
        {
            return new ItemsEndPoint2(this);
        }
    }
}