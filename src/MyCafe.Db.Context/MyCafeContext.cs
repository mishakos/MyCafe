using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

using MyCafe.DB.Enities;

namespace MyCafe.Db.Context
{
    public class MyCafeContext : IdentityDbContext
    {
        public MyCafeContext(DbContextOptions<MyCafeContext> options): base(options)
        {

        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Firm> Firms { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<InvoiceDetail> InvoiceDetails { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Price> Prices { get; set; }
        public DbSet<PriceType> PriceTypes { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductUnit> ProductUnits { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<RecipeDetail> RecipeDetails { get; set; }
        public DbSet<Table> Tables { get; set; }
        public DbSet<Unit> Units { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<ProductUnit>()
                .HasOne(p => p.WeightUnit)
                .WithMany()
                .HasForeignKey(p => p.WeightUnitId)
                .OnDelete(DeleteBehavior.Restrict);
            builder.Entity<Price>()
                .HasOne(p => p.ProductUnit)
                .WithMany()
                .HasForeignKey(p => p.ProductUnitId)
                .OnDelete(DeleteBehavior.Restrict);
            builder.Entity<RecipeDetail>()
                .HasOne(p => p.ProductUnit)
                .WithMany()
                .HasForeignKey(p => p.ProductUnitId)
                .OnDelete(DeleteBehavior.Restrict);
            builder.Entity<InvoiceDetail>()
                .HasOne(p => p.ProductUnit)
                .WithMany()
                .HasForeignKey(p => p.ProductUnitId)
                .OnDelete(DeleteBehavior.Restrict);
            builder.Entity<OrderDetail>()
               .HasOne(p => p.ProductUnit)
               .WithMany()
               .HasForeignKey(p => p.ProductUnitId)
               .OnDelete(DeleteBehavior.Restrict);
            base.OnModelCreating(builder);

        }
    }
}
