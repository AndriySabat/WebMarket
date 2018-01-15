using Microsoft.Extensions.DependencyInjection;
using WebMarket.DAL.UnitOfWork;
using WebMarket.DAL.Providers;
using WebMarket.DAL.Providers.Impl;
using WebMarket.Common;


namespace WebMarket.DAL.Common
{
    /// <summary>
    /// Class DALDependencyConfigurator.
    /// </summary>
    public class DALDependencyConfigurator : IDependencyConfigurator
    {
        /// <summary>
        /// Makes the dependency.
        /// </summary>
        public void Configure(IServiceCollection services)
        {
            services.AddTransient<IProductProvider, ProductProvider>();
            services.AddTransient<ICategoryProvider, CategoryProvider>();

            services.AddTransient<IUnitOfWork, WebMarketUnitOfWork>();
            services.AddTransient<IUnitOfWorkFactory, UnitOfWorkFactory>();
        }
    }
}
