using eShopSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Data.Configurations
{
    public class OrderDetailConfiguration : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            builder.ToTable("OrderDetails");
            builder.HasKey(x => new { x.OrderId, x.ProductId });
            builder.HasOne(t => t.Order).WithMany(x => x.OrderDetails)
                .HasForeignKey(x => x.OrderId);
            builder.HasOne(t => t.Product).WithMany(x => x.OrderDetails)
                .HasForeignKey(x => x.ProductId);
        }
    }
}
