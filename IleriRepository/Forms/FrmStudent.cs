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
    public partial class FrmStudent : Form
    {
        public FrmStudent()
        {
            InitializeComponent();
        }
        readonly StudentRepository studentRepository = new StudentRepository();
        readonly DistrictRepository districtRepository = new DistrictRepository();
        readonly EducationRepository educationRepository = new EducationRepository();
        readonly CityRepository cityRepository = new CityRepository();
        readonly TeacherRepository teacherRepository = new TeacherRepository();
        Student selectedStudent = new Student();
        private void FrmStudent_Load(object sender, EventArgs e)
        {
            Fill();
            FillCbCity();
            FillCbEducation();
            FillCbTeacher();
        }

        private void FillCbTeacher()
        {
            teacherRepository.GetComboBox(cbTeacher);
        }

        private void FillCbEducation()
        {
            educationRepository.GetComboBox(cbEducation);
        }

        private void FillCbCity()
        {
            cityRepository.GetComboBox(cbCity);
        }

        private void Fill()
        {
            dataGridView1.DataSource = studentRepository.SummaryList();
        }

        private void cbCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            districtRepository.GetComboBox(cbDistrict, Convert.ToInt32(cbCity.SelectedValue));
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            selectedStudent = studentRepository.FindById(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
            txtHead.Text = selectedStudent.GetTitle();
            txtName.Text = selectedStudent.Name;
            txtSurName.Text = selectedStudent.SurName;
            dateTimePicker1.Value = selectedStudent.BirthOfDate;
            cbEducation.SelectedValue = selectedStudent.EducationId;
            cbCity.SelectedValue = selectedStudent.District.CityId;
            cbDistrict.SelectedValue = selectedStudent.DistrictId;
            cbTeacher.SelectedValue = selectedStudent.TeacherId;
            txtStreet.Text = selectedStudent.Street;
            txtAvenue.Text = selectedStudent.Avenue;
            txtHouseNumber.Text = selectedStudent.HouseNumber;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.Name = txtName.Text;
            student.SurName = txtSurName.Text;
            student.BirthOfDate = dateTimePicker1.Value;
            student.EducationId = Convert.ToInt32(cbEducation.SelectedValue);
            student.DistrictId = Convert.ToInt32(cbDistrict.SelectedValue);
            student.TeacherId = Convert.ToInt32(cbTeacher.SelectedValue);
            student.Street = txtStreet.Text;
            student.Avenue = txtAvenue.Text;
            student.HouseNumber = txtHouseNumber.Text;
            studentRepository.Add(student);
            studentRepository.DbSaveChanges();
            Fill();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            selectedStudent.Name = txtName.Text;
            selectedStudent.SurName = txtSurName.Text;
            selectedStudent.BirthOfDate = dateTimePicker1.Value;
            selectedStudent.EducationId = Convert.ToInt32(cbEducation.SelectedValue);
            selectedStudent.District.CityId = Convert.ToInt32(cbCity.SelectedValue);
            selectedStudent.DistrictId = Convert.ToInt32(cbDistrict.SelectedValue);
            selectedStudent.TeacherId = Convert.ToInt32(cbTeacher.SelectedValue);
            selectedStudent.Street = txtStreet.Text;
            selectedStudent.Avenue = txtAvenue.Text;
            selectedStudent.HouseNumber = txtHouseNumber.Text;
            studentRepository.Update();
            Fill();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            studentRepository.Delete(selectedStudent);
            studentRepository.DbSaveChanges();
            Fill();
        }
    }
}
