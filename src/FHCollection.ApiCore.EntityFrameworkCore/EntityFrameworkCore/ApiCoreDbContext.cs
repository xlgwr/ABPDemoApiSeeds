using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace FHCollection.ApiCore.EntityFrameworkCore
{
    [ConnectionStringName("ApiCore")]
    public class ApiCoreDbContext : AbpDbContext<ApiCoreDbContext>, IApiCoreDbContext
    {
        public static string TablePrefix { get; set; } = ApiCoreConsts.DefaultDbTablePrefix;

        public static string Schema { get; set; } = ApiCoreConsts.DefaultDbSchema;

        /* Add DbSet for each Aggregate Root here. Example:
         * public DbSet<Question> Questions { get; set; }
         */

        public DbSet<Book> Books { get; set; }

        public ApiCoreDbContext(DbContextOptions<ApiCoreDbContext> options) 
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ConfigureApiCore(options =>
            {
                options.TablePrefix = TablePrefix;
                options.Schema = Schema;
            });
        }
    }
}