using WebMarket.Common;
using Microsoft.Extensions.DependencyInjection;
using WebMarket.Services.Impl;

namespace WebMarket.Services.Common
{
    public class ServicesDependencyConfigurator : IDependencyConfigurator
    {
        public void Configure(IServiceCollection services)
        {
            services.AddTransient<ICategoryService, CategoryService>();
        }
    }
}
