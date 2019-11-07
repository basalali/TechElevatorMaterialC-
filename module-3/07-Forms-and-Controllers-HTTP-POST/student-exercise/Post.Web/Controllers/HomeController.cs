using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Post.Web.DAL;
using Post.Web.Models;

namespace Post.Web.Controllers
{
    public class HomeController : Controller
    {

        private IReviewDAO reviewPostDAO;
        //Inject controller
        public HomeController(IReviewDAO reviewPostDAO)
        {

            this.reviewPostDAO = reviewPostDAO;
        }

        public IActionResult Index()
        {
            IList<Review> reviews = reviewPostDAO.GetAllReviews();

            return View(reviews);
        }
        [HttpGet]
        public IActionResult NewPost()
        {
            Review review = new Review();
            return View(review);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult NewPost(Review review)
        {
            reviewPostDAO.SaveReview(review);

            return RedirectToAction("Index");
        }






        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
