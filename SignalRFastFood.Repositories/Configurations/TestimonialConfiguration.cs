using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SignalRFastFood.Core.Models;

namespace SignalRFastFood.Repositories.Configurations;

internal class TestimonialConfiguration : IEntityTypeConfiguration<Testimonial>
{
    public void Configure(EntityTypeBuilder<Testimonial> builder)
    {
        builder.ToTable("Testimonials");
        builder.HasKey(t => t.Id);
        builder.Property(t => t.Id).UseIdentityColumn();
        builder.Property(t => t.Name).IsRequired().HasMaxLength(100);
        builder.Property(t => t.Title).IsRequired().HasMaxLength(100);
        builder.Property(t => t.Comment).IsRequired().HasMaxLength(350);
        builder.Property(t => t.ImageUrl).IsRequired().HasMaxLength(300);
        builder.Property(t => t.IsStatus).IsRequired();
    }
}