using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebMarket.EF.Context;
using WebMarket.EF.Entities;
using WebMarket.DAL.Providers;
using WebMarket.DTO;
using WebMarket.Services;

namespace WebMarket.WebAPI.Controllers
{
    [Route("api/[controller]")]
    public class TestController : Controller
    {
        private ICategoryService categoryService;

        public TestController(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }

        // GET api/test
        [HttpGet]
        public async Task<List<Category>> Get()
        {
            var category = new Category
            {
                Id = 15,
                Description = "category_15",
                SubCategoryId = 14
            };
            var i = await categoryService.UpdateCategory(category);
            var list = await categoryService.GetAll();
            return list;
        }

        // GET api/test/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value" + id.ToString();
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/test/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/test/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
