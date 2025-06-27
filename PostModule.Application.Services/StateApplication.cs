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
        public bool Create(CreateStateModel command)
        {
            throw new NotImplementedException();
        }

        public bool Edit(EditStateModel command)
        {
            throw new NotImplementedException();
        }

        public bool ExistTitleForCreate(string title)
        {
            throw new NotImplementedException();
        }

        public bool ExistTitleForEdit(string title, int id)
        {
            throw new NotImplementedException();
        }

        public List<StateViewModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public EditStateModel GetStateForEdit(int id)
        {
            throw new NotImplementedException();
        }
    }
}
