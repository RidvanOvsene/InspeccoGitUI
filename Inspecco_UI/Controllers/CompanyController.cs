using Inspecco_UI.Api;
using Inspecco_UI.Helpers;
using Inspecco_UI.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace Inspecco_UI.Controllers
{
    public class CompanyController : Controller
    {
        private readonly IRequest _request;
        private readonly ISessionHelper _sessionhelper;
        public CompanyController(IRequest request,
                                 ISessionHelper sessionhelper)
        {
            _request = request;
            _sessionhelper = sessionhelper;
        }
        public IActionResult CompanyList()
        {
            string SessionData = _sessionhelper.GetSessionModel("UserPermission");
            SeesionModel SessionObject = JsonConvert.DeserializeObject<SeesionModel>(SessionData);
            ViewData["PermissionList"] = SessionObject;
            var Company = _request.GetAsync<List<Company>>(SessionObject.Token, "Company/getall").Result.ToList();

            return View(Company);
        }

        public IActionResult CompanyCreate(int Id)
        {
            string SessionData = _sessionhelper.GetSessionModel("UserPermission");
            SeesionModel SessionObject = JsonConvert.DeserializeObject<SeesionModel>(SessionData);
            var Company = _request.GetAsync<Company>(SessionObject.Token, "Company/getbyid?CompanyId=" + Id).Result;
            return View(Company);
        }
        [HttpPost]
        public IActionResult CompanyCreate(Company company)
        {
            string SessionData = _sessionhelper.GetSessionModel("UserPermission");
            SeesionModel SessionObject = JsonConvert.DeserializeObject<SeesionModel>(SessionData);
            _request.PostAsync(SessionObject.Token, "Company/add", company);
            return RedirectToAction("CompanyList");
        }
        public IActionResult CompanyDelete(int Id)
        {
            string SessionData = _sessionhelper.GetSessionModel("UserPermission");
            SeesionModel SessionObject = JsonConvert.DeserializeObject<SeesionModel>(SessionData);
            var company = _request.GetAsync<Company>(SessionObject.Token, "Company/getbyid?CompanyId=" + Id).Result;
            _request.PostAsync(SessionObject.Token, "Company/delete", company);
            return RedirectToAction("CompanyList");
        }
        public IActionResult CompanyEdit(int Id)
        {
            string SessionData = _sessionhelper.GetSessionModel("UserPermission");
            SeesionModel SessionObject = JsonConvert.DeserializeObject<SeesionModel>(SessionData);
            var Company = _request.GetAsync<Company>(SessionObject.Token, "Company/getbyid?CompanyId=" + Id).Result;
                        return View(Company);

        }
        [HttpPost]
        public IActionResult CompanyEdit(Company company)
        {
            string SessionData = _sessionhelper.GetSessionModel("UserPermission");
            SeesionModel SessionObject = JsonConvert.DeserializeObject<SeesionModel>(SessionData);
            var _company = _request.GetAsync<Company>(SessionObject.Token, "Company/getbyid?CompanyId=" + company.CompanyId).Result;
            _company.CompanyName = company.CompanyName;
            _company.CompanyDescription = company.CompanyDescription;
            _request.PostAsync(SessionObject.Token, "Company/Update", _company);
            return RedirectToAction("CompanyList");

        }
    }
}
