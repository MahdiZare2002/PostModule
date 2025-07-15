using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostModule.Application.Queries.State
{
    public interface IStateQueryService
    {
        public Task<List<StateWithCitiesDto>> GetStatesWithCities();
    }
}
