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
    public class AppConfigConfiguration : IEntityTypeConfiguration<AppConfig> // config file AppConfig
    {
        public void Configure(EntityTypeBuilder<AppConfig> builder)
        {
            builder.ToTable("AppConfigs"); // map Entity AppConfig to table AppConfigs
            builder.HasKey(x => x.Key); // config thuoc tinh khoa = hasKey
            builder.Property(x=> x.Value).IsRequired(true);//bat buoc phai nhap
        }
    }
}
