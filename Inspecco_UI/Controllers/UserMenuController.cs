using Inspecco_UI.Api;
using Inspecco_UI.Helpers;
using Inspecco_UI.Models;
using Inspecco_UI.Models.Dtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace Inspecco_UI.Controllers
{
    public class UserMenuController : Controller
    {
        private readonly IRequest _request;
        private readonly ISessionHelper _sessionhelper;
        public UserMenuController(IRequest request,
                    ISessionHelper sessionhelper)
        {
            _request = request;
            _sessionhelper = sessionhelper;
        }
        public IActionResult UserMenuList()
        {
            string SessionData = _sessionhelper.GetSessionModel("UserPermission");
            SeesionModel SessionObject = JsonConvert.DeserializeObject<SeesionModel>(SessionData);
            ViewData["PermissionList"] = SessionObject;
            var UserMenuDto = _request.GetAsync<List<UserMenuDto>>(SessionObject.Token, "UserMenu/GetListUserMenu").Result.ToList();
            return View(UserMenuDto);

        }

        public IActionResult UserMenuCreate(int Id)
        {
            string SessionData = _sessionhelper.GetSessionModel("UserPermission");
            SeesionModel SessionObject = JsonConvert.DeserializeObject<SeesionModel>(SessionData);
            var UserMenu = _request.GetAsync<UserMenu>(SessionObject.Token, "UserMenu/getbyid?UserMenuId=" + Id).Result;
            var Menu = _request.GetAsync<List<Menus>>(SessionObject.Token, "Menu/getall").Result.ToList();
            var User = _request.GetAsync<List<Users>>(SessionObject.Token, "User/getall").Result.ToList();
            ViewBag.User = User;
            ViewBag.Menu = Menu;

            return View(UserMenu);
        }
        [HttpPost]
        public IActionResult UserMenuCreate(UserMenu userMenu)
        {
            string SessionData = _sessionhelper.GetSessionModel("UserPermission");
            SeesionModel SessionObject = JsonConvert.DeserializeObject<SeesionModel>(SessionData);
            _request.PostAsync(SessionObject.Token, "UserMenu/add", userMenu);
            return RedirectToAction("UserMenuList");
        }
        public IActionResult UserMenuDelete(int Id)
        {
            string SessionData = _sessionhelper.GetSessionModel("UserPermission");
            SeesionModel SessionObject = JsonConvert.DeserializeObject<SeesionModel>(SessionData);
            var userMenu = _request.GetAsync<UserMenu>(SessionObject.Token, "UserMenu/getbyid?UserMenuId=" + Id).Result;
            _request.PostAsync(SessionObject.Token, "UserMenu/delete", userMenu);
            return RedirectToAction("UserMenuList");
        }
        public IActionResult UserMenuEdit(int Id)
        {
            string SessionData = _sessionhelper.GetSessionModel("UserPermission");
            SeesionModel SessionObject = JsonConvert.DeserializeObject<SeesionModel>(SessionData);
            var UserMenu = _request.GetAsync<List<UserMenuDto>>(SessionObject.Token, "UserMenu/GetListUserMenu").Result.FirstOrDefault(x => x.UserMenuId == Id);
            var User = _request.GetAsync<Users>(SessionObject.Token, "User/getbyid?UserId=" + Id).Result;
            var Menu = _request.GetAsync<List<Menus>>(SessionObject.Token, "Menu/getall").Result.ToList();
            ViewBag.SelectedMenu = UserMenu;
            ViewBag.User = User;
            ViewBag.Menu = Menu;

            return View();
        }
        [HttpPost]
        public IActionResult UserMenuEdit(int MenuId, int UserMenuId)
        {
            string SessionData = _sessionhelper.GetSessionModel("UserPermission");
            SeesionModel SessionObject = JsonConvert.DeserializeObject<SeesionModel>(SessionData);
            var _userMenu = _request.GetAsync<UserMenu>(SessionObject.Token, "UserMenu/getbyid?UserMenuId=" + UserMenuId).Result;
            _userMenu.MenuId = MenuId;
            _request.PostAsync(SessionObject.Token, "UserMenu/Update", _userMenu);
            return RedirectToAction("UserMenuList");

        }

    }
}
