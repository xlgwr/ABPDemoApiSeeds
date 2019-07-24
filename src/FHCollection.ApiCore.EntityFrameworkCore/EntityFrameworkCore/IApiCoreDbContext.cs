using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace FHCollection.ApiCore.EntityFrameworkCore
{
    [ConnectionStringName("ApiCore")]
    public interface IApiCoreDbContext : IEfCoreDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * DbSet<Question> Questions { get; }
         */
    }
}