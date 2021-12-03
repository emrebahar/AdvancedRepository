namespace IleriRepository
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.definationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.districtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.educationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personnelsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personnelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lecturerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.definationsToolStripMenuItem,
            this.personnelsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1336, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // definationsToolStripMenuItem
            // 
            this.definationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cityToolStripMenuItem,
            this.districtToolStripMenuItem,
            this.educationToolStripMenuItem});
            this.definationsToolStripMenuItem.Name = "definationsToolStripMenuItem";
            this.definationsToolStripMenuItem.Size = new System.Drawing.Size(99, 24);
            this.definationsToolStripMenuItem.Text = "Definations";
            // 
            // cityToolStripMenuItem
            // 
            this.cityToolStripMenuItem.Name = "cityToolStripMenuItem";
            this.cityToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.cityToolStripMenuItem.Text = "City";
            this.cityToolStripMenuItem.Click += new System.EventHandler(this.cityToolStripMenuItem_Click);
            // 
            // districtToolStripMenuItem
            // 
            this.districtToolStripMenuItem.Name = "districtToolStripMenuItem";
            this.districtToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.districtToolStripMenuItem.Text = "District";
            this.districtToolStripMenuItem.Click += new System.EventHandler(this.districtToolStripMenuItem_Click);
            // 
            // educationToolStripMenuItem
            // 
            this.educationToolStripMenuItem.Name = "educationToolStripMenuItem";
            this.educationToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.educationToolStripMenuItem.Text = "Education";
            this.educationToolStripMenuItem.Click += new System.EventHandler(this.educationToolStripMenuItem_Click);
            // 
            // personnelsToolStripMenuItem
            // 
            this.personnelsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personnelToolStripMenuItem,
            this.lecturerToolStripMenuItem,
            this.studentToolStripMenuItem});
            this.personnelsToolStripMenuItem.Name = "personnelsToolStripMenuItem";
            this.personnelsToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.personnelsToolStripMenuItem.Text = "Personnels";
            // 
            // personnelToolStripMenuItem
            // 
            this.personnelToolStripMenuItem.Name = "personnelToolStripMenuItem";
            this.personnelToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.personnelToolStripMenuItem.Text = "Personnel";
            this.personnelToolStripMenuItem.Click += new System.EventHandler(this.personnelToolStripMenuItem_Click);
            // 
            // lecturerToolStripMenuItem
            // 
            this.lecturerToolStripMenuItem.Name = "lecturerToolStripMenuItem";
            this.lecturerToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.lecturerToolStripMenuItem.Text = "Lecturer";
            this.lecturerToolStripMenuItem.Click += new System.EventHandler(this.lecturerToolStripMenuItem_Click);
            // 
            // studentToolStripMenuItem
            // 
            this.studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            this.studentToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.studentToolStripMenuItem.Text = "Student";
            this.studentToolStripMenuItem.Click += new System.EventHandler(this.studentToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1336, 501);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem definationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem districtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem educationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personnelsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personnelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lecturerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem;
    }
}

