using Inspecco_UI.Api;
using Inspecco_UI.Helpers;
using Inspecco_UI.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using Inspecco_UI.Models.Dtos;

namespace Inspecco_UI.Controllers
{
    public class UserController : Controller
    {
        private readonly IRequest _request;
        private readonly ISessionHelper _sessionhelper;

        public UserController(IRequest request,
                  ISessionHelper sessionhelper)
        {
            _request = request;
            _sessionhelper = sessionhelper;
        }
        public IActionResult UserList()
        {
            string SessionData = _sessionhelper.GetSessionModel("UserPermission");
            SeesionModel SessionObject = JsonConvert.DeserializeObject<SeesionModel>(SessionData);
            ViewData["PermissionList"] = SessionObject;
            var UserMenuDto = _request.GetAsync<List<UserDto>>(SessionObject.Token, "User/GetListUserRol").Result.ToList();
            return View(UserMenuDto);
            var User = _request.GetAsync<List<Users>>(SessionObject.Token, "User/getall").Result.ToList();
            return View(User);

        }

        public IActionResult UserCreate(int Id)
        {
            string SessionData = _sessionhelper.GetSessionModel("UserPermission");
            SeesionModel SessionObject = JsonConvert.DeserializeObject<SeesionModel>(SessionData);
            var User = _request.GetAsync<Users>(SessionObject.Token, "User/getbyid?UserId=" + Id).Result;
            var Rol = _request.GetAsync<List<Rol>>(SessionObject.Token, "Rol/getall").Result.ToList();
            ViewBag.Rol= Rol;
            return View(User);
        }
        [HttpPost]
        public IActionResult UserCreate(Users user)
        {
            string SessionData = _sessionhelper.GetSessionModel("UserPermission");
            SeesionModel SessionObject = JsonConvert.DeserializeObject<SeesionModel>(SessionData);
            _request.PostAsync(SessionObject.Token, "User/add", user);
            return RedirectToAction("UserList");
        }
        public IActionResult UserDelete(int Id)
        {
            string SessionData = _sessionhelper.GetSessionModel("UserPermission");
            SeesionModel SessionObject = JsonConvert.DeserializeObject<SeesionModel>(SessionData);
            var user = _request.GetAsync<Users>(SessionObject.Token, "User/getbyid?UserId=" + Id).Result;
            _request.PostAsync(SessionObject.Token, "User/delete", user);
            return RedirectToAction("UserList");
        }
        public IActionResult UserEdit(int Id)
        {
            string SessionData = _sessionhelper.GetSessionModel("UserPermission");
            SeesionModel SessionObject = JsonConvert.DeserializeObject<SeesionModel>(SessionData);
            var UserDto = _request.GetAsync<List<UserDto>>(SessionObject.Token, "User/GetListUserRol").Result.FirstOrDefault(x=>x.UserId==Id);
            var User = _request.GetAsync<Users>(SessionObject.Token, "User/getbyid?UserId=" + Id).Result;
            var Rol = _request.GetAsync<List<Rol>>(SessionObject.Token, "Rol/getall").Result.ToList();
            ViewBag.Rol = Rol;
            ViewBag.SelectedUser = UserDto;
            return View(UserDto);

        }
        [HttpPost]
        public IActionResult UserEdit(Users user,int RolId)
        {
            string SessionData = _sessionhelper.GetSessionModel("UserPermission");
            SeesionModel SessionObject = JsonConvert.DeserializeObject<SeesionModel>(SessionData);
            var _user = _request.GetAsync<Users>(SessionObject.Token, "User/getbyid?UserId=" + user.UserId).Result;
            _user.NameSurname = user.NameSurname;
            _user.UserName = user.UserName;
            _user.Contact = user.Contact;
            _request.PostAsync(SessionObject.Token, "User/Update", _user);
            return RedirectToAction("UserList");

        }
        public IActionResult Invite(int Id)
        {
            string SessionData = _sessionhelper.GetSessionModel("UserPermission");
            SeesionModel SessionObject = JsonConvert.DeserializeObject<SeesionModel>(SessionData);
            var User = _request.GetAsync<Users>(SessionObject.Token, "User/getbyid?UserId=" + Id).Result;
            var Company = _request.GetAsync<List<Company>>(SessionObject.Token, "Company/getall").Result.ToList();
            ViewBag.SelectedUser = User;
            ViewBag.Company = Company;
            return View(User);
        }
 

    }
}
