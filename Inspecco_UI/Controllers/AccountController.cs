using Inspecco_UI.Api;
using Inspecco_UI.Helpers;
using Inspecco_UI.Models;
using Inspecco_UI.Models.Dtos;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;


namespace Inspecco_UI.Controllers
{
    public class AccountController : Controller
    {
        private readonly IRequest _request;
        private readonly ISessionHelper _sessionhelper;
        public AccountController(ILogger<Users> logger,
                                 IRequest request,
                                 ISessionHelper sessionhelper)
        {
            _request = request;
            _sessionhelper = sessionhelper;
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> Login(Users model)
        {
            SeesionModel _sessionModel = new SeesionModel();
            var User = _request.GetAsync<LoginDto>(_sessionModel.Token, "Auth/Login?UserName=" + model.UserName + "&Password=" + model.Password).Result;
            if (User != null)
            {
                var Role = _request.GetAsync<Rol>(User.Token, "Rol/getbyid?RolId=" + User.RolId).Result;
                var UserRole = new UserRole();
                if (Role != null)
                {
                    UserRole.RoleName = Role.RolName;
                    UserRole.RoleId = Role.RolId;
                    var PermissionList = new List<RolePermission>();

                    var PermissionData = _request.GetAsync<List<RolPermissionDto>>(User.Token, "RolPermission/GetByRolId?RolId=" + User.RolId).Result;
                    foreach (var item in PermissionData)
                    {
                        var Permission = new RolePermission();
                        Permission.Permissiond = (int)item.PermissionId;
                        Permission.PermissionName = item.PermissionName;
                        PermissionList.Add(Permission);
                    }
                    UserRole.Permission = PermissionList;
                    _sessionModel.Role = UserRole;
                }
                _sessionModel.Token = User.Token;
                _sessionModel.UserId = User.UserId;
                _sessionModel.UserFullName = User.NameSurname;
                _sessionhelper.SetSeesionModel(_sessionModel, "UserPermission");
                return RedirectToAction("PersonList", "Person");
            }
            else
            {
                ViewBag.Error = "Lütfen kullanıcı adınızı ve şifrenizi kontrol ediniz";
                return View();
            }
        }
        [HttpGet]
        public ActionResult Logout()
        {
            return RedirectToAction("Login", "Account");
        }
    }
}

