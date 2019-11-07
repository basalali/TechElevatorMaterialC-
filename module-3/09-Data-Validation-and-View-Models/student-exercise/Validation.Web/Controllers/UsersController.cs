using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Validation.Web.Models;


namespace Validation.Web.Controllers
{
    public class UsersController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View("Index");
        }


        // GET: User/Login
        // Return the empty login view
        [HttpGet]
        public ActionResult Login()
        {
            return View("Index");
        }

        // POST: User/Register
        // Validate the model and redirect to confirmation (if successful) or return the 
        // registration view (if validation fails)        

        [HttpPost]
        public ActionResult Login(LoginViewModel model)
        {
            // validate model
            if (!ModelState.IsValid)
            {
                return View("Index", model);
            }

            return RedirectToAction("Confirmation", "Users");
        }


        // GET: User/Register
        // Return the empty registration view

        [HttpGet]
        public ActionResult Registration()
        {
            return View("Registration");
        }


        // POST: User/Login  
        // Validate the model and redirect to login (if successful) or return the 
        // login view (if validation fails)

        [HttpPost]
        public ActionResult Register(RegistrationViewModel model)
        {
            // validate model
            if (!ModelState.IsValid)
            {
                return View("Registration", model);
            }

            return RedirectToAction("Confirmation", "Users");
        }


        // GET: User/Confirmation
        // Return the confirmation view
        public ActionResult Confirmation()
        {
            return View();
        }
    }
}