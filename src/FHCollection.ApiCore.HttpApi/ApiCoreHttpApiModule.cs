using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Modularity;

namespace FHCollection.ApiCore
{
    [DependsOn(
        typeof(ApiCoreApplicationContractsModule),
        typeof(AbpAspNetCoreMvcModule))]
    public class ApiCoreHttpApiModule : AbpModule
    {
        
    }
}
