using Microsoft.EntityFrameworkCore;
using SignalRFastFood.Core.Models;
using System.Reflection;

namespace SignalRFastFood.Repositories.Repositories.EntityFrameworkCore.Context;

public class FastFoodDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=DESKTOP-I6RA8LI;Initial Catalog=SignalRFastFoodDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
    }

    public DbSet<About> Abouts { get; set; }
    public DbSet<Booking> Bookings { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Contact> Contacts { get; set; }
    public DbSet<Discount> Discounts { get; set; }
    public DbSet<Feature> Features { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<SocialMedia> SocialMedias { get; set; }
    public DbSet<Testimonial> Testimonials { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}