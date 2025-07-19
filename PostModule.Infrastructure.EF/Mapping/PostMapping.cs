using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PostModule.Domain.PostEntity.Entity;

namespace PostModule.Infrastructure.Mapping;

public class PostMapping : IEntityTypeConfiguration<Post>
{
    public void Configure(EntityTypeBuilder<Post> builder)
    {
        builder.ToTable("Posts");
        
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Title).IsRequired().HasMaxLength(100);
        builder.Property(x => x.Description).HasMaxLength(500);
        builder.Property(x => x.IsActive).IsRequired();
        builder.Property(x => x.LocationType).IsRequired();
        builder.Property(x => x.Status).HasConversion<string>();

        builder.HasMany(x => x.PostPrices).WithOne().HasForeignKey(pp => pp.PostId).OnDelete(DeleteBehavior.Cascade);
    }
}