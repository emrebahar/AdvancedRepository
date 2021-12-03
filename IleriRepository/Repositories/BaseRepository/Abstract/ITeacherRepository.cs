using IleriRepository.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IleriRepository.Repositories.BaseRepository.Abstract
{
    public interface ITeacherRepository
    {
        void RaiSesalaryByPercent(decimal rate);
        List<PeopleDTO> SummaryList();
        ComboBox GetComboBox(ComboBox cb);
    }
}
