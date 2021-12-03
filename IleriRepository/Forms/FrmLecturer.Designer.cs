
namespace IleriRepository.Forms
{
    partial class FrmLecturer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtHead = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cbDistrict = new System.Windows.Forms.ComboBox();
            this.cbCity = new System.Windows.Forms.ComboBox();
            this.cbEducation = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSurName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtHouseNumber = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAvenue = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(1196, 307);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(99, 39);
            this.btnDelete.TabIndex = 38;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnUpdate.Location = new System.Drawing.Point(1196, 244);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(99, 39);
            this.btnUpdate.TabIndex = 37;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Lime;
            this.btnAdd.Location = new System.Drawing.Point(1196, 184);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(99, 39);
            this.btnAdd.TabIndex = 36;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtHead
            // 
            this.txtHead.Location = new System.Drawing.Point(909, 35);
            this.txtHead.Name = "txtHead";
            this.txtHead.Size = new System.Drawing.Size(318, 22);
            this.txtHead.TabIndex = 35;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(990, 228);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(162, 22);
            this.dateTimePicker1.TabIndex = 34;
            // 
            // cbDistrict
            // 
            this.cbDistrict.FormattingEnabled = true;
            this.cbDistrict.Location = new System.Drawing.Point(990, 341);
            this.cbDistrict.Name = "cbDistrict";
            this.cbDistrict.Size = new System.Drawing.Size(162, 24);
            this.cbDistrict.TabIndex = 33;
            // 
            // cbCity
            // 
            this.cbCity.FormattingEnabled = true;
            this.cbCity.Location = new System.Drawing.Point(990, 304);
            this.cbCity.Name = "cbCity";
            this.cbCity.Size = new System.Drawing.Size(162, 24);
            this.cbCity.TabIndex = 32;
            this.cbCity.SelectedIndexChanged += new System.EventHandler(this.cbCity_SelectedIndexChanged);
            // 
            // cbEducation
            // 
            this.cbEducation.FormattingEnabled = true;
            this.cbEducation.Location = new System.Drawing.Point(990, 266);
            this.cbEducation.Name = "cbEducation";
            this.cbEducation.Size = new System.Drawing.Size(162, 24);
            this.cbEducation.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(906, 344);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 17);
            this.label7.TabIndex = 30;
            this.label7.Text = "District";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(906, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 17);
            this.label5.TabIndex = 29;
            this.label5.Text = "City";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(906, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 17);
            this.label6.TabIndex = 28;
            this.label6.Text = "Education";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(906, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 27;
            this.label3.Text = "BirtOfDate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(906, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "Salary";
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(990, 192);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(162, 22);
            this.txtSalary.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(906, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "SurName";
            // 
            // txtSurName
            // 
            this.txtSurName.Location = new System.Drawing.Point(990, 114);
            this.txtSurName.Name = "txtSurName";
            this.txtSurName.Size = new System.Drawing.Size(162, 22);
            this.txtSurName.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(906, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(990, 76);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(162, 22);
            this.txtName.TabIndex = 21;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(815, 340);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(906, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 17);
            this.label8.TabIndex = 40;
            this.label8.Text = "Title";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(990, 153);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(162, 22);
            this.txtTitle.TabIndex = 39;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(906, 461);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 17);
            this.label10.TabIndex = 58;
            this.label10.Text = "House No";
            // 
            // txtHouseNumber
            // 
            this.txtHouseNumber.Location = new System.Drawing.Point(990, 458);
            this.txtHouseNumber.Name = "txtHouseNumber";
            this.txtHouseNumber.Size = new System.Drawing.Size(162, 22);
            this.txtHouseNumber.TabIndex = 57;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(906, 423);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 17);
            this.label9.TabIndex = 56;
            this.label9.Text = "Avenue";
            // 
            // txtAvenue
            // 
            this.txtAvenue.Location = new System.Drawing.Point(990, 420);
            this.txtAvenue.Name = "txtAvenue";
            this.txtAvenue.Size = new System.Drawing.Size(162, 22);
            this.txtAvenue.TabIndex = 55;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(906, 384);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 17);
            this.label11.TabIndex = 54;
            this.label11.Text = "Street";
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(990, 381);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(162, 22);
            this.txtStreet.TabIndex = 53;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(17, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(183, 29);
            this.label12.TabIndex = 59;
            this.label12.Text = "Lecturer Panel";
            // 
            // FrmLecturer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1335, 558);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtHouseNumber);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtAvenue);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtStreet);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtHead);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cbDistrict);
            this.Controls.Add(this.cbCity);
            this.Controls.Add(this.cbEducation);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSurName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmLecturer";
            this.Text = "FrmLecturer";
            this.Load += new System.EventHandler(this.FrmLecturer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtHead;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cbDistrict;
        private System.Windows.Forms.ComboBox cbCity;
        private System.Windows.Forms.ComboBox cbEducation;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSurName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtHouseNumber;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAvenue;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.Label label12;
    }
}