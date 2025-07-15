using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostModule.Application.Queries.State
{
    public class StateWithCitiesDto
    {
        public string StateName { get; set; }
        public List<CitiesDto> Cities { get; set; }
    }
}
