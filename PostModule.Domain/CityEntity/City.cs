using PostModule.Domain.Common;
using PostModule.Domain.Enums;
using PostModule.Domain.StateEntity;

namespace PostModule.Domain.CityEntity
{
    public class City : BaseEntity<int>
    {
        public string Title { get; set; }
        public int StateId { get; set; }
        public CityStatus Status { get; set; }
        public State State { get; set; }

        public City() { }

        public City(int stateId, string title, CityStatus cityStatus)
        {
            Title = title;
            StateId = stateId;
            Status = cityStatus;
        }
        public void Edit(string title, CityStatus status)
        {
            Title = title;
            Status = status;
            UpdatedDate = DateTime.Now;
        }
        public void IsTehran()
        {
            Status = CityStatus.isTehran;
        }
        public void IsCenter()
        {
            Status = CityStatus.isCenter;
        }
        public void IsNormal()
        {
            Status = CityStatus.isNormal;
        }
    }
}
