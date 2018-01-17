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
        private WebMarketDbContext context;

        private IProductProvider provider;
        private ICategoryService categoryService;

        public TestController(WebMarketDbContext context_, IProductProvider provider_, ICategoryService categoryService)
        {
            this.context = context_;
            this.provider = provider_;
            this.categoryService = categoryService;
        }

        // GET api/values
        //[HttpGet]
        //public async Task<List<ProductEntity>> Get()
        //{
        //    return await provider.GetAllProducts();
        //}
        [HttpGet]
        public async Task<List<Category>> Get()
        {
            var category = new Category
            {
                Description = "category_2",
                SubCategoryId = 15
            };
            var i = await categoryService.AddCategories(new List<Category>() { category });
            var list = await categoryService.GetAll();
            return list;
        }

        // GET api/values/5
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

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
