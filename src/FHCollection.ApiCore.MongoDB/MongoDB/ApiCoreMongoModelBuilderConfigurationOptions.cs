using JetBrains.Annotations;
using Volo.Abp.MongoDB;

namespace FHCollection.ApiCore.MongoDB
{
    public class ApiCoreMongoModelBuilderConfigurationOptions : MongoModelBuilderConfigurationOptions
    {
        public ApiCoreMongoModelBuilderConfigurationOptions(
            [NotNull] string tablePrefix = ApiCoreConsts.DefaultDbTablePrefix)
            : base(tablePrefix)
        {
        }
    }
}