using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IleriRepository.Concrete
{
    public class Lecturer : BasePeople
    {
        public Lecturer()
        {
            Students = new HashSet<Student>();
        }
        public virtual ICollection< Student> Students { get; set; }
        public int EducationId { get; set; }
        public string AcademicTitle { get; set; }
        public decimal Salary { get; set; }
        public string Branch { get; set; }

        [ForeignKey("EducationId")]
        public virtual Education Education { get; set; }

        [ForeignKey("DistrictId")]
        public virtual District District { get; set; }
        public override string GetTitle()
        {
            return "Sn " + AcademicTitle + " " + Name + " " + SurName;
        }
    }
}
