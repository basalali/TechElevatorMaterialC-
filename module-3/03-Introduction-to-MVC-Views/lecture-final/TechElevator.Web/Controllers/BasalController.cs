using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TechElevator.Web.Controllers
{
    public class BasalController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}