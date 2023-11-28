using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SignalRFastFood.Entities.Models;

namespace SignalRFastFood.Repositories.Configurations;

internal class BookingConfiguration : IEntityTypeConfiguration<Booking>
{
    public void Configure(EntityTypeBuilder<Booking> builder)
    {
        builder.ToTable("Bookings");
        builder.HasKey(b => b.Id);
        builder.Property(b => b.Id).UseIdentityColumn();
        builder.Property(b => b.NameSurname).IsRequired().HasMaxLength(100);
        builder.Property(b => b.Email).IsRequired().HasMaxLength(100);
        builder.Property(b => b.PhoneNumber).IsRequired().HasMaxLength(20);
        builder.Property(b => b.PersonCount).IsRequired();
        builder.Property(b => b.CreatedDate).IsRequired();
    }
}