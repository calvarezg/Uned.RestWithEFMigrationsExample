using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Uned.RestWithEFExample.Models;

namespace Uned.RestWithEFExample.Data.Configurations
{
    public class GuitarConfiguration : IEntityTypeConfiguration<Guitar>
    {
        public void Configure(EntityTypeBuilder<Guitar> builder)
        {
            builder.Property(g => g.Name).IsRequired();
            builder.Property(g => g.Description).HasMaxLength(150).IsRequired();
            builder.Property(g => g.FilePath).IsRequired();
            builder.Property(g => g.IsActive).HasDefaultValue(true);
        }
    }
}
