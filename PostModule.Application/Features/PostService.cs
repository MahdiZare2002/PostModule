using PostModule.Application.DTOs.Post;
using PostModule.Application.Interfaces;
using PostModule.Domain.Enums;
using PostModule.Domain.IRepositories;
using PostModule.Domain.PostEntity.Entity;
using PostModule.Domain.PostEntity.ValueObjects;

namespace PostModule.Application.Features;

public class PostService : IPostService
{
    private readonly IPostRepository _postRepository;

    public PostService(IPostRepository postRepository)
    {
        _postRepository = postRepository;
    }

    public async Task<int> CreatePost(CreatePostDto postDto)
    {
        var status = Enum.Parse<PostStatus>(postDto.Status);
        var locationType = Enum.Parse<LocationType>(postDto.LocationType);

        var post = new Post(postDto.Title, postDto.Description, status, locationType);
        foreach (var priceDto in postDto.Prices)
        {
            var weightRange = new WeightRange(priceDto.Start, priceDto.End);
            var price = new PriceDetails(
                priceDto.Price.Tehran,
                priceDto.Price.StateCenter,
                priceDto.Price.City,
                priceDto.Price.InsideState,
                priceDto.Price.StateClose,
                priceDto.Price.StateNonClose
            );

            post.AddPrice(weightRange, price);
        }

        await _postRepository.AddAsync(post);
        return post.Id;
    }
}