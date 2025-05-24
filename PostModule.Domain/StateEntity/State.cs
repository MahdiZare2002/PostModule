using PostModule.Domain.CityEntity;
using PostModule.Domain.Common;

namespace PostModule.Domain.StateEntity
{
    public class State : BaseEntity<int>
    {
        public string Title { get; private set; }
        public string CloseStates { get; private set; }
        public List<City> Cities { get; private set; }
        public State(string title)
        {
            Title = title;
            CloseStates = "";
            Cities = new List<City>();
        }
        public void Edit(string title)
        {
            Title = title;
            UpdatedDate = DateTime.Now;
        }
        public void ChangeCloseStates(List<int> States)
        {
            CloseStates = String.Join("-", States);
            UpdatedDate = DateTime.Now;
        }
    }
}
