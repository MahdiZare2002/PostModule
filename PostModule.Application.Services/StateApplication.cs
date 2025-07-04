using PostModule.Application.Contract.StateApplication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostModule.Application.Services
{
    public class StateApplication : IStateApplication
    {
        public Task<bool> Create(CreateStateModel command)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Edit(EditStateModel command)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ExistTitleForCreate(string title)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ExistTitleForEdit(string title, int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<StateViewModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<EditStateModel> GetStateForEdit(int id)
        {
            throw new NotImplementedException();
        }
    }
}
