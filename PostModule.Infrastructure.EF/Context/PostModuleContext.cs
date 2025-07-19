using Microsoft.EntityFrameworkCore;
using PostModule.Domain.CityEntity;
using PostModule.Domain.PostEntity.Entity;
using PostModule.Domain.StateEntity;
using PostModule.Infrastructure.Mapping;

namespace PostModule.Infrastructure.Context
{
    public class PostModuleContext : DbContext
    {
        public PostModuleContext(DbContextOptions<PostModuleContext> options) : base(options)
        {
        }

        public DbSet<State> States { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<PostPrice> PostPrices { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new StateMapping());
            modelBuilder.ApplyConfiguration(new CityMapping());
            modelBuilder.ApplyConfiguration(new PostMapping());
            modelBuilder.ApplyConfiguration(new PostPriceMapping());
            base.OnModelCreating(modelBuilder);
        }
    }
}