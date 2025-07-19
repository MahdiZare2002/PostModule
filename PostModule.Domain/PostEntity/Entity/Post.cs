using PostModule.Domain.Common;
using PostModule.Domain.Enums;
using PostModule.Domain.PostEntity.ValueObjects;

namespace PostModule.Domain.PostEntity.Entity;

public class Post : BaseEntity<int>
{
    public string Title { get; private set; }
    public string? Description { get; private set; }
    public PostStatus Status { get; private set; }
    public bool IsActive { get; private set; }
    public LocationType LocationType { get; private set; }

    private readonly List<PostPrice> _postPrices = new();
    public IReadOnlyList<PostPrice> PostPrices => _postPrices.AsReadOnly();

    public Post(string title, string? description, PostStatus status, LocationType locationType)
    {
        Title = title;
        Status = status;
        IsActive = true;
        LocationType = locationType;
        Description = description;
    }

    public void Edit(string title, PostStatus status, LocationType locationType, string? description = null)
    {
        Title = title;
        Status = status;
        LocationType = locationType;
        Description = description;
    }

    public void ChangeActivity()
    {
        IsActive = !IsActive;
    }

    public void AddPrice(WeightRange weightRange, PriceDetails priceDetails)
    {
        _postPrices.Add(new PostPrice(Id, weightRange, priceDetails));
    }

    public void RemovePrice(PostPrice price)
    {
        _postPrices.Remove(price);
    }
}