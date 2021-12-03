using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IleriRepository.Concrete
{
    public class Education : BaseTable
    {
        public Education()
        {
            Students = new HashSet<Student>();
            Teachers = new HashSet<Lecturer>();
            Personnels = new HashSet<Personnel>();
        }
        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<Lecturer> Teachers { get; set; }
        public virtual ICollection<Personnel> Personnels { get; set; }
    }
}
