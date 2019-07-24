using Volo.Abp.Reflection;

namespace FHCollection.ApiCore.Authorization
{
    public class ApiCorePermissions
    {
        public const string GroupName = "ApiCore";

        public static string[] GetAll()
        {
            return ReflectionHelper.GetPublicConstantsRecursively(typeof(ApiCorePermissions));
        }
    }
}