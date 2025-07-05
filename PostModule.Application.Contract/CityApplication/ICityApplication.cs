using PostModule.Application.Contract.StateApplication;

namespace PostModule.Application.Contract.CityApplication
{
    public interface ICityApplication
    {
        Task<bool> Create(CreateCityModel command);
        Task<bool> Edit(EditCityModel command);
        Task<EditCityModel> GetCityForEdit(int id);
        Task<bool> ExistTitleForCreate(string title, int stateid);
        Task<bool> ExistTitleForEdit(string title, int id, int stateid);
        List<CityViewModel> GetAllForState(int stateId);
    }
}
