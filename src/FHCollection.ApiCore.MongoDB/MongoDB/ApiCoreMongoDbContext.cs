using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace FHCollection.ApiCore.MongoDB
{
    [ConnectionStringName("ApiCore")]
    public class ApiCoreMongoDbContext : AbpMongoDbContext, IApiCoreMongoDbContext
    {
        public static string CollectionPrefix { get; set; } = ApiCoreConsts.DefaultDbTablePrefix;

        /* Add mongo collections here. Example:
         * public IMongoCollection<Question> Questions => Collection<Question>();
         */

        protected override void CreateModel(IMongoModelBuilder modelBuilder)
        {
            base.CreateModel(modelBuilder);

            modelBuilder.ConfigureApiCore(options =>
            {
                options.CollectionPrefix = CollectionPrefix;
            });
        }
    }
}