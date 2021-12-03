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
    public class CityRepository : BaseRepository<City>, IEducationRepository
    {
        public ComboBox GetComboBox(ComboBox cb)
        {
            cb.ValueMember = "ID";
            cb.DisplayMember = "Name";
            cb.DataSource = GetOption();
            return cb;
        }

        public List<BaseTableDTO> GetOption()
        {
            return DbSet().Select(x => new BaseTableDTO
            {
                ID = x.Id,
                Name = x.Name,
            }).ToList();
        }

        public List<BaseTableDTO> SummaryList()
        {
            return DbSet().Select(x => new BaseTableDTO
            {
                ID = x.Id,
                Name = x.Name
            }).ToList();
        }
    }
}
