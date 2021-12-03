using IleriRepository.Concrete;
using IleriRepository.DTO;
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
    public partial class FrmEducation : Form
    {
        public FrmEducation()
        {
            InitializeComponent();
        }

        EducationRepository educationRepository = new EducationRepository();
        Education selectedEducation = new Education();
        private void FrmEducation_Load(object sender, EventArgs e)
        {
            Fill();
        }

        private void Fill()
        {
            dataGridView1.DataSource = educationRepository.SummaryList();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int selectedId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            selectedEducation = educationRepository.FindById(selectedId);
            txtName.Text = selectedEducation.Name;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Education education = new Education();
            education.Name = txtName.Text;
            educationRepository.Add(education);
            educationRepository.DbSaveChanges();
            Fill();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            selectedEducation.Name = txtName.Text;
            educationRepository.Update();
            Fill();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            educationRepository.Delete(selectedEducation);
            educationRepository.DbSaveChanges();
            Fill();
        }
    }
}
