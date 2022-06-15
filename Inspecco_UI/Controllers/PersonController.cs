using Inspecco_UI.Api;
using Inspecco_UI.Helpers;
using Inspecco_UI.Models;
using Inspecco_UI.Models.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Inspecco_UI.Controllers
{
    public class PersonController : Controller
    {
        private readonly IRequest _request;
        private readonly ISessionHelper _sessionhelper;
        public PersonController(IRequest request,
                    ISessionHelper sessionhelper)
        {
            _request = request;
            _sessionhelper = sessionhelper;
        }

        public IActionResult PersonList()
        {
            string SessionData = _sessionhelper.GetSessionModel("UserPermission");
            SeesionModel SessionObject = JsonConvert.DeserializeObject<SeesionModel>(SessionData);
            ViewData["PermissionList"] = SessionObject;
            var Person = _request.GetAsync<List<PersonDto>>(SessionObject.Token, "Person/GetListPersonDto").Result.ToList();
            return View(Person);

        }

        public IActionResult PersonCreate(int Id)
        {
            string SessionData = _sessionhelper.GetSessionModel("UserPermission");
            SeesionModel SessionObject = JsonConvert.DeserializeObject<SeesionModel>(SessionData);
            var Person = _request.GetAsync<Person>(SessionObject.Token, "Person/getbyid?PersonId=" + Id).Result;
            return View(Person);
        }
        [HttpPost]
        public IActionResult PersonCreate(Person person)
        {
            string SessionData = _sessionhelper.GetSessionModel("UserPermission");
            SeesionModel SessionObject = JsonConvert.DeserializeObject<SeesionModel>(SessionData);
            _request.PostAsync(SessionObject.Token, "Person/add", person);
            return RedirectToAction("PersonList");
        }
        public IActionResult PersonDelete(int Id)
        {
            string SessionData = _sessionhelper.GetSessionModel("UserPermission");
            SeesionModel SessionObject = JsonConvert.DeserializeObject<SeesionModel>(SessionData);
            var person = _request.GetAsync<Person>(SessionObject.Token, "Person/getbyid?PersonId=" + Id).Result;
            _request.PostAsync(SessionObject.Token, "Person/delete", person);
            return RedirectToAction("PersonList");
        }
        public IActionResult PersonEdit(int Id)
        {
            string SessionData = _sessionhelper.GetSessionModel("UserPermission");
            SeesionModel SessionObject = JsonConvert.DeserializeObject<SeesionModel>(SessionData);
            var Person = _request.GetAsync<Person>(SessionObject.Token, "Person/getbyid?PersonId=" + Id).Result;
            return View(Person);

        }
        [HttpPost]
        public IActionResult PersonEdit(Person person)
        {
            string SessionData = _sessionhelper.GetSessionModel("UserPermission");
            SeesionModel SessionObject = JsonConvert.DeserializeObject<SeesionModel>(SessionData);
            try
            {
                var _person = _request.GetAsync<Person>(SessionObject.Token, "Person/getbyid?PersonId=" + person.PersonId).Result;

                _person.PersonName = person.PersonName;
                _person.PersonSurname = person.PersonSurname;
                _person.Contact = person.Contact;
                _request.PostAsync(SessionObject.Token, "Person/update", _person);
                return RedirectToAction("PersonList");
            }
            catch (Exception ex)
            {
                return RedirectToAction("PersonList");
            }

        }
        public IActionResult Invite(int Id)
        {

            string SessionData = _sessionhelper.GetSessionModel("UserPermission");
            SeesionModel SessionObject = JsonConvert.DeserializeObject<SeesionModel>(SessionData);
            var User = _request.GetAsync<Person>(SessionObject.Token, "Person/getbyid?PersonId=" + Id).Result;
            var Company = _request.GetAsync<List<Company>>(SessionObject.Token, "Company/getall").Result.ToList();
            ViewBag.Company = Company;
            return View(User);
        }
        [HttpPost]
        public IActionResult Invite(Person person, int PersonId)
        {
            string SessionData = _sessionhelper.GetSessionModel("UserPermission");
            SeesionModel SessionObject = JsonConvert.DeserializeObject<SeesionModel>(SessionData);
            var _person = _request.GetAsync<Person>(SessionObject.Token, "Person/getbyid?PersonId=" + person.PersonId).Result;
            _person.CompanyId = person.CompanyId;
            _request.PostAsync(SessionObject.Token, "Person/update", _person);
            return RedirectToAction("PersonList");
        }
    }
}
