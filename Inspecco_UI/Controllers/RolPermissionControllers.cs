using Inspecco_UI.Api;
using Inspecco_UI.Helpers;
using Inspecco_UI.Models;
using Inspecco_UI.Models.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace Inspecco_UI.Controllers
{
    public class RolPermissionController : Controller
    {
        private readonly IRequest _request;
        private readonly ISessionHelper _sessionhelper;

        public RolPermissionController(IRequest request,
                           ISessionHelper sessionhelper)
        {
            _request = request;
            _sessionhelper = sessionhelper;
        }

        public IActionResult RolPermissionList()
        {
            string SessionData = _sessionhelper.GetSessionModel("UserPermission");
            SeesionModel SessionObject = JsonConvert.DeserializeObject<SeesionModel>(SessionData);
            ViewData["PermissionList"] = SessionObject;
            var RolPermissionDto = _request.GetAsync<List<RolPermissionDto>>(SessionObject.Token, "RolPermission/GetListRolPermission").Result.ToList();
            return View(RolPermissionDto);
        }

        public IActionResult RolPermissionCreate(int Id)
        {
            string SessionData = _sessionhelper.GetSessionModel("UserPermission");
            SeesionModel SessionObject = JsonConvert.DeserializeObject<SeesionModel>(SessionData);
            var RolPermission = _request.GetAsync<RolPermission>(SessionObject.Token, "RolPermission/getbyid?RolPermissionId=" + Id).Result;
            var Rol = _request.GetAsync<List<Rol>>(SessionObject.Token, "Rol/getall").Result.ToList();
            var Permission = _request.GetAsync<List<Permission>>(SessionObject.Token, "Permission/getall").Result.ToList();
            ViewBag.Permission = Permission;
            ViewBag.Rol = Rol;

            return View(RolPermission);
        }
        [HttpPost]
        public IActionResult RolPermissionCreate(RolPermission rolPermission)
        {
            string SessionData = _sessionhelper.GetSessionModel("UserPermission");
            SeesionModel SessionObject = JsonConvert.DeserializeObject<SeesionModel>(SessionData);
            _request.PostAsync(SessionObject.Token, "RolPermission/add", rolPermission);
            return RedirectToAction("RolPermissionList");
        }
        public IActionResult RolPermissionDelete(int Id)
        {
            string SessionData = _sessionhelper.GetSessionModel("UserPermission");
            SeesionModel SessionObject = JsonConvert.DeserializeObject<SeesionModel>(SessionData);
            var rolPermission = _request.GetAsync<RolPermission>(SessionObject.Token, "RolPermission/getbyid?RolPermissionId=" + Id).Result;
            _request.PostAsync(SessionObject.Token, "RolPermission/delete", rolPermission);
            return RedirectToAction("RolPermissionList");
        }
        public IActionResult RolPermissionEdit(int Id)
        {
            string SessionData = _sessionhelper.GetSessionModel("UserPermission");
            SeesionModel SessionObject = JsonConvert.DeserializeObject<SeesionModel>(SessionData);
            var RolPermission = _request.GetAsync<List<RolPermissionDto>>(SessionObject.Token, "RolPermission/GetListRolPermission").Result.FirstOrDefault(x => x.RolPermissionId == Id);
            var Rol = _request.GetAsync<Rol>(SessionObject.Token, "Rol/getbyid?RolId=" + Id).Result;
            var Permission = _request.GetAsync<List<Permission>>(SessionObject.Token, "Permission/getall").Result.ToList();
            ViewBag.SelectedPermission = RolPermission;
            ViewBag.Permission = Permission;
            ViewBag.Rol = Rol;
            return View(RolPermission);
        }
        [HttpPost]
        public IActionResult RolPermissionEdit(int PermissionId, int RolPermissionId)
        {
            string SessionData = _sessionhelper.GetSessionModel("UserPermission");
            SeesionModel SessionObject = JsonConvert.DeserializeObject<SeesionModel>(SessionData);
            var _rolPermission = _request.GetAsync<RolPermission>(SessionObject.Token, "RolPermission/getbyid?RolPermissionId=" + RolPermissionId).Result;
            _rolPermission.PermissionId = PermissionId;
            _request.PostAsync(SessionObject.Token, "RolPermission/Update", _rolPermission);
            return RedirectToAction("RolPermissionList");

        }

    }
}
