using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PS.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Data.Myconfigurations
{
    class ProductConfigurations : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasMany(p => p.providers).WithMany(pr => pr.products).UsingEntity(t => t.ToTable("Providing"));
            builder.HasOne(p => p.category).WithMany(c => c.products).HasForeignKey(p => p.CategoryFK).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
