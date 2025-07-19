using PostModule.Application.DTOs.Post;
using PostModule.Domain.PostEntity.Entity;

namespace PostModule.Application.Interfaces;

public interface IPostService
{
    Task<int> CreatePost(CreatePostDto post);
}