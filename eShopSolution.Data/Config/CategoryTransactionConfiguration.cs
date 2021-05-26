using eShopSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Config
{
    public class CategoryTransactionConfiguration : IEntityTypeConfiguration<CategoryTransaction>
    {
        public void Configure(EntityTypeBuilder<CategoryTransaction> builder)
        {
            builder.ToTable("CategoryTransactions");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Name).IsRequired().HasMaxLength(50);
            builder.Property(x => x.SeoTitle);
            builder.Property(x => x.SeoDescription);
            builder.Property(x => x.SeoAlias);
            builder.HasOne(x => x.Language).WithMany().HasForeignKey(x => x.LanguageId);
            builder.HasOne(x => x.Category).WithMany().HasForeignKey(x => x.CategoryId);
        }
    }
}
