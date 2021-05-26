using eShopSolution.Data.Entities;
using eShopSolution.Data.Enum;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Config
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Categories");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.SortOrder).IsRequired();
            builder.Property(x => x.IsShowOnHome).IsRequired();
            builder.Property(x => x.ParentId);
            builder.Property(x => x.Status).HasDefaultValue(CategoryStatus.Active);
        }
    }
}
