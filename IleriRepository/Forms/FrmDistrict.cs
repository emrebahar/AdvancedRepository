using IleriRepository.Concrete;
using IleriRepository.Repositories.BaseRepository.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IleriRepository.Forms
{
    public partial class FrmDistrict : Form
    {
        public FrmDistrict()
        {
            InitializeComponent();
        }
        DistrictRepository districtRepository = new DistrictRepository();
        CityRepository cityRepository = new CityRepository();
        District selectedDistrict = new District();

        private void FrmDistrict_Load(object sender, EventArgs e)
        {
            Fill();
            FillCbCity();
        }

        private void FillCbCity()
        {
            cityRepository.GetComboBox(cbCity);
        }

        private void Fill()
        {
            dataGridView1.DataSource = districtRepository.SummaryList();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            selectedDistrict = districtRepository.FindById(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
            txtName.Text = selectedDistrict.Name;
            cbCity.SelectedValue = selectedDistrict.CityId;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            District district = new District();
            district.Name = txtName.Text;
            district.CityId = Convert.ToInt32(cbCity.SelectedValue);
            districtRepository.Add(district);
            districtRepository.DbSaveChanges();
            Fill();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            selectedDistrict.Name = txtName.Text;
            selectedDistrict.CityId = Convert.ToInt32(cbCity.SelectedValue);
            districtRepository.Update();
            Fill();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            districtRepository.Delete(selectedDistrict);
            districtRepository.DbSaveChanges();
            Fill();
        }
    }
}
