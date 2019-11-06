using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GETForms.Web.DAL;
using GETForms.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace GETForms.Web.Controllers
{
    public class CustomersController : Controller
    {
        private string connectionString = "Data Source=.\\sqlexpress;Initial Catalog=dvdstore;Integrated Security=True";

        public ActionResult Index()
        {
            return View();
        }

        public IActionResult GetForm()
        {
            Customer cust = new Customer();
            return View(cust);
        }

        public ActionResult SearchResult(Customer cust)
        {
            CustomerDAO dao = new CustomerDAO(connectionString);
            IList<Customer> customers = dao.SearchForCustomers(cust.FirstName, cust.SortBy);

            return View(customers);
        }

    }
}