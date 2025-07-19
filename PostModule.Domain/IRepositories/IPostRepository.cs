using PostModule.Domain.PostEntity.Entity;

namespace PostModule.Domain.IRepositories;

public interface IPostRepository
{
    Task AddAsync(Post post);
    Task<Post?> GetByIdAsync(int id);
}