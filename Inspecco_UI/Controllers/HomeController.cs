using Inspecco_UI.Api;
using Inspecco_UI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Inspecco_UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IRequest _request;
        public HomeController(ILogger<HomeController> logger,
                              IRequest request)
        {
            _logger = logger;
            _request = request;
        }

        public IActionResult Index()
        {
            var Companies = _request.GetAsync<List<Company>>("", "Company/getall").Result.ToList();
            return View(Companies);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
