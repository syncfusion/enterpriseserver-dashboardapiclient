using System.Collections.Generic;
using System.IO;
using System.Linq;
using Syncfusion.Dashboard.Server.API.Helper.V2;
using Syncfusion.Dashboard.Server.Api.Helper.V1;
using Syncfusion.Dashboard.Server.API.Helper.V3;
using Syncfusion.Dashboard.Server.API.Helper.V4;
using Syncfusion.Dashboard.Server.Api.Helper.V2.Models;
using Syncfusion.Dashboard.Server.Api.Helper.V1.Models;
using Syncfusion.Dashboard.Server.Api.Helper.V3.Models;
using Syncfusion.Dashboard.Server.Api.Helper.V4.Models;
using Syncfusion.Dashboard.Server.API.Helper;
using System.Net;
using System;

namespace Syncfusion.Dashboard.Server.API.Sample
{
    internal class Program
    {
        // The test user credentials are given here and can access limited API's. Inorder to access all the API'S, admin credentials has to be used.

        private static string SyncfusionDashboardServerUrl = "https://dashboardserver.syncfusion.com";//provide the syncfusion dashboard server hosted URL
        private static string userName = "guest";// user credentials
        private static string password = "demo";

        public static void Main(string[] args)
        {
            //TLS support for 1.0, 1.1 and 1.2
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;

            #region Token generation

            var token = new ServerApiHelper().Connect(SyncfusionDashboardServerUrl, userName, password);

            #endregion

            #region Connect to version 1

            var v1ApiObject = new ServerClientV1();
            v1ApiObject.Connect(SyncfusionDashboardServerUrl, userName, password);

            #endregion

            #region Connect to version 2

            var v2ApiObject = new ServerClientV2();
            v2ApiObject.Connect(SyncfusionDashboardServerUrl, userName, password);

            #endregion

            #region Connect to version 3

            var v3ApiObject = new ServerClientV3();
            v3ApiObject.Connect(SyncfusionDashboardServerUrl, userName, password);

            #endregion

            #region Connect to version 4

            var v4ApiObject = new ServerClientV4();
            v4ApiObject.Connect(SyncfusionDashboardServerUrl, userName, password);

            #endregion

            #region V1

            #region V1 USERS

            #region Add user

            var addUserWithoutPassword = v1ApiObject.UsersEndPoint().CreateUser(new User()
            {
                Username = "sample",
                FirstName = "uuser",
                Lastname = "",
                Email = "sampleuser@syncf.com"
            });

            #endregion

            #region Get user list

            var userList = v1ApiObject.UsersEndPoint().GetAllUsers();

            #endregion

            #region variable declaration for users

            var userId = userList.UserList.Select(x => x.UserId).FirstOrDefault(); // Assign first userid in the user's list

            // Declare username or email id of the user from the user list

            var name = userList.UserList.Select(x => x.Username).FirstOrDefault(); // Assign first username in the user's list
            var emailId = userList.UserList.Select(x => x.Email).FirstOrDefault(); //Assign first email id in the user's list

            #endregion

            #region Update user

            // Update using username

            var updateUser = v1ApiObject.UsersEndPoint().UpdateUser(name, new User() { FirstName = "user" });

            // Update using email id

            // var updateUser = version1ApiObject.UsersEndPoint().UpdateUser(emailId, new User() { FirstName = "user" });

            #endregion

            #region Delete user

            var deleteUser = v1ApiObject.UsersEndPoint().DeleteUser(name);

            #endregion

            #region Get user detail

            var userDetail = v1ApiObject.UsersEndPoint().GetUser(name);

            #endregion

            #endregion

            #region V1 GROUPS

            #region Add group

            var addGroup = v1ApiObject.GroupsEndPoint().CreateGroup(new Group()
            {
                Name = "Test group",
                Description = "Testing"
            });

            #endregion

            #region Get group list

            var listGroup = v1ApiObject.GroupsEndPoint().GetAllGroups();

            #endregion

            #region Variable declaration for groups

            // Declare group id. Assigns first group id in the group list

            var groupId = listGroup.GroupList.Select(x => x.Id).FirstOrDefault();

            #endregion

            #region Update group

            var updateGroup = v1ApiObject.GroupsEndPoint().UpdateGroup(groupId,
                new Group()
                {
                    Name = "Testing group",
                    Description = "test"
                });

            #endregion

            #region Delete group

            var deleteGroup = v1ApiObject.GroupsEndPoint().DeleteGroup(groupId);

            #endregion

            #region Get group detail

            var groupDetails = v1ApiObject.GroupsEndPoint().GetGroup(groupId);

            #endregion

            #region Get members of group

            var groupMembers = v1ApiObject.GroupsEndPoint().GetGroupMembers(groupId);

            #endregion

            #endregion

            #endregion

            #region V2

            #region V2 ITEMS

            #region Get items

            // Get dashboard list

            var dashboardItems = v2ApiObject.ItemsEndPoint().GetItems(ItemType.Dashboard);

            // Get category list

            var categoryItems = v2ApiObject.ItemsEndPoint().GetItems(ItemType.Category);

            // Get datasource list

            var datasourceItems = v2ApiObject.ItemsEndPoint().GetItems(ItemType.Datasource);

            // Get widget list

            var widgetItems = v2ApiObject.ItemsEndPoint().GetItems(ItemType.Widget);

            #endregion

            #endregion

            #region Variable declaration to get details of particular items

            var dashboardId = dashboardItems.Select(i => i.Id).FirstOrDefault(); //Assign the Id of first item in the dashboard list
            var categoryId = categoryItems.Select(i => i.Id).FirstOrDefault(); //Assign the Id of first item in the category list
            var datasourceId = datasourceItems.Select(i => i.Id).FirstOrDefault(); //Assign the Id of first item in the datasource list
            var widgetId = widgetItems.Select(i => i.Id).FirstOrDefault(); //Assign the Id of first item in the widget list

            #endregion

            #region Get item detail

            // Get details of particular dashboard

            var dashboardDetails = v2ApiObject.ItemsEndPoint().GetItemDetail(dashboardId);

            // Get details of particular category

            var categoryDetails = v2ApiObject.ItemsEndPoint().GetItemDetail(categoryId);

            // Get details of particular datasource

            var datasourceDetails = v2ApiObject.ItemsEndPoint().GetItemDetail(datasourceId);

            // Get details of particular widget

            var widgetDetails = v2ApiObject.ItemsEndPoint().GetItemDetail(widgetId);

            #endregion

            #region Get shared datasource

            var getSharedDatasources = v2ApiObject.ItemsEndPoint().GetSharedDataSources(new ApiSharedDataSourceRequest()
            {
                DashboardId = dashboardId
            });

            #endregion

            #region Get public dashboards

            var getPublicDashboards = v2ApiObject.ItemsEndPoint().GetPublicItems(ItemType.Dashboard);

            #endregion

            #region Get public widgets

            var getPublicWidgets = v2ApiObject.ItemsEndPoint().GetPublicItems(ItemType.Widget);

            #endregion

            #region Get favorite dashboards

            var favoriteDashboards = v2ApiObject.ItemsEndPoint().GetFavoriteItems();

            #endregion

            #region Add category

            var addCategory = v2ApiObject.ItemsEndPoint().AddCategory(new ApiCategoryAdd() { Name = "samplecategory" });

            #endregion

            #region Add dashboard

            var adddashboard = v2ApiObject.ItemsEndPoint().AddDashboard(new ApiDashboardAdd()
            {
                Name = "Testing dashboard",
                Description = "Testing purpose",
                CategoryId = categoryId,
                IsPublic = true, //Set ispublic Value to make and remove Dashboard Public Access
                ItemContent = File.ReadAllBytes("../../Tickets Sold Analysis Dashboard (Sample dashboard v2.3).sydx")
            });

            #endregion

            #region Add datasource

            var addDataSource = v2ApiObject.ItemsEndPoint().AddDataSource(new ApiDataSourceAdd()
            {
                Name = "Test datasource",
                Description = "Testing purpose",
                ItemContent = File.ReadAllBytes("../../DataSource3 (Sample datasource v2.3).syds")
            });

            #endregion

            #region Add widget

            var addWidget = v2ApiObject.ItemsEndPoint().AddWidget(new ApiWidgetAdd()
            {
                Name = "Sample widget",
                Description = "Testing purpose",
                IsPublic = true, //Set ispublic Value to make and remove Dashboard Public Access
                ItemContent = File.ReadAllBytes("../../Website Visitor Analysis (Random data) testing (Sample widget v2.3).sydw")
            });

            #endregion

            #region Check itemm name existence

            var checkNameExistence = v2ApiObject.ItemsEndPoint().IsItemNameExists(new ApiValidateItemName()
            {
                ItemName = "Worldwide Car Sales (Random data)",
                ItemType = ItemType.Dashboard.ToString(),
                CategoryName = "sample dashboards"
            });

            #endregion

            #region Update category

            var updateCategory = v2ApiObject.ItemsEndPoint().UpdateCategory(new ApiCategoryUpdate()
            {
                CategoryId = categoryId,
                Name = "update test"
            });

            #endregion

            #region Update dashboard

            var updateDashboard = v2ApiObject.ItemsEndPoint().UpdateDashboard(new ApiDashboardUpdate()
            {
                DashboardId = dashboardId,
                IsPublic = false,
                Name = "Testing dashboard update",
                ItemContent = File.ReadAllBytes("../../Tickets Sold Analysis Dashboard (Sample dashboard v2.3).sydx")
            });

            #endregion

            #region Update datasource

            var updateDatasource = v2ApiObject.ItemsEndPoint().UpdateDataSource(new ApiDataSourceUpdate()
            {
                DataSourceId = datasourceId,
                Description = "testing",
                ItemContent = File.ReadAllBytes("../../FIFA World Cup 2014 - Brazil (Sample datasource v2.3).syds")
            });

            #endregion

            #region Update widget

            var updateWidget = v2ApiObject.ItemsEndPoint().UpdateWidget(new ApiWidgetUpdate()
            {
                WidgetId = widgetDetails.Id,
                Description = "test",
                ItemContent = File.ReadAllBytes("../../FIFA World Cup 2014 – Brazil (Sample widget v2.3).sydw")
            });

            #endregion

            #region Variable declaration to get favorite dashbaord

            var favoriteDashboardId = favoriteDashboards.Select(x => x.DashboardId).FirstOrDefault();

            #endregion

            #region Update favorite dashboard

            var updateFavoriteDashboard = v2ApiObject.ItemsEndPoint().UpdateFavoriteItem(new ApiUpdateFavorite()
            {
                DashboardId = favoriteDashboardId,
                Favorite = false
            });

            #endregion


            #region Export dashboard

            // Export dashboard to excel format

            var exportDashboardToExcel = v2ApiObject.ItemsEndPoint().ExportDashboard(new ApiExportDashboard()
            {
                DashboardId = dashboardId,
                ExportType = ExportType.Excel.ToString()
            });

            // Export dashboard to Pdf format

            var exportDshboardToPdf = v2ApiObject.ItemsEndPoint().ExportDashboard(new ApiExportDashboard()
            {
                DashboardId = dashboardId,
                ExportType = ExportType.Pdf.ToString()
            });

            // Export dashboard to Image format

            var exportDshboardImage = v2ApiObject.ItemsEndPoint().ExportDashboard(new ApiExportDashboard()
            {
                DashboardId = dashboardId,
                ExportType = ExportType.Image.ToString()
            });

            #endregion

            var scheduleId = Guid.Parse("716e1f81-a31d-4471-9126-0679c641da1a"); //Schedule Id from the server.

            #region Delete item

            // Delete dashboard

            var deleteDashboard = v2ApiObject.ItemsEndPoint().DeleteItem(dashboardId);

            // Delete category

            var deleteCategory = v2ApiObject.ItemsEndPoint().DeleteItem(categoryId);

            // Delete datasource

            var deleteDatasource = v2ApiObject.ItemsEndPoint().DeleteItem(datasourceId);

            // Delete widget

            var deleteWidget = v2ApiObject.ItemsEndPoint().DeleteItem(widgetId);

            // Delete schedule

            var deleteSchedule = v2ApiObject.ItemsEndPoint().DeleteItem(scheduleId);

            #endregion

            #region V2 USERS

            #region V2 Download CSV template

            var downloadCsvTemplate = v2ApiObject.UsersEndPoint2().DownloadCsvTemplate();

            #endregion

            #region V2 Add user

            var addUserWithPassword = v2ApiObject.UsersEndPoint2().AddUserV2(new ApiUserAdd()
            {
                Email = "testuser@sync.com",
                FirstName = "Test2 user",
                Username = "Testuser2",
                Password = "Testuser@1203"
            });

            #endregion

            #region V2 Add CSV user

            var addCsvUser = v2ApiObject.UsersEndPoint2().CsvUserImport(new ApiCsvUserImportRequest()
            {
                CsvFileContent = File.ReadAllBytes("../../CSV Users.csv")
            });

            #endregion

            #region V2 Get group details of particular user

            var groupDetailsOfUser = v2ApiObject.UsersEndPoint2().GetGroupsOfUser(name);

            #endregion

            #region V2 Activate or deactivate the user

            var activateUser = v2ApiObject.UsersEndPoint2().ActivateDeactivateuser(name,
                new ApiUserActivationRequest()
                {
                    Activate = true   // Status to activate or deactivate the user
                });

            #endregion

            #endregion

            #region V2 GROUPS

            #region V2 Add user to particular group

            var addUserToGroup = v2ApiObject.GroupsEndPoint2().AddUserToGroup(groupId,
            new ApiGroupUsers()
            {
                Id = new List<int> { 3, 4 } // List of user's id to be added to the group

            });

            #endregion

            #region V2 Delete user from particular group

            var deleteUserFromGroup = v2ApiObject.GroupsEndPoint2().DeleteUserFromGroup(groupId,
            new ApiGroupUsers()
            {
                Id = new List<int> { 3, 4 } //List of user's id to be deleted from the group
            });

            #endregion

            #endregion

            #region V2 PERMISSION

            #region V2 Get list of permissions of particular user

            var getUserPermission = v2ApiObject.PermissionsEndPoint().GetUserPermission(userId);

            #endregion

            #region V2 Get list of permissions of particular group

            var getGroupPermission = v2ApiObject.PermissionsEndPoint().GetGroupPermission(groupId);

            #endregion

            #region V2 Add permission to particular user

            var addUserPermission = v2ApiObject.PermissionsEndPoint().AddUserPermission(new ApiUserPermissionAdd()
            {
                PermissionAccess = PermissionAccess.Read.ToString(),
                UserId = 3,
                PermissionEntity = PermissionEntity.AllDashboards.ToString()
            });

            #endregion

            #region V2 Add permission to particular group

            var addGroupPermission = v2ApiObject.PermissionsEndPoint().AddGroupPermission(new ApiGroupPermissionAdd()
            {
                PermissionAccess = PermissionAccess.Create.ToString(),
                GroupId = 2,
                PermissionEntity = PermissionEntity.AllCategories.ToString()
            });

            #endregion

            #region Variable declaration to get permission id of users and groups

            var userPermissionId = getUserPermission.Where(x => x.UserId == userId).Select(x => x.PermissionId).FirstOrDefault(); // Assign first permission id of the first user

            var groupPermissionId = getGroupPermission.Where(x => x.GroupId == groupId).Select(x => x.PermissionId).FirstOrDefault(); // Assign first permission id of the first group

            #endregion

            #region V2 Delete specific user permission

            var deleteUserPermission = v2ApiObject.PermissionsEndPoint().DeleteUserPermission(userPermissionId);

            #endregion

            #region V2 Delete specific group permission

            var deleteGroupPermission = v2ApiObject.PermissionsEndPoint().DeleteGroupPermission(groupPermissionId);

            #endregion

            #endregion

            #endregion

            #region V3

            #region V3 Items

            #region Add file

            var addFile = v3ApiObject.ItemsEndPoint2().AddFile(new ApiFileAdd()
            {
                Name = "Test file3",
                Description = "Testing purpose",
                ItemContent = File.ReadAllBytes("../../FIFA World Cup 2014 - Brazil (Sample datasource v2.3).syds"),
                Extension = ".syds"
            });

            #endregion

            #region Update file

            var updateFile = v3ApiObject.ItemsEndPoint2().UpdateFile(new ApiFileUpdate()
            {
                ItemId = fileId,
                Name = "Test file-update5",
                Description = "Testing purpose",
                ItemContent = File.ReadAllBytes("../../FIFA World Cup 2014 - Brazil (Sample datasource v2.3).syds"),
                Extension = ".sydx"
            });

            #endregion

            #region Get Dashboard Parameter

            var dashboardParameter = v3ApiObject.ItemsEndPoint2().GetDashboardParameter(new ItemRequest()
            {
                UserId = userId,
                ItemId = dashboardId
            });

            #endregion

            #endregion

            #endregion

            #region V4

            #region V4 Items

            #region Get Items

            // Get dashboard list

            var dashboardItemsV4 = v4ApiObject.ItemsEndPoint3().GetItems(ItemTypeV4.Dashboard);

            // Get category list

            var categoryItemsV4 = v4ApiObject.ItemsEndPoint3().GetItems(ItemTypeV4.Category);

            // Get datasource list

            var datasourceItemsV4 = v4ApiObject.ItemsEndPoint3().GetItems(ItemTypeV4.Datasource);

            // Get widget list

            var widgetItemsV4 = v4ApiObject.ItemsEndPoint3().GetItems(ItemTypeV4.Widget);

            // Get file list

            var filesV4 = v4ApiObject.ItemsEndPoint3().GetItems(ItemTypeV4.File);

            #endregion

            #region Variable declaration to get details of particular items

            var dashboardIdV4 = dashboardItemsV4.Select(i => i.Id).FirstOrDefault(); //Assign the Id of first item in the dashboard list
            var categoryIdV4 = categoryItemsV4.Select(i => i.Id).FirstOrDefault(); //Assign the Id of first item in the category list
            var datasourceIdV4 = datasourceItemsV4.Select(i => i.Id).FirstOrDefault(); //Assign the Id of first item in the datasource list
            var widgetIdV4 = widgetItemsV4.Select(i => i.Id).FirstOrDefault(); //Assign the Id of first item in the widget list
            var fileIdV4 = filesV4.Select(i => i.Id).FirstOrDefault(); //Assign the Id of first item in the files

            #endregion

            #region Get Item Details

            // Get details of particular dashboard

            var dashboardDetailsV4 = v4ApiObject.ItemsEndPoint3().GetItemDetail(dashboardIdV4);

            // Get details of particular category

            var categoryDetailsV4 = v4ApiObject.ItemsEndPoint3().GetItemDetail(categoryIdV4);

            // Get details of particular datasource

            var datasourceDetailsV4 = v4ApiObject.ItemsEndPoint3().GetItemDetail(datasourceIdV4);

            // Get details of particular widget

            var widgetDetailsV4 = v4ApiObject.ItemsEndPoint3().GetItemDetail(widgetIdV4);

            // Get details of particular file

            var fileDetailsV4 = v4ApiObject.ItemsEndPoint3().GetItemDetail(fileIdV4);

            #endregion

            #region Get Shared Datasource

            var dashboardDatasource = v4ApiObject.ItemsEndPoint3().GetSharedDataSources(new ApiSharedDataSourceRequestV4()
            {
                UserId = userId,
                DashboardId = dashboardIdV4
            });

            #endregion

            #region Get Slideshows

            var getSlideshows = v4ApiObject.ItemsEndPoint3().GetSlideshows();

            #endregion

            #region Get Id of particular Slide

            var slideId = getSlideshows.Select(i => i.Id).FirstOrDefault(); // Assign the Id of first slide

            #endregion

            #region Get Slideshow Details

            var getSlideDetails = v4ApiObject.ItemsEndPoint3().GetSlideshowDetail(slideId);

            #endregion

            #region Add dashboard

            var adddashboardV4 = v4ApiObject.ItemsEndPoint3().AddDashboard(new ApiDashboardAddV4()
            {
                Name = "Testing dashboard V4",
                Description = "Testing purpose V4",
                CategoryId = categoryIdV4,
                IsPublic = false, //Set ispublic Value to make and remove Dashboard Public Access
                ItemContent = File.ReadAllBytes("../../FIFA World Cup 2014 - Brazil (Sample dashboard v2.3).sydx"),
                IsUnlisted = true
            });

            #endregion

            #region Add widget

            var addWidgetV4 = v4ApiObject.ItemsEndPoint3().AddWidget(new ApiWidgetAddV4()
            {
                Name = "Sample widget V4",
                Description = "Testing purpose V4",
                IsPublic = false, //Set ispublic Value to make and remove Dashboard Public Access
                ItemContent = File.ReadAllBytes("../../FIFA World Cup 2014 – Brazil (Sample widget v2.3).sydw"),
                IsUnlisted = true
            });

            #endregion

            #region Add Slideshow

            var addSlideshowV4 = v4ApiObject.ItemsEndPoint3().AddSlideshow(new ApiSlideshowAdd()
            {
                Name = "Test Slideshow",
                Duration = 5,
                Slides = new List<Slide>
                {
                    new Slide
                    {
                        OrderNumber = 1,
                        ItemType = ItemTypeV4.Dashboard,
                        ItemInfo = new SlideInfo
                        {
                            Id = dashboardIdV4,
                            Name = "test slide",
                            CategoryId = categoryIdV4,
                            IsMultiDashboard = false
                        }
                    }
                }
            });

            #endregion

            #region Update Dashboard

            var updateDashboardV4 = v4ApiObject.ItemsEndPoint3().UpdateDashboard(new ApiDashboardUpdateV4()
            {
                DashboardId = dashboardIdV4,
                IsPublic = false,
                Name = "Testing dashboard update",
                ItemContent = File.ReadAllBytes("../../FIFA World Cup 2014 - Brazil (Sample dashboard v2.3).sydx"),
                IsUnlisted = false
            });

            #endregion

            #region Update Widget

            var updateWidgetV4 = v4ApiObject.ItemsEndPoint3().UpdateWidget(new ApiWidgetUpdateV4()
            {
                Name = "testc v4widget",
                WidgetId = widgetIdV4,
                Description = "test",
                ItemContent = File.ReadAllBytes("../../FIFA World Cup 2014 – Brazil (Sample widget v2.3).sydw"),
                IsPublic = false,
                IsUnlisted = false
            });

            #endregion

            #region Update Dashboard Datasource

            var updateDashboardDatasource = v4ApiObject.ItemsEndPoint3().UpdateDashboardDataSources(new ApiDashboardDataSourceUpdate
            {
                DashboardId = dashboardIdV4,
                DataSourceDetails = new List<DataSourceMappingInfo>
                {
                    new DataSourceMappingInfo
                    {
                        DataSourceId = datasourceIdV4,
                        Name = "testV4"
                    }
                }
            });

            #endregion

            #region Update Slideshow

            var updateSlide = v4ApiObject.ItemsEndPoint3().EditSlideshow(slideId, new ApiSlideshowEdit
            {
                Name = "update test slide",
                Duration = 6,
                Slides = new List<Slide>
                {
                    new Slide
                    {
                        OrderNumber = 1,
                        ItemType = ItemTypeV4.Dashboard,
                        ItemInfo = new SlideInfo
                        {
                            Id = dashboardIdV4,
                            Name = "update slide",
                            CategoryId = categoryIdV4,
                            IsMultiDashboard = false
                        }
                    },
                    new Slide
                    {
                        OrderNumber = 2,
                        ItemType = ItemTypeV4.Dashboard,
                        ItemInfo = new SlideInfo
                        {
                            Id = dashboardIdV4,
                            Name = "update2 slide",
                            CategoryId = categoryIdV4,
                            IsMultiDashboard = false
                        }
                    }
                }
            });


            #endregion

            #region Delete Slideshow

            var deleteSlide = v4ApiObject.ItemsEndPoint3().DeleteSlideshow(slideId);

            #endregion

            #endregion

            #region V4 Schedules

            #region Add Schedule

            var addSchedule = v4ApiObject.ScheduleEndPoint().AddSchedule(new ApiDashboardScheduleRequest()
            {
                Name = "test schedule new",
                ExportType = "Pdf",
                StartTime = "2019-02-07T17:00:00Z",
                NeverEnd = false,
                EndAfterOccurrence = 3,
                EndDate = "2019-03-07T17:30:00Z",
                UserList = new List<string>
                {
                    "test"
                },
                ScheduleType = "Hourly",
                HourlySchedule = new ApiHourlySchedule()
                {
                    ScheduleInterval = "00:10"
                },
                ItemId = dashboardIdV4
            });

            #endregion

            #region Update Schedule

            var scheduleIdV4 = Guid.Parse("716e1f81-a31d-4471-9126-0679c641da1a"); //Schedule Id from the server.

            var updateSchedule = v4ApiObject.ScheduleEndPoint().UpdateSchedule(scheduleIdV4, new ApiUpdateScheduleRequest()
            {
                Name = "test schedule update",
                ExportType = "Excel",
                StartTime = "2019-02-07T12:00:00Z",
                NeverEnd = false,
                EndAfterOccurrence = 5,
                EndDate = "2019-03-07T12:00:00Z",
                ItemType = ItemType.Schedule.ToString(),
                UserList = new List<string>
                {
                    "master"
                },
                ScheduleType = "Hourly",
                HourlySchedule = new ApiHourlySchedule()
                {
                    ScheduleInterval = "00:10"
                },
                ItemId = dashboardIdV4
            });

            #endregion

            #endregion

            #endregion
        }
    }
}
