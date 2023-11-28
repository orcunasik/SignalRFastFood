using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SignalRFastFood.Core.Models;

namespace SignalRFastFood.Repositories.Configurations;

internal class AboutConfiguration : IEntityTypeConfiguration<About>
{
    public void Configure(EntityTypeBuilder<About> builder)
    {
        builder.ToTable("Abouts");
        builder.HasKey(a => a.Id);
        builder.Property(a => a.Id).UseIdentityColumn();
        builder.Property(a => a.Title).IsRequired().HasMaxLength(100);
        builder.Property(a => a.ImageUrl).IsRequired().HasMaxLength(300);
        builder.Property(a => a.Description).IsRequired().HasMaxLength(750);
    }
}