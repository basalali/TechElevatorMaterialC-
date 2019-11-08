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
            return View();
        }

        [HttpPost]
        public IActionResult Register(Register register)
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(Login login)
        {
            return View();
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