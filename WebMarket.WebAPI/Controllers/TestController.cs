using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebMarket.EF.Context;
using WebMarket.EF.Entities;
using WebMarket.DAL.Providers;
using WebMarket.DTO;

namespace WebMarket.WebAPI.Controllers
{
    [Route("api/[controller]")]
    public class TestController : Controller
    {
        private WebMarketDbContext context;

        private IProductProvider provider;
        private ICategoryProvider categoryProvider;

        public TestController(WebMarketDbContext context_, IProductProvider provider_, ICategoryProvider categoryProvider_)
        {
            this.context = context_;
            this.provider = provider_;
            this.categoryProvider = categoryProvider_;
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
            var category = new CategoryEntity
            {
                Description = "category_1",
                SubCategories = new List<CategoryEntity>()
                {
                    new CategoryEntity
                    {
                        Description = "SubCategory_1"
                    }
                }
            };
            //var i = await categoryProvider.Add(category);
            var list =  await categoryProvider.GetAll();
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
