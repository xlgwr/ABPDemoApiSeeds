using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FHCollection.ApiCore;
using Volo.Abp.DependencyInjection;
using FHCollection.ApiCore.Data;

namespace FHCollection.ApiCore.EntityFrameworkCore
{
    [Dependency(ReplaceServices = true)]
    public class EntityFrameworkCoreApiCoreDbSchemaMigrator 
        : IApiCoreDbSchemaMigrator, ITransientDependency
    {
        private readonly ApiCoreMigrationsDbContext _dbContext;

        public EntityFrameworkCoreApiCoreDbSchemaMigrator(ApiCoreMigrationsDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task MigrateAsync()
        {
            await _dbContext.Database.MigrateAsync();
        }
    }
}