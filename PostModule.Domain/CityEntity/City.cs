using PostModule.Domain.Common;
using PostModule.Domain.StateEntity;

namespace PostModule.Domain.CityEntity
{
    public class City : BaseEntity<int>
    {
        public string Title { get; set; }
        public int StateId { get; set; }
        public bool Status { get; set; }
        public State State { get; set; }

        public City(int stateId, string title, bool cityStatus = true)
        {
            Title = title;
            StateId = stateId;
            Status = cityStatus;
        }
        public void Edit(string title, bool status = true)
        {
            Title = title;
            Status = status;
            UpdatedDate = DateTime.Now;
        }
        public void IsTehran()
        {
            Status = true;
        }
        public void IsCenter()
        {
            Status = true;
        }
        public void INotCenterOrTehran()
        {
            Status = true;
        }
    }
}
