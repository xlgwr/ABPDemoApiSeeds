using JetBrains.Annotations;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace FHCollection.ApiCore.EntityFrameworkCore
{
    public class ApiCoreModelBuilderConfigurationOptions : ModelBuilderConfigurationOptions
    {
        public ApiCoreModelBuilderConfigurationOptions(
            [NotNull] string tablePrefix = ApiCoreConsts.DefaultDbTablePrefix,
            [CanBeNull] string schema = ApiCoreConsts.DefaultDbSchema)
            : base(
                tablePrefix,
                schema)
        {

        }
    }
}