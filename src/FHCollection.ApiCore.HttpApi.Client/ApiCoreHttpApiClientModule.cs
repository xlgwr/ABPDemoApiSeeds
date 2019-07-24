using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;

namespace FHCollection.ApiCore
{
    [DependsOn(
        typeof(ApiCoreApplicationContractsModule),
        typeof(AbpHttpClientModule))]
    public class ApiCoreHttpApiClientModule : AbpModule
    {
        public const string RemoteServiceName = "ApiCore";

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddHttpClientProxies(
                typeof(ApiCoreApplicationContractsModule).Assembly,
                RemoteServiceName
            );
        }
    }
}
