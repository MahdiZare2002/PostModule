using PostModule.Application.Contract.StateApplication;
using PostModule.Domain.IRepositories;
using PostModule.Domain.StateEntity;

namespace PostModule.Application.Services
{
    public class StateApplication : IStateApplication
    {
        private readonly IStateRepository _stateRepository;
        public StateApplication(IStateRepository stateRepository)
        {
            _stateRepository = stateRepository;
        }
        public async Task<bool> Create(CreateStateModel command)
        {
            State state = new(command.Title);
            return await _stateRepository.CreateAsync(state);
        }

        public async Task<bool> Edit(EditStateModel command)
        {
            var existState = await _stateRepository.GetByIdAsync(command.Id);
            existState.Edit(command.Title);
            return await _stateRepository.SaveAsync();
        }

        public async Task<bool> ExistTitleForCreate(string title)
        {
            return await _stateRepository.IsExistAsync(s => s.Title == title);
        }

        public async Task<bool> ExistTitleForEdit(string title, int id)
        {
            return await _stateRepository.IsExistAsync(s => s.Title == title && s.Id != id);
        }

        public List<StateViewModel> GetAll()
        {
            return _stateRepository.GetAllQuery().Select(s => new StateViewModel
            {
                Id = s.Id,
                CreateDate = s.CreatedDate.ToString(),
                Title = s.Title
            }).ToList();
        }

        public async Task<EditStateModel> GetStateForEdit(int id)
        {
            var state = await _stateRepository.GetByIdAsync(id);
            return new()
            {
                Id = state.Id,
                Title = state.Title
            };
        }
    }
}
