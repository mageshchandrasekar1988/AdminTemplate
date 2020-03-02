using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GatesAdministratorTool.Controllers
{
    public class ApplicationController : Controller
    {
        public IActionResult ApplicationIndex()
        {
            return View();
        }

        public IActionResult CreateNewApplication()
        {
            return View();
        }
        public IActionResult EditApplication()
        {
            return View();
        }
    }
}