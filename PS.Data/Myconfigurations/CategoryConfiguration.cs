using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using PS.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace PS.Data.Myconfigurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("MyCategories"); //pour renommer la table 
            builder.HasKey(C => C.CategoryId);
            builder.Property(C => C.Name).IsRequired().HasMaxLength(50); //Pour configurer name
        }
    }
}
