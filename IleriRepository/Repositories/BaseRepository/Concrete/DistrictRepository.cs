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
    public class DistrictRepository : BaseRepository<District>, IDistrictRepository
    {
        public ComboBox GetComboBox(ComboBox cb)
        {
            cb.ValueMember = "ID";
            cb.DisplayMember = "Name";
            cb.DataSource = GetOption();
            return cb;
        }
        public ComboBox GetComboBox(ComboBox cb, int id)
        {
            cb.ValueMember = "ID";
            cb.DisplayMember = "Name";
            cb.DataSource = GetOption(id);
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
        public List<DistrictDTO> GetOption(int id)
        {
            return DbSet().Select(x => new DistrictDTO
            {
                ID = x.Id,
                Name = x.Name,
                CityId = x.CityId
            }).Where(x=> x.CityId ==id).ToList();
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
