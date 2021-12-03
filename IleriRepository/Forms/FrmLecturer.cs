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
    public partial class FrmLecturer : Form
    {
        public FrmLecturer()
        {
            InitializeComponent();
        }
        readonly TeacherRepository teacherRepository = new TeacherRepository();
        readonly CityRepository cityRepository = new CityRepository();
        readonly DistrictRepository districtRepository = new DistrictRepository();
        readonly EducationRepository educationRepository = new EducationRepository();
        Lecturer selectedTeacher = new Lecturer();
        private void FrmLecturer_Load(object sender, EventArgs e)
        {
            Fill();
            FillCbCity();
            FillCbEducation();
        }

        private void FillCbCity()
        {
            cityRepository.GetComboBox(cbCity);
        }

        private void FillCbEducation()
        {
            educationRepository.GetComboBox(cbEducation);
        }

        private void Fill()
        {
            dataGridView1.DataSource = teacherRepository.SummaryList();
        }

        private void cbCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            districtRepository.GetComboBox(cbDistrict,Convert.ToInt32(cbCity.SelectedValue));
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            selectedTeacher = teacherRepository.FindById(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
            txtHead.Text = selectedTeacher.GetTitle();
            txtName.Text = selectedTeacher.Name;
            txtSurName.Text = selectedTeacher.SurName;
            txtSalary.Text = selectedTeacher.Salary.ToString();
            txtTitle.Text = selectedTeacher.AcademicTitle;
            dateTimePicker1.Value = selectedTeacher.BirthOfDate;
            cbEducation.SelectedValue = selectedTeacher.EducationId;
            cbCity.SelectedValue = selectedTeacher.District.CityId;
            cbDistrict.SelectedValue = selectedTeacher.DistrictId;
            txtStreet.Text = selectedTeacher.Street;
            txtAvenue.Text = selectedTeacher.Avenue;
            txtHouseNumber.Text = selectedTeacher.HouseNumber;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Lecturer teacher = new Lecturer();
            teacher.Name = txtName.Text;
            teacher.SurName = txtSurName.Text;
            teacher.Salary = Convert.ToDecimal(txtSalary.Text);
            teacher.AcademicTitle = txtTitle.Text;
            teacher.BirthOfDate = dateTimePicker1.Value;
            teacher.EducationId = Convert.ToInt32(cbEducation.SelectedValue);
            teacher.DistrictId = Convert.ToInt32(cbDistrict.SelectedValue);
            teacher.Street = txtStreet.Text;
            teacher.Avenue = txtAvenue.Text;
            teacher.HouseNumber = txtHouseNumber.Text;
            teacherRepository.Add(teacher);
            teacherRepository.DbSaveChanges();
            Fill();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            selectedTeacher.Name = txtName.Text;
            selectedTeacher.SurName = txtSurName.Text;
            selectedTeacher.AcademicTitle = txtTitle.Text;
            selectedTeacher.Salary = Convert.ToDecimal(txtSalary.Text);
            selectedTeacher.BirthOfDate = dateTimePicker1.Value;
            selectedTeacher.EducationId = Convert.ToInt32(cbEducation.SelectedValue);
            selectedTeacher.DistrictId = Convert.ToInt32(cbDistrict.SelectedValue);
            selectedTeacher.Street = txtStreet.Text;
            selectedTeacher.Avenue = txtAvenue.Text;
            selectedTeacher.HouseNumber = txtHouseNumber.Text;
            teacherRepository.Update();
            Fill();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            teacherRepository.Delete(selectedTeacher);
            teacherRepository.DbSaveChanges();
            Fill();
        }
    }
}
