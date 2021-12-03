using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IleriRepository.Concrete
{
    public class Personnel : BasePeople
    {
        public int EducationId { get; set; }
        public decimal Salary { get; set; }

        [ForeignKey("DistrictId")]
        public virtual District District { get; set; }
        [ForeignKey("EducationId")]
        public virtual Education Education { get; set; }

    }
}
