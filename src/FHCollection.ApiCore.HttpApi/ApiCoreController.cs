using FHCollection.ApiCore.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace FHCollection.ApiCore
{
    public abstract class ApiCoreController : AbpController
    {
        protected ApiCoreController()
        {
            LocalizationResource = typeof(ApiCoreResource);
        }
    }
}
