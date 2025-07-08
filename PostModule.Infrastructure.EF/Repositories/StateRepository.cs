using PostModule.Domain.IRepositories;
using PostModule.Domain.StateEntity;
using PostModule.Infrastructure.Context;

namespace PostModule.Infrastructure.Repositories
{
    public class StateRepository : Repository<int, State>, IStateRepository
    {
        private readonly PostModuleContext _context;
        public StateRepository(PostModuleContext context) : base(context)
        {
            _context = context;
        }
    }
}
