using PostModule.Application.DTOs.State;

namespace PostModule.Application.Interfaces
{
    public interface IStateService
    {
        Task<bool> Create(CreateStateModel command);
        Task<bool> Edit(EditStateModel command);
        List<StateViewModel> GetAll();
        Task<EditStateModel> GetStateForEdit(int id);
        Task<bool> ExistTitleForCreate(string title);
        Task<bool> ExistTitleForEdit(string title, int id);
    }
}
