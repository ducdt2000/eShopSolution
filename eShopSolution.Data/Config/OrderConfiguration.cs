using eShopSolution.Data.Entities;
using eShopSolution.Data.Enum;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Config
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("Orders");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.OrderDate);

            builder.Property(x => x.Address).IsRequired();

            builder.Property(x => x.ShipEmail).IsRequired().HasMaxLength(50);

            builder.Property(x => x.ShipName).IsRequired().HasMaxLength(50);

            builder.Property(x => x.Status).HasDefaultValue(OrderStatus.Pending);

            builder.Property(x => x.ShipPhoneNumber).IsRequired().HasMaxLength(30);

            builder.HasOne(x => x.User).WithMany().HasForeignKey(x => x.UserId);
        }
    }
}
