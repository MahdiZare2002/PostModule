using PostModule.Application.DTOs.City;

namespace PostModule.Application.Interfaces
{
    public interface ICityService
    {
        Task<bool> Create(CreateCityModel command);
        Task<bool> Edit(EditCityModel command);
        Task<EditCityModel> GetCityForEdit(int id);
        Task<bool> ExistTitleForCreate(string title, int stateid);
        Task<bool> ExistTitleForEdit(string title, int id, int stateid);
        List<CityViewModel> GetAllForState(int stateId);
    }
}
