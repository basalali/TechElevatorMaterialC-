using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GETForms.Web.DAL;
using GETForms.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace GETForms.Web.Controllers
{
    public class FilmsController : Controller
    {
        private string connectionString = "Data Source=.\\sqlexpress;Initial Catalog=dvdstore;Integrated Security=True";
        /// <summary>
        /// The request to display an empty search page.
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }


        public IActionResult GetForm()
        {
            Film film = new Film();
            return View(film);
        }
        /// <summary>
        /// Receives the search result request and goes to th database looking for the information.
        /// </summary>
        /// <param name="request">A request model that contains the search parameters.</param>
        /// <returns></returns>
        public ActionResult SearchResult(Film film)
        {
            FilmDAO dao = new FilmDAO(connectionString);
            IList<Film> films = dao.GetFilmsBetween(film.Genre, film.MinLength, film.MaxLength);

            return View(films);
        }
    }
}