using GatesAdministratorTool.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace GatesAdministratorTool.Controllers
{
    public class LoginController : Controller
    {
        public GatesAdminToolContext Context { get; }

        public LoginController(GatesAdminToolContext context)
        {
            Context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(UserDetails user)
        {
            UserDetails loginUserDetails = Context.UserDetails.Where(x => x.EmailId == user.EmailId && x.Password == user.Password).FirstOrDefault();
            if(loginUserDetails != null)
            {
                //Save session values
                HttpContext.Session.SetString("Email", loginUserDetails.EmailId);
                HttpContext.Session.SetString("Role", loginUserDetails.Role);
               return RedirectToAction("Index", "Home");
                
            }
            else
            {
                ViewBag.Messahe = "Invalid Credintal, please try again";
                return View("Index");
            }
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Login");
        }
    }
}