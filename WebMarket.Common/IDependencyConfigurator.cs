using Microsoft.Extensions.DependencyInjection;

namespace WebMarket.Common
{
    public interface IDependencyConfigurator
    {
        void Configure(IServiceCollection services);
    }
}