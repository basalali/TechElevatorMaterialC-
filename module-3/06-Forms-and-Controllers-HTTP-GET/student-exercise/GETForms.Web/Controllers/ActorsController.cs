using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GETForms.Web.DAL;
using GETForms.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace GETForms.Web.Controllers
{
    public class ActorsController : Controller
    {
        private string connectionString = "Data Source=.\\sqlexpress;Initial Catalog=dvdstore;Integrated Security=True";
        /// <summary>
        /// The request to display an empty search page.
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetForm()
        {
            Actor actor = new Actor();
            return View(actor);
        }
        /// <summary>
        /// The request to display search results.
        /// </summary>
        /// <param name="request">A request model that contains the search parameters.</param>
        /// <returns></returns>
        public IActionResult SearchResult(string LastName)
        {
           ActorDAO dao = new ActorDAO(connectionString);
           IList<Actor> actors = dao.FindActors(LastName);

            return View(actors);
        }
    }
}