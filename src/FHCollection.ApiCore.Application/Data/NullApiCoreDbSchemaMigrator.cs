using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace FHCollection.ApiCore.Data
{
    /* This is used if database provider does't define
     * IApiCoreDbSchemaMigrator implementation.
     */
    public class NullApiCoreDbSchemaMigrator : IApiCoreDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}