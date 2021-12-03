using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IleriRepository.Concrete
{
    public class City : BaseTable
    {
        public City()
        {
            Districts = new HashSet<District>();
        }
        public virtual ICollection<District> Districts { get; set; }
        
    }
}
