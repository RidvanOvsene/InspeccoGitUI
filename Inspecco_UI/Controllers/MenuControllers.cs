using Inspecco_UI.Api;
using Inspecco_UI.Helpers;
using Inspecco_UI.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace Inspecco_UI.Controllers
{
    public class MenuController : Controller
    {
        private readonly IRequest _request;
        private readonly ISessionHelper _sessionhelper;
 
        public MenuController(IRequest request,
                ISessionHelper sessionhelper)
        {
            _request = request;
            _sessionhelper = sessionhelper;

        }
        public IActionResult MenuList()
        {
            string SessionData = _sessionhelper.GetSessionModel("UserPermission");
            SeesionModel SessionObject = JsonConvert.DeserializeObject<SeesionModel>(SessionData);
            ViewData["PermissionList"] = SessionObject;
            var Menu = _request.GetAsync<List<Menus>>(SessionObject.Token, "Menu/getall").Result.ToList();
            return View(Menu);

        }

        public IActionResult MenuCreate(int Id)
        {
            string SessionData = _sessionhelper.GetSessionModel("UserPermission");
            SeesionModel SessionObject = JsonConvert.DeserializeObject<SeesionModel>(SessionData);
            var Menu = _request.GetAsync<Menus>(SessionObject.Token, "Menu/getbyid?MenuId=" + Id).Result;
                                    return View(Menu);
        }
        [HttpPost]
        public IActionResult MenuCreate(Menus menu)
        {
            string SessionData = _sessionhelper.GetSessionModel("UserPermission");
            SeesionModel SessionObject = JsonConvert.DeserializeObject<SeesionModel>(SessionData);
            _request.PostAsync(SessionObject.Token, "Menu/add", menu);
            return RedirectToAction("MenuList");
        }
        public IActionResult MenuDelete(int Id)
        {
            string SessionData = _sessionhelper.GetSessionModel("UserPermission");
            SeesionModel SessionObject = JsonConvert.DeserializeObject<SeesionModel>(SessionData);
            var menu = _request.GetAsync<Menus>(SessionObject.Token, "Menu/getbyid?MenuId=" + Id).Result;
            _request.PostAsync(SessionObject.Token, "Menu/delete", menu);
            return RedirectToAction("MenuList");
        }
        public IActionResult MenuEdit(int Id)
        {
            string SessionData = _sessionhelper.GetSessionModel("UserPermission");
            SeesionModel SessionObject = JsonConvert.DeserializeObject<SeesionModel>(SessionData);
            var Menu = _request.GetAsync<Menus>(SessionObject.Token, "Menu/getbyid?MenuId=" + Id).Result;
                        return View(Menu);
                    }
        [HttpPost]
        public IActionResult MenuEdit(Menus menu)
        {
            string SessionData = _sessionhelper.GetSessionModel("UserPermission");
            SeesionModel SessionObject = JsonConvert.DeserializeObject<SeesionModel>(SessionData);
            var _menu = _request.GetAsync<Menus>(SessionObject.Token, "Menu/getbyid?MenuId=" + menu.MenuId).Result;
            _menu.MenuName = menu.MenuName;
            _menu.MenuUrl = menu.MenuUrl;
            _request.PostAsync(SessionObject.Token, "Menu/Update", _menu);
            return RedirectToAction("MenuList");
        }

    }
}
