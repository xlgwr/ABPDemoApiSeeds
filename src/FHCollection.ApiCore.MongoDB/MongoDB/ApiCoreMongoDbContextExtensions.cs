using System;
using Volo.Abp;
using Volo.Abp.MongoDB;

namespace FHCollection.ApiCore.MongoDB
{
    public static class ApiCoreMongoDbContextExtensions
    {
        public static void ConfigureApiCore(
            this IMongoModelBuilder builder,
            Action<MongoModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            var options = new ApiCoreMongoModelBuilderConfigurationOptions();

            optionsAction?.Invoke(options);
        }
    }
}