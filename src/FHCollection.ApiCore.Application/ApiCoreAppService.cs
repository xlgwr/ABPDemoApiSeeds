using FHCollection.ApiCore.Localization;
using Volo.Abp.Application.Services;

namespace FHCollection.ApiCore
{
    public abstract class ApiCoreAppService : ApplicationService
    {
        protected ApiCoreAppService()
        {
            LocalizationResource = typeof(ApiCoreResource);
        }
    }
}
