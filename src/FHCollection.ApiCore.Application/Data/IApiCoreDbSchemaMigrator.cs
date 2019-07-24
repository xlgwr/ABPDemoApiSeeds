using System.Threading.Tasks;

namespace FHCollection.ApiCore.Data
{
    public interface IApiCoreDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
