using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SignalRFastFood.Core.Models;

namespace SignalRFastFood.Repositories.Configurations;

internal class DiscountConfiguration : IEntityTypeConfiguration<Discount>
{
    public void Configure(EntityTypeBuilder<Discount> builder)
    {
        builder.ToTable("Discounts");
        builder.HasKey(d => d.Id);
        builder.Property(d => d.Id).UseIdentityColumn();
        builder.Property(d => d.Title).IsRequired().HasMaxLength(100);
        builder.Property(d => d.Amount).HasMaxLength(10);
        builder.Property(d => d.Description).IsRequired().HasMaxLength(200);
        builder.Property(d => d.ImageUrl).IsRequired().HasMaxLength(300);
    }
}