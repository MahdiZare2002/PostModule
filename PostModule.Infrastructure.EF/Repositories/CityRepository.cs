using PostModule.Domain.CityEntity;
using PostModule.Domain.IRepositories;

namespace PostModule.Infrastructure.EF.Repositories
{
    public class CityRepository : Repository<int, City>, iCityRepository
    {

    }
}
