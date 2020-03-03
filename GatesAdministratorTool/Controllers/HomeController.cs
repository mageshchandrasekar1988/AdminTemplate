using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GatesAdministratorTool.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("Email") != null)
            {
                ViewBag.Role = HttpContext.Session.GetString("Role");
                return View();
            }
            return RedirectToAction("Login", "Index");
            
        }
    }
}