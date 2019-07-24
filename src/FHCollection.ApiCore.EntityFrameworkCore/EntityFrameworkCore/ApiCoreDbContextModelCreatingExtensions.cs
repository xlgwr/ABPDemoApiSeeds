using System;
using Microsoft.EntityFrameworkCore;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace FHCollection.ApiCore.EntityFrameworkCore
{
    public static class ApiCoreDbContextModelCreatingExtensions
    {
        public static void ConfigureApiCore(
            this ModelBuilder builder,
            Action<ApiCoreModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            var options = new ApiCoreModelBuilderConfigurationOptions();

            optionsAction?.Invoke(options);


            /* Configure all entities here. Example:
             * 

            builder.Entity<Question>(b =>
            {
                //Configure table & schema name
                b.ToTable(options.TablePrefix + "Questions", options.Schema);
            
                b.ConfigureFullAuditedAggregateRoot();
            
                //Properties
                b.Property(q => q.Title).IsRequired().HasMaxLength(QuestionConsts.MaxTitleLength);
                
                //Relations
                b.HasMany(question => question.Tags).WithOne().HasForeignKey(qt => qt.QuestionId);

                //Indexes
                b.HasIndex(q => q.CreationTime);
            });
            */

            builder.Entity<Book>(b =>
            {
                b.ToTable(ApiCoreConsts.DefaultDbTablePrefix + "Books", ApiCoreConsts.DefaultDbSchema);
                b.ConfigureAuditedAggregateRoot(); //auto configure for the base class props 

                //b.ConfigureAudited();
                //b.ConfigureExtraProperties();
                //b.ConfigureConcurrencyStamp();

                b.Property(x => x.Name).IsRequired().HasMaxLength(128);
            });
        }
    }
}