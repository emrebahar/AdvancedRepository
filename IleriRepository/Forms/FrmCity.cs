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
    public partial class FrmCity : Form
    {
        public FrmCity()
        {
            InitializeComponent();
        }
        CityRepository cityRepository = new CityRepository();
        City selectedCity = new City();

        private void FrmCity_Load(object sender, EventArgs e)
        {
            Fill();
        }
        private void Fill()
        {
            dataGridView1.DataSource = cityRepository.SummaryList();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            selectedCity = cityRepository.FindById(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
            txtName.Text = selectedCity.Name;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            City city = new City();
            city.Name = txtName.Text;
            cityRepository.Add(city);
            cityRepository.DbSaveChanges();
            Fill();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            selectedCity.Name = txtName.Text;
            cityRepository.Update();
            Fill();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            cityRepository.Delete(selectedCity);
            cityRepository.DbSaveChanges();
            Fill();
        }
    }
}
