using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;

namespace FHCollection.ApiCore
{
    [DependsOn(
        typeof(ApiCoreDomainModule),
        typeof(ApiCoreApplicationContractsModule),
        typeof(AbpAutoMapperModule)
        )]
    public class ApiCoreApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpAutoMapperOptions>(options =>
            {
                /* Using `true` for the `validate` parameter to
                 * validate the profile on application startup.
                 * See http://docs.automapper.org/en/stable/Configuration-validation.html for more info
                 * about the configuration validation. */
                options.AddProfile<ApiCoreApplicationAutoMapperProfile>();//validate: true
            });
        }
    }
}
