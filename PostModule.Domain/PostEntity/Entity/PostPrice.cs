using PostModule.Domain.Common;
using PostModule.Domain.PostEntity.ValueObjects;

namespace PostModule.Domain.PostEntity.Entity;

public class PostPrice : BaseEntity<int>
{
    public int PostId { get; private set; }
    public WeightRange WeightRange { get; private set; }
    public PriceDetails PriceDetails { get; private set; }

    private PostPrice()
    {
    }

    public PostPrice(int postId, WeightRange weightRange, PriceDetails priceDetails)
    {
        PostId = postId;
        WeightRange = weightRange;
        PriceDetails = priceDetails;
    }

    public void Edit(WeightRange weightRange, PriceDetails priceDetails)
    {
        WeightRange = weightRange;
        PriceDetails = priceDetails;
    }
}