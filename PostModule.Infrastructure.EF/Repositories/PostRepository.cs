using Microsoft.EntityFrameworkCore;
using PostModule.Domain.IRepositories;
using PostModule.Domain.PostEntity.Entity;
using PostModule.Infrastructure.Context;

namespace PostModule.Infrastructure.Repositories;

public class PostRepository : IPostRepository
{
    private readonly PostModuleContext _context;

    public PostRepository(PostModuleContext context)
    {
        _context = context;
    }
    public async Task AddAsync(Post post)
    {
        await _context.Posts.AddAsync(post);
        await _context.SaveChangesAsync();
    }

    public async Task<Post?> GetByIdAsync(int id)
    {
        return await _context.Posts
            .Include(p => p.PostPrices)
            .FirstOrDefaultAsync(p => p.Id == id);
    }
}