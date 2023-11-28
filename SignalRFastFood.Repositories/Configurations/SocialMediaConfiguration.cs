using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SignalRFastFood.Core.Models;

namespace SignalRFastFood.Repositories.Configurations;

internal class SocialMediaConfiguration : IEntityTypeConfiguration<SocialMedia>
{
    public void Configure(EntityTypeBuilder<SocialMedia> builder)
    {
        builder.ToTable("SocialMedias");
        builder.HasKey(sc => sc.Id);
        builder.Property(sc => sc.Id).UseIdentityColumn();
        builder.Property(sc => sc.Title).IsRequired().HasMaxLength(100);
        builder.Property(sc => sc.Icon).IsRequired().HasMaxLength(100);
        builder.Property(sc => sc.Url).IsRequired().HasMaxLength(300);
    }
}