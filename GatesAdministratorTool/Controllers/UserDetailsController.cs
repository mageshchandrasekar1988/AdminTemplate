using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GatesAdministratorTool.Models;
using Microsoft.AspNetCore.Mvc;

namespace GatesAdministratorTool.Controllers
{
    public class UserDetailsController : Controller
    {
        public GatesAdminToolContext Context { get; }

        public UserDetailsController(GatesAdminToolContext context)
        {
            Context = context;
        }
        public IActionResult UserIndex()
        {
            List<UserDetails> users = Context.UserDetails.ToList();
            return View(users);
        }

        public IActionResult CreateNewUser()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateNewUser(UserDetails userDetails)
        {
            if (ModelState.IsValid)
            {
                List<UserDetails> users = Context.UserDetails.ToList();
                var duplicateCheck = from item in users where item.EmailId == userDetails.EmailId select item;
                if (duplicateCheck.Count() == 0) {
                    UserDetails User = new UserDetails
                    {
                        EmailId = userDetails.EmailId,
                        FirstName = userDetails.FirstName,
                        LastName = userDetails.LastName,
                        Role = userDetails.Role,
                        Status = userDetails.Status,
                        CreateDate = DateTime.Now

                    };
                    Context.Add(User);
                    Context.SaveChanges();
                    
                }
                return RedirectToAction("UserIndex");
            }
            return View();
        }
        [HttpGet]
        public IActionResult EditUser(int id)
        {
            UserDetails user = Context.UserDetails.Find(id);
            UserDetails updateUser = new UserDetails
            {
                UserId = user.UserId,
                EmailId = user.EmailId,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Role = user.Role,
                Status = user.Status
            };
            return View(updateUser);
        }

        [HttpPost]
        public IActionResult EditUser(UserDetails userDetails)
        {
            if (ModelState.IsValid)
            {
                UserDetails user = Context.UserDetails.Find(userDetails.UserId);
                user.FirstName = userDetails.FirstName;
                user.LastName = userDetails.LastName;
                user.Role = userDetails.Role;
                user.Status = userDetails.Status;

                Context.Update(user);
                Context.SaveChanges();
                return RedirectToAction("UserIndex");
            }
                return View();
        }
    }
}