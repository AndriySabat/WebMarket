using System.Collections.Generic;
using System.Threading.Tasks;
using WebMarket.EF.Entities;

namespace WebMarket.DAL.Providers
{
    /// <summary>
    /// IProducProvider interface
    /// </summary>
    public interface IProductProvider
    {
        Task<List<ProductEntity>> GetAllProducts();
    }
}
