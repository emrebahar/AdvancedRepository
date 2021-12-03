using IleriRepository.Concrete;
using IleriRepository.DTO;
using IleriRepository.Repositories.BaseRepository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IleriRepository.Repositories.BaseRepository.Concrete
{
    public class PersonnelRepository : BaseRepository<Personnel>, IPersonnelRepository
    {
        Personnel Personnel = new Personnel();
        public void RaiSesalaryByPercent(decimal rate)
        {
            Personnel.Salary += Convert.ToDecimal(Personnel.Salary * rate / 100);
            //Zam Yapma Kodu yazılacak...
            DbSaveChanges();
        }

        public List<PeopleDTO> SummaryList()
        {
            return DbSet().Select(x => new PeopleDTO
            {
                ID = x.Id,
                Name = x.Name,
                SurName = x.SurName,
            }).ToList();
        }
    }
}
