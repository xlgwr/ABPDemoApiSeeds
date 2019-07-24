using FHCollection.ApiCore.Localization;
using Volo.Abp.Application;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace FHCollection.ApiCore
{
    [DependsOn(
        typeof(ApiCoreDomainSharedModule),
        typeof(AbpDddApplicationModule)
        )]
    public class ApiCoreApplicationContractsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<VirtualFileSystemOptions>(options =>
            {
                options.FileSets.AddEmbedded<ApiCoreApplicationContractsModule>();
            });

            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Get<ApiCoreResource>()
                    .AddVirtualJson("/Localization/ApiCore/ApplicationContracts");
            });
        }
    }
}
