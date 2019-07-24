using FHCollection.ApiCore.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace FHCollection.ApiCore.Authorization
{
    public class ApiCorePermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            //var moduleGroup = context.AddGroup(ApiCorePermissions.GroupName, L("Permission:ApiCore"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<ApiCoreResource>(name);
        }
    }
}