using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Uned.RestWithEFExample.Models;

namespace Uned.RestWithEFExample.Data.Configurations
{
    public class GuitarHistoryConfiguration : IEntityTypeConfiguration<GuitarHistory>
    {
        public void Configure(EntityTypeBuilder<GuitarHistory> builder)
        {
            builder.Property(gh => gh.Description).HasMaxLength(500).IsRequired();
            builder.Property(gh => gh.Date).IsRequired();
            builder.Property(gh => gh.Type).IsRequired();
        }
    }
}
