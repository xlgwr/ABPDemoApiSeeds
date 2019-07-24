using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace FHCollection.ApiCore.EntityFrameworkCore
{
    [DependsOn(
        typeof(ApiCoreEntityFrameworkCoreModule)
        )]
    public class ApiCoreEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<ApiCoreMigrationsDbContext>();
        }
    }
}
