using IleriRepository.Concrete;
using IleriRepository.DTO;
using IleriRepository.Repositories.BaseRepository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IleriRepository.Repositories.BaseRepository.Concrete
{
    public class TeacherRepository : BaseRepository<Lecturer>, ITeacherRepository
    {
        Lecturer Teacher = new Lecturer();

        public ComboBox GetComboBox(ComboBox cb)
        {
            cb.ValueMember = "ID";
            cb.DisplayMember = "Name";
            cb.DataSource = DbSet().Select(x => new BaseTableDTO
            {
                ID = x.Id,
                Name = x.Name
            }).ToList();
            return cb;
        }

        public void RaiSesalaryByPercent(decimal rate)
        {
            List<Lecturer> teachers = DbSet().ToList();
            foreach (var item in teachers)
            {
                item.Salary += Convert.ToDecimal(item.Salary * rate / 100);
            }
            //Zam Yapma Kodu yazılacak...
            DbSaveChanges();
        }
        public void RaiSesalaryByPercent(decimal rate, int id)
        {
            Teacher = FindById(id);
            Teacher.Salary += Convert.ToDecimal(Teacher.Salary * rate / 100);
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
