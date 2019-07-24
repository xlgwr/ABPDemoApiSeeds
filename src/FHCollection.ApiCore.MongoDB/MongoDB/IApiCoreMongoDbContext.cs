using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace FHCollection.ApiCore.MongoDB
{
    [ConnectionStringName("ApiCore")]
    public interface IApiCoreMongoDbContext : IAbpMongoDbContext
    {
        /* Define mongo collections here. Example:
         * IMongoCollection<Question> Questions { get; }
         */
    }
}
