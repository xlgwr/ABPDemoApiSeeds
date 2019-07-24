using FHCollection.ApiCore.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace FHCollection.ApiCore.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(ApiCoreEntityFrameworkCoreDbMigrationsModule),
        typeof(ApiCoreApplicationContractsModule)
        )]
    public class ApiCoreDbMigratorModule : AbpModule
    {
        
    }
}
