using PostModule.Domain.Enums;

namespace PostModule.Application.DTOs.City
{
    public class EditCityModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public CityStatus Status { get; set; }
    }
}
