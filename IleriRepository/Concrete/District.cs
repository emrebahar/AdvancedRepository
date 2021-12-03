using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IleriRepository.Concrete
{
    public class District : BaseTable
    {
        public District()
        {
            Students = new HashSet<Student>();
            Personnels = new HashSet<Personnel>();
            Teachers = new HashSet<Lecturer>();
        }

        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<Personnel> Personnels { get; set; }
        public virtual ICollection<Lecturer> Teachers { get; set; }

        public int CityId { get; set; }

        [ForeignKey("CityId")]
        public virtual City City { get; set; }
    }
}
