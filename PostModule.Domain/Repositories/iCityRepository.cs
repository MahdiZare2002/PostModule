using PostModule.Domain.CityEntity;
using PostModule.Domain.StateEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PostModule.Domain.Repositories
{
    public interface iCityRepository
    {
        Task<IEnumerable<City>> GetAllCitiesAsync(Expression<Func<City, bool>> expression);
        Task<City> GetCityByIdAsync(Guid id);
        Task<bool> CreateCityAsync(City city);
        Task<bool> UpdateCityAsync(City city);
        Task<bool> DeleteCityAsync(City city);
        Task<bool> IsCityExistAsync(Expression<Func<City, bool>> expression);
    }
}
