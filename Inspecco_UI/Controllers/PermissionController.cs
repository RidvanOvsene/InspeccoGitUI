using Inspecco_UI.Api;
using Inspecco_UI.Helpers;
using Inspecco_UI.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Inspecco_UI.Contpermissionlers
{
    public class PermissionController : Controller
    {
        private readonly IRequest _request;
        private readonly ISessionHelper _sessionhelper;
        public PermissionController(IRequest request,
                         ISessionHelper sessionhelper)
        {
            _request = request;
            _sessionhelper = sessionhelper;
        }
        public IActionResult PermissionList()
        {
            string SessionData = _sessionhelper.GetSessionModel("UserPermission");
            SeesionModel SessionObject = JsonConvert.DeserializeObject<SeesionModel>(SessionData);
            ViewData["PermissionList"] = SessionObject;
            var Permission = _request.GetAsync<List<Permission>>(SessionObject.Token, "Permission/getall").Result.ToList();
            return View(Permission);

        }
    }
}
