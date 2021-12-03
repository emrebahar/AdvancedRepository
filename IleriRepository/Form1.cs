using IleriRepository.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IleriRepository
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCity frmCity = new FrmCity();
            frmCity.Show();
        }

        private void districtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDistrict frmDistrict = new FrmDistrict();
            frmDistrict.Show();
        }

        private void educationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEducation frmEducation = new FrmEducation();
            frmEducation.Show();
        }

        private void personnelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPersonnel frmPersonnel = new FrmPersonnel();
            frmPersonnel.Show();
        }

        private void lecturerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLecturer frmLecturer = new FrmLecturer();
            frmLecturer.Show();
        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmStudent frmStudent = new FrmStudent();
            frmStudent.Show();
        }
    }
}
