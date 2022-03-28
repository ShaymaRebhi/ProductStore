using System;
using Microsoft.EntityFrameworkCore;
using PS.Data.Myconfigurations;
using PS.Domain;

namespace PS.Data
{
    public class PSContext:DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Provider> Providers { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Chemical> Chemicals { get; set; }

        public DbSet<Biological> Biologicals { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb; 
                                          Initial Catalog=ProductStoreDB;
                                          Integrated Security=true;
                                          MultipleActiveResultSets=true");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //1ere methode
            //modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            //modelBuilder.ApplyConfiguration(new ProductConfigurations());
            //2eme methode
            modelBuilder.Entity<Category>().ToTable("MyCategories");
            modelBuilder.Entity<Category>().HasKey(C => C.CategoryId);
            modelBuilder.Entity<Category>().Property(C => C.Name).IsRequired().HasMaxLength(50);
        }
    }
}
