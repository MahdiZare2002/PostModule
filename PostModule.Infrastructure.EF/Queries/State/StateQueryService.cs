using Microsoft.EntityFrameworkCore;
using PostModule.Application.Queries.State;
using PostModule.Infrastructure.Context;

namespace PostModule.Infrastructure.Queries.State
{
    public class StateQueryService : IStateQueryService
    {
        private readonly PostModuleContext _context;
        public StateQueryService(PostModuleContext context)
        {
            _context = context;
        }

        public async Task<List<StateWithCitiesDto>> GetStatesWithCities()
        {
            return await _context.States.Include(c => c.Cities).Select(s => new StateWithCitiesDto
            {
                StateName = s.Title,
                Cities = s.Cities.Select(f => new CitiesDto
                {
                    CityId = f.Id,
                    CityName = f.Title
                }).ToList(),
            }).ToListAsync();
        }
    }
}
