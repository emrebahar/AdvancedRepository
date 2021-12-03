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
    public class StudentRepository : BaseRepository<Student>, IStudentRepository
    {
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
