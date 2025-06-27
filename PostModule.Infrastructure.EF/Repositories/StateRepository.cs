using PostModule.Domain.IRepositories;
using PostModule.Domain.StateEntity;

namespace PostModule.Infrastructure.EF.Repositories
{
    public class StateRepository : Repository<int, State>, IStateRepository
    {

    }
}
