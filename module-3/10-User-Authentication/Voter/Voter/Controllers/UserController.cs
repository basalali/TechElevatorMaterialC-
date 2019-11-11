using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Voter.DAL.Interfaces;
using Voter.Models;

namespace Voter.Controllers
{
    public class UserController : HomeController
    {
        IUserDao userDao;

        public UserController(IUserDao userDao)
        {
            this.userDao = userDao;
        }


        public IActionResult Register()
        {
            Register register = new Register();
            return View(register);
        }

        [HttpPost]
        public IActionResult Register(Register register)
        {
            if(!ModelState.IsValid)
            {
                return View(register);
            }

           User user = userDao.SaveUser(register.Username, register.Password, 0);
            
            if(user is null)

            { // to do: add error message
                return RedirectToAction("Error", "Home");
            }

            return RedirectToAction("Login");
        }

        public IActionResult Login()
        {
            Login login = new Login();
            return View();
        }

        [HttpPost]
        public IActionResult Login(Login login)
        {
            if (!ModelState.IsValid)
            {
                return View(login);
            }

            bool ok = userDao.IsUsernameAndPasswordValid(login.Username, login.Password);

            if(!ok)
            {

                return RedirectToAction("Login");
            }

            //if they are successful; mark them as logged in
            User user = userDao.GetUserByUserName(login.Username);

            base.LogUserIn(user);


            return RedirectToAction("Index", "Home");
        }

        public IActionResult Logout()
        {
            return View();
        }

        public IActionResult List()
        {
            //for admin only
            return View();
        }
    }
}