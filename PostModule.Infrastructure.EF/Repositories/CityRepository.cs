using PostModule.Domain.CityEntity;
using PostModule.Domain.IRepositories;
using PostModule.Infrastructure.Context;

namespace PostModule.Infrastructure.Repositories
{
    public class CityRepository : Repository<int, City>, iCityRepository
    {
        private readonly PostModuleContext _context;
        public CityRepository(PostModuleContext context) : base(context)
        {
            _context = context;
        }
    }
}
