using PostModule.Domain.StateEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostModule.Domain.Repositories
{
    public interface IStateRepository
    {
        Task<IEnumerable<State>> GetStatesAsync();
        Task<State> GetStateByIdAsync(Guid id);
        Task<bool> CreateStateAsync(State state);
        Task<bool> UpdateStateAsync(State state);
        Task<bool> DeleteStateAsync(State state);
    }
}
