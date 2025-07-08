using PostModule.Domain.Enums;

namespace PostModule.Application.DTOs.City
{
    public class CreateCityModel
    {
        public string Title { get; set; }
        public int StateId { get; set; }
        public CityStatus Status { get; set; }
    }
}
