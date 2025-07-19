using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PostModule.Domain.PostEntity.Entity;

namespace PostModule.Infrastructure.Mapping;

public class PostPriceMapping : IEntityTypeConfiguration<PostPrice>
{
    public void Configure(EntityTypeBuilder<PostPrice> builder)
    {
        builder.ToTable("PostPrices");
        builder.HasKey(p => p.Id);

        builder.OwnsOne(p => p.WeightRange, range =>
        {
            range.Property(r => r.Start).HasColumnName("WeightStart");
            range.Property(r => r.End).HasColumnName("WeightEnd");
        });

        builder.OwnsOne(p => p.PriceDetails, price =>
        {
            price.Property(p => p.Tehran).HasColumnName("Price_Tehran");
            price.Property(p => p.StateCenter).HasColumnName("Price_StateCenter");
            price.Property(p => p.City).HasColumnName("Price_City");
            price.Property(p => p.InsideState).HasColumnName("Price_InsideState");
            price.Property(p => p.StateClose).HasColumnName("Price_StateClose");
            price.Property(p => p.StateNonClose).HasColumnName("Price_StateNonClose");
        });
    }
}