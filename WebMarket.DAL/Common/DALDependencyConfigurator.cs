using Microsoft.Extensions.DependencyInjection;
using WebMarket.DAL.UnitOfWork;
using WebMarket.DAL.Providers;
using WebMarket.DAL.Providers.Impl;

namespace WebMarket.DAL.Common
{
    /// <summary>
    /// Class DALDependencyConfigurator.
    /// </summary>
    public class DALDependencyConfigurator
    {
        /// <summary>
        /// Makes the dependency.
        /// </summary>
        public void Configure(IServiceCollection services)
        {
            services.AddTransient<IProductProvider, ProductProvider>();

            services.AddTransient<IUnitOfWork, WebMarketUnitOfWork>();
            services.AddTransient<IUnitOfWorkFactory, UnitOfWorkFactory>();
        }
    }
}
