using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SignalRFastFood.Core.Models;

namespace SignalRFastFood.Repositories.Configurations;

internal class FeatureConfiguration : IEntityTypeConfiguration<Feature>
{
    public void Configure(EntityTypeBuilder<Feature> builder)
    {
        builder.ToTable("Features");
        builder.HasKey(f => f.Id);
        builder.Property(f => f.Id).UseIdentityColumn();
        builder.Property(f => f.Title1).IsRequired().HasMaxLength(50);
        builder.Property(f => f.Description1).IsRequired().HasMaxLength(150);
        builder.Property(f => f.Title2).IsRequired().HasMaxLength(50);
        builder.Property(f => f.Description2).IsRequired().HasMaxLength(150);
        builder.Property(f => f.Title3).IsRequired().HasMaxLength(50);
        builder.Property(f => f.Description3).IsRequired().HasMaxLength(150);
    }
}