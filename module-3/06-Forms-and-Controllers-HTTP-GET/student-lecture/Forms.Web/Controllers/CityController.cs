using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Forms.Web.DAL;
using Forms.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace Forms.Web.Controllers
{
    public class CityController : Controller
    {
        string connectionString = "Data Source=.\\sqlexpress;Initial Catalog=World;Integrated Security=True";
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetForm()
        {
            CityView cityView = new CityView();      
            return View(cityView);
        }

        //public IActionResult GetCities(string countrycode)
        //{
        //    CitySqlDAO dao = new CitySqlDAO(connectionString);
        //    IList<City> cities = dao.GetCities(countrycode);


        //    return View(cities);
        //}

        public IActionResult GetCities(CityView city)
        {
            CitySqlDAO dao = new CitySqlDAO(connectionString);
            IList<City> cities = dao.GetCities(city.CountryCode, city.District);


            return View(cities);
        }
    }
}