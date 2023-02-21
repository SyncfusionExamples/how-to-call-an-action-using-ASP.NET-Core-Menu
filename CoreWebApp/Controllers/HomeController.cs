using CoreWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CoreWebApp.Controllers
{
    
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult GetRedirectUrl([FromBody] MenuItem value)
        {
            return Json(new { redirectToUrl = Url.Action(value.Text, "Home", new { Id = value.Id }) });
        }

        public IActionResult Open(MenuItem item)
        {
            return View(item);
        }
        public IActionResult Save(MenuItem item)
        {
            return View(item);
        }
        public IActionResult Exit(MenuItem item)
        {
            return View(item);
        }
    }
    
}
