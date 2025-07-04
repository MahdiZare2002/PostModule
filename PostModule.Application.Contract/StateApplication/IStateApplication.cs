namespace PostModule.Application.Contract.StateApplication
{
    public interface IStateApplication
    {
        Task<bool> Create(CreateStateModel command);
        Task<bool> Edit(EditStateModel command);
        Task<List<StateViewModel>> GetAll();
        Task<EditStateModel> GetStateForEdit(int id);
        Task<bool> ExistTitleForCreate(string title);
        Task<bool> ExistTitleForEdit(string title, int id);
    }
}
