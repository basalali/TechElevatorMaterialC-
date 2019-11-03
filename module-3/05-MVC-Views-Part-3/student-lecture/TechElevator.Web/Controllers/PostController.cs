using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TechElevator.Web.DAL;
using TechElevator.Web.Models;

namespace TechElevator.Web.Controllers
{
    public class PostController : Controller
    {
        private string connectionString = @"Data Source=.\sqlexpress;Initial Catalog=TEgram;Integrated Security=True";


        public IActionResult List()
        {
            PostDAO dao = new PostDAO(connectionString);
            List<Post> posts = dao.GetPosts();

            return View(posts);              
        }

        public IActionResult Details(int id)
        {
            PostDAO dao = new PostDAO(connectionString);
            Post post = dao.GetPost(id);

            return View(post);
        }
    }
}