using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostModule.Application.Contract.CityApplication
{
    public class CreateCityModel
    {
        public string Title { get; set; }
        public int StateId { get; set; }
        public bool Status { get; set; }
    }
}
