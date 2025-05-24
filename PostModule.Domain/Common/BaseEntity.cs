using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostModule.Domain.Common
{
    public  class BaseEntity<TKey>
    {
        public TKey Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public BaseEntity()
        {
            CreatedDate = DateTime.Now;
            UpdatedDate = DateTime.Now;
        }
    }
}
