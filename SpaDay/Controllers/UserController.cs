using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SpaDay.Models;

namespace SpaDay.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("/user/add")]
        public IActionResult Add()
        {
            ViewBag.error = false;
            return View("Add");
        }

        [HttpPost]
        [Route("/user")]
        public IActionResult SubmitAddUserForm(User newUser, string verify)
        {
            // add form submission handling code here
            if (newUser.Password.Equals(verify)) {
                ViewBag.user = newUser;
                return View("Index");
            } else
            {
                ViewBag.error = true;
                ViewBag.username = newUser.UserName;
                ViewBag.email = newUser.Email;
                return View("Add");
            }
        }
    }
}
