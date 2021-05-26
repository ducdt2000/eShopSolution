using eShopSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Config
{
    public class PromotionConfiguration : IEntityTypeConfiguration<Promotion>
    {
        public void Configure(EntityTypeBuilder<Promotion> builder)
        {
            builder.ToTable("Promotions");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.FromDate);
            builder.Property(x => x.ToDate);

            builder.Property(x => x.IsApplyForAll).HasDefaultValue(false);

            builder.Property(x => x.DiscountPercent);
            builder.Property(x => x.DiscountAmount);

            builder.Property(x => x.ProductIds);
            builder.Property(x => x.ProductCategoryIds);
        }
    }
}
