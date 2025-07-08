using PostModule.Application.DTOs.City;
using PostModule.Application.Interfaces;
using PostModule.Domain.CityEntity;
using PostModule.Domain.IRepositories;

namespace PostModule.Application.Features
{
    public class CityService : ICityService
    {
        private readonly iCityRepository _cityRepository;
        public CityService(iCityRepository cityRepository)
        {
            _cityRepository = cityRepository;
        }
        public async Task<bool> Create(CreateCityModel command)
        {
            City city = new(command.StateId, command.Title, command.Status);
            return await _cityRepository.CreateAsync(city);
        }

        public async Task<bool> Edit(EditCityModel command)
        {
            var city = await _cityRepository.GetByIdAsync(command.Id);
            city.Edit(command.Title, command.Status);
            return await _cityRepository.SaveAsync();
        }

        public async Task<bool> ExistTitleForCreate(string title, int stateid)
        {
            return await _cityRepository.IsExistAsync(c => c.Title == title && c.StateId == stateid);
        }

        public async Task<bool> ExistTitleForEdit(string title, int id, int stateid)
        {
            return await _cityRepository.IsExistAsync(c => c.Title == title && c.StateId == stateid && c.Id != id);
        }

        public List<CityViewModel> GetAllForState(int stateId)
        {
            return _cityRepository.GetAllByQuery(c => c.StateId == stateId).Select(c => new CityViewModel
            {
                CreatedDate = c.CreatedDate,
                Id = c.Id,
                Status = c.Status,
                Title = c.Title
            }).ToList();
        }

        public async Task<EditCityModel> GetCityForEdit(int id)
        {
            var city = await _cityRepository.GetByIdAsync(id);
            return new()
            {
                Id = city.Id,
                Status = city.Status,
                Title = city.Title
            };
        }
    }
}
