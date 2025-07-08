using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PostModule.Domain.CityEntity;

namespace PostModule.Infrastructure.Mapping
{
    public class CityMapping : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.ToTable("Citites");
            builder.HasKey(x => x.Id);
            builder.Property(b => b.Title).IsRequired(true).HasMaxLength(255);
            builder.Property(b => b.Status).IsRequired(true);

            builder.HasOne(s => s.State).WithMany(c => c.Cities).HasForeignKey(c => c.StateId);
        }
    }
}
