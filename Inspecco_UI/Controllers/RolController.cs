using Inspecco_UI.Api;
using Inspecco_UI.Helpers;
using Inspecco_UI.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace Inspecco_UI.Controllers
{
    public class RolController : Controller
    {
        private readonly IRequest _request;
        private readonly ISessionHelper _sessionhelper;
        public RolController(IRequest request,
               ISessionHelper sessionhelper)
        {
            _request = request;
            _sessionhelper = sessionhelper;
        }
        public IActionResult RolList()
        {
            string SessionData = _sessionhelper.GetSessionModel("UserPermission");
            SeesionModel SessionObject = JsonConvert.DeserializeObject<SeesionModel>(SessionData);
            ViewData["PermissionList"] = SessionObject;
            var Rol = _request.GetAsync<List<Rol>>(SessionObject.Token, "Rol/getall").Result.ToList();
            return View(Rol);

        }

        public IActionResult RolCreate(int Id)
        {
            string SessionData = _sessionhelper.GetSessionModel("UserPermission");
            SeesionModel SessionObject = JsonConvert.DeserializeObject<SeesionModel>(SessionData);
            var Rol = _request.GetAsync<Rol>(SessionObject.Token, "Rol/getbyid?RolId=" + Id).Result;
            return View(Rol);
        }
        [HttpPost]
        public IActionResult RolCreate(Rol rol)
        {
            string SessionData = _sessionhelper.GetSessionModel("UserPermission");
            SeesionModel SessionObject = JsonConvert.DeserializeObject<SeesionModel>(SessionData);
            _request.PostAsync(SessionObject.Token, "Rol/add", rol);
            return RedirectToAction("RolList");
        }
        public IActionResult RolDelete(int Id)
        {
            string SessionData = _sessionhelper.GetSessionModel("UserPermission");
            SeesionModel SessionObject = JsonConvert.DeserializeObject<SeesionModel>(SessionData);
            var rol = _request.GetAsync<Rol>(SessionObject.Token, "Rol/getbyid?RolId=" + Id).Result;
            _request.PostAsync(SessionObject.Token, "Rol/delete", rol);
            return RedirectToAction("RolList");
        }
        public IActionResult RolEdit(int Id)
        {
            string SessionData = _sessionhelper.GetSessionModel("UserPermission");
            SeesionModel SessionObject = JsonConvert.DeserializeObject<SeesionModel>(SessionData);
            var Rol = _request.GetAsync<Rol>(SessionObject.Token, "Rol/getbyid?RolId=" + Id).Result;
            return View(Rol);

        }
        [HttpPost]
        public IActionResult RolEdit(Rol rol)
        {
            string SessionData = _sessionhelper.GetSessionModel("UserPermission");
            SeesionModel SessionObject = JsonConvert.DeserializeObject<SeesionModel>(SessionData);
            var _rol = _request.GetAsync<Rol>(SessionObject.Token, "Rol/getbyid?RolId=" + rol.RolId).Result;
            _rol.RolName = rol.RolName;
            _request.PostAsync(SessionObject.Token, "Rol/Update", _rol);
            return RedirectToAction("RolList");
        }

    }
}
