using Volo.Abp.Modularity;

namespace FHCollection.ApiCore
{
    [DependsOn(
        typeof(ApiCoreDomainSharedModule)
        )]
    public class ApiCoreDomainModule : AbpModule
    {

    }
}
