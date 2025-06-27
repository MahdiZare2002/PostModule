using Microsoft.EntityFrameworkCore;
using PostModule.Domain.CityEntity;
using PostModule.Domain.StateEntity;

namespace PostModule.Infrastructure.EF.Context
{
    public class PostModuleContext : DbContext
    {
        public PostModuleContext(DbContextOptions<PostModuleContext> options) : base(options) { }

        public DbSet<State> States { get; set; }
        public DbSet<City> Cities { get; set; }
    }
}
