using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShoppingListAPI.Models;
using ShoppingListAPI.Services;

namespace ShoppingListAPI.Controllers
{
    [Route("api/groceries")]
    [ApiController]
    public class ShoppingLIstController : ControllerBase
    {
        private readonly IDataAccessLayer<Item> dal;

        public ShoppingLIstController(IDataAccessLayer<Item> dataAccessLayer) {
            dal = dataAccessLayer;
        }

        [HttpGet]
        public List<Item> GetAll()
        {
            return null;
        }

        [HttpGet("{id}", Name = "GetItem")]
        public ActionResult<Item> GetItem(int id)
        {

            return NotFound();
        }

        [HttpPost]
        public ActionResult Create([FromBody] Item item)
        {
            return NotFound(;)
        }

        [HttpPut("{id}")]
        public ActionResult Update(int id, Item updatedItem)
        { 
                return NotFound();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
                return NotFound();
        }
    }
}