using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PostModule.Domain.StateEntity;

namespace PostModule.Infrastructure.Mapping
{
    public class StateMapping : IEntityTypeConfiguration<State>
    {
        public void Configure(EntityTypeBuilder<State> builder)
        {
            builder.ToTable("States");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Title).IsRequired(true).HasMaxLength(155);
            builder.Property(x => x.CloseStates).IsRequired(false).HasMaxLength(155);
            builder.Property(x => x.CreatedDate).IsRequired(true);

            builder.HasMany(s => s.Cities)
                .WithOne(c => c.State)
                .HasForeignKey(c => c.StateId);
        }
    }
}
