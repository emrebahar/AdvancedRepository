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
    public partial class FrmPersonnel : Form
    {
        public FrmPersonnel()
        {
            InitializeComponent();
        }
        readonly PersonnelRepository personnelRepository = new PersonnelRepository();
        readonly CityRepository CityRepository = new CityRepository();
        readonly EducationRepository EducationRepository = new EducationRepository();
        readonly DistrictRepository DistrictRepository = new DistrictRepository();
        Personnel selectedPersonnel = new Personnel();
        
        private void FrmPersonnel_Load(object sender, EventArgs e)
        {
            Fill();
            FillcbEducation();
            FillcbCity();
        }

        private void FillcbCity()
        {
            CityRepository.GetComboBox(cbCity);
        }

        private void FillcbEducation()
        {
            EducationRepository.GetComboBox(cbEducation);
        }

        private void Fill()
        {
            dataGridView1.DataSource = personnelRepository.SummaryList();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int selectedId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            selectedPersonnel = personnelRepository.FindById(selectedId);
            txtName.Text = selectedPersonnel.Name;
            txtSurName.Text = selectedPersonnel.SurName;
            txtSalary.Text = selectedPersonnel.Salary.ToString();
            txtHead.Text = selectedPersonnel.GetTitle();
            dateTimePicker1.Value = selectedPersonnel.BirthOfDate;
            cbCity.SelectedValue = selectedPersonnel.District.CityId;
            cbDistrict.SelectedValue = selectedPersonnel.DistrictId;
            cbEducation.SelectedValue = selectedPersonnel.EducationId;
            txtStreet.Text = selectedPersonnel.Street;
            txtAvenue.Text = selectedPersonnel.Avenue;
            txtHouseNumber.Text = selectedPersonnel.HouseNumber;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Personnel personnel = new Personnel();
            personnel.Name = txtName.Text;
            personnel.SurName = txtSurName.Text;
            personnel.Salary = Convert.ToDecimal(txtSalary.Text);
            personnel.BirthOfDate = dateTimePicker1.Value;
            personnel.EducationId = Convert.ToInt32(cbEducation.SelectedValue);
            personnel.DistrictId = Convert.ToInt32(cbDistrict.SelectedValue);
            personnel.Street = txtStreet.Text;
            personnel.Avenue = txtAvenue.Text;
            personnel.HouseNumber = txtHouseNumber.Text;
            personnelRepository.Add(personnel);
            personnelRepository.DbSaveChanges();
            Fill();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            selectedPersonnel.Name = txtName.Text;
            selectedPersonnel.SurName = txtSurName.Text;
            selectedPersonnel.Salary = Convert.ToDecimal(txtSalary.Text);
            selectedPersonnel.BirthOfDate = dateTimePicker1.Value;
            selectedPersonnel.DistrictId = Convert.ToInt32(cbDistrict.SelectedValue);
            selectedPersonnel.EducationId = Convert.ToInt32(cbEducation.SelectedValue);
            selectedPersonnel.Street = txtStreet.Text;
            selectedPersonnel.Avenue = txtAvenue.Text;
            selectedPersonnel.HouseNumber = txtHouseNumber.Text;
            personnelRepository.Update();
            Fill();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            personnelRepository.Delete(selectedPersonnel);
            personnelRepository.DbSaveChanges();
            Fill();
        }

        private void cbCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            DistrictRepository.GetComboBox(cbDistrict,Convert.ToInt32(cbCity.SelectedValue));
        }
    }
}
