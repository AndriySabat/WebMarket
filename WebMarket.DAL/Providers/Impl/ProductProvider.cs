using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebMarket.EF.Entities;
using WebMarket.DAL.UnitOfWork;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace WebMarket.DAL.Providers.Impl
{
    public class ProductProvider : IProductProvider
    {
        private IUnitOfWorkFactory unitOfWorkFactory = new UnitOfWorkFactory();
        public async Task<List<ProductEntity>> GetAllProducts()
        {
            using(var uow = unitOfWorkFactory.CreateUnitOfWork())
            {
                return await uow.ProductResitory.Query().Select(item => item).ToListAsync();
            }
        }
    }
}
