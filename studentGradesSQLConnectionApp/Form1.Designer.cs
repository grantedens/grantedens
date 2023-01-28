namespace Project4fr
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlStudents = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.StudentGb = new System.Windows.Forms.GroupBox();
            this.studentBtn = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblMajor = new System.Windows.Forms.Label();
            this.lblCollege = new System.Windows.Forms.Label();
            this.cmbCollege = new System.Windows.Forms.ComboBox();
            this.cmbMajors = new System.Windows.Forms.ComboBox();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.pboxOldMain = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gradesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gradesPnl = new System.Windows.Forms.Panel();
            this.gradelbl = new System.Windows.Forms.Label();
            this.dgvGrades = new System.Windows.Forms.DataGridView();
            this.gradesGb = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.termCmb = new System.Windows.Forms.ComboBox();
            this.gradeCmb = new System.Windows.Forms.ComboBox();
            this.courseCmb = new System.Windows.Forms.ComboBox();
            this.studentCmb = new System.Windows.Forms.ComboBox();
            this.gradesBtn = new System.Windows.Forms.Button();
            this.pnlStudents.SuspendLayout();
            this.StudentGb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxOldMain)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.gradesPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrades)).BeginInit();
            this.gradesGb.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlStudents
            // 
            this.pnlStudents.Controls.Add(this.label5);
            this.pnlStudents.Controls.Add(this.StudentGb);
            this.pnlStudents.Controls.Add(this.dgvStudents);
            this.pnlStudents.Location = new System.Drawing.Point(12, 27);
            this.pnlStudents.Name = "pnlStudents";
            this.pnlStudents.Size = new System.Drawing.Size(522, 435);
            this.pnlStudents.TabIndex = 0;
            this.pnlStudents.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlStudents_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "STUDENTS";
            // 
            // StudentGb
            // 
            this.StudentGb.Controls.Add(this.studentBtn);
            this.StudentGb.Controls.Add(this.txtName);
            this.StudentGb.Controls.Add(this.lblName);
            this.StudentGb.Controls.Add(this.lblMajor);
            this.StudentGb.Controls.Add(this.lblCollege);
            this.StudentGb.Controls.Add(this.cmbCollege);
            this.StudentGb.Controls.Add(this.cmbMajors);
            this.StudentGb.Location = new System.Drawing.Point(71, 58);
            this.StudentGb.Name = "StudentGb";
            this.StudentGb.Size = new System.Drawing.Size(259, 176);
            this.StudentGb.TabIndex = 8;
            this.StudentGb.TabStop = false;
            this.StudentGb.Text = "Add Student";
            // 
            // studentBtn
            // 
            this.studentBtn.Location = new System.Drawing.Point(43, 145);
            this.studentBtn.Name = "studentBtn";
            this.studentBtn.Size = new System.Drawing.Size(117, 23);
            this.studentBtn.TabIndex = 7;
            this.studentBtn.Text = "Add student";
            this.studentBtn.UseVisualStyleBackColor = true;
            this.studentBtn.Click += new System.EventHandler(this.studentBtn_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(82, 40);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(166, 23);
            this.txtName.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 43);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(42, 15);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name:";
            // 
            // lblMajor
            // 
            this.lblMajor.AutoSize = true;
            this.lblMajor.Location = new System.Drawing.Point(6, 74);
            this.lblMajor.Name = "lblMajor";
            this.lblMajor.Size = new System.Drawing.Size(41, 15);
            this.lblMajor.TabIndex = 2;
            this.lblMajor.Text = "Major:";
            this.lblMajor.Click += new System.EventHandler(this.lblMajor_Click);
            // 
            // lblCollege
            // 
            this.lblCollege.AutoSize = true;
            this.lblCollege.Location = new System.Drawing.Point(6, 120);
            this.lblCollege.Name = "lblCollege";
            this.lblCollege.Size = new System.Drawing.Size(50, 15);
            this.lblCollege.TabIndex = 5;
            this.lblCollege.Text = "College:";
            // 
            // cmbCollege
            // 
            this.cmbCollege.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCollege.FormattingEnabled = true;
            this.cmbCollege.Location = new System.Drawing.Point(82, 117);
            this.cmbCollege.Name = "cmbCollege";
            this.cmbCollege.Size = new System.Drawing.Size(121, 23);
            this.cmbCollege.TabIndex = 6;
            this.cmbCollege.SelectedIndexChanged += new System.EventHandler(this.cmbCollege_SelectedIndexChanged);
            // 
            // cmbMajors
            // 
            this.cmbMajors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMajors.FormattingEnabled = true;
            this.cmbMajors.Location = new System.Drawing.Point(82, 74);
            this.cmbMajors.Name = "cmbMajors";
            this.cmbMajors.Size = new System.Drawing.Size(121, 23);
            this.cmbMajors.TabIndex = 4;
            // 
            // dgvStudents
            // 
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Location = new System.Drawing.Point(71, 240);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.RowTemplate.Height = 25;
            this.dgvStudents.Size = new System.Drawing.Size(344, 169);
            this.dgvStudents.TabIndex = 7;
            // 
            // pboxOldMain
            // 
            this.pboxOldMain.Image = global::Project4fr.Properties.Resources.oldmain;
            this.pboxOldMain.Location = new System.Drawing.Point(0, 30);
            this.pboxOldMain.Name = "pboxOldMain";
            this.pboxOldMain.Size = new System.Drawing.Size(1263, 468);
            this.pboxOldMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxOldMain.TabIndex = 0;
            this.pboxOldMain.TabStop = false;
            this.pboxOldMain.Click += new System.EventHandler(this.pboxOldMain_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.studentsToolStripMenuItem,
            this.gradesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1263, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenuToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // mainMenuToolStripMenuItem
            // 
            this.mainMenuToolStripMenuItem.Name = "mainMenuToolStripMenuItem";
            this.mainMenuToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.mainMenuToolStripMenuItem.Text = "Main Menu";
            this.mainMenuToolStripMenuItem.Click += new System.EventHandler(this.mainMenuToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // studentsToolStripMenuItem
            // 
            this.studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            this.studentsToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.studentsToolStripMenuItem.Text = "Students";
            this.studentsToolStripMenuItem.Click += new System.EventHandler(this.studentsToolStripMenuItem_Click);
            // 
            // gradesToolStripMenuItem
            // 
            this.gradesToolStripMenuItem.Name = "gradesToolStripMenuItem";
            this.gradesToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.gradesToolStripMenuItem.Text = "Grades";
            this.gradesToolStripMenuItem.Click += new System.EventHandler(this.gradesToolStripMenuItem_Click);
            // 
            // gradesPnl
            // 
            this.gradesPnl.Controls.Add(this.gradelbl);
            this.gradesPnl.Controls.Add(this.dgvGrades);
            this.gradesPnl.Controls.Add(this.gradesGb);
            this.gradesPnl.Location = new System.Drawing.Point(698, 39);
            this.gradesPnl.Name = "gradesPnl";
            this.gradesPnl.Size = new System.Drawing.Size(487, 393);
            this.gradesPnl.TabIndex = 2;
            // 
            // gradelbl
            // 
            this.gradelbl.AutoSize = true;
            this.gradelbl.Location = new System.Drawing.Point(49, 5);
            this.gradelbl.Name = "gradelbl";
            this.gradelbl.Size = new System.Drawing.Size(50, 15);
            this.gradelbl.TabIndex = 2;
            this.gradelbl.Text = "GRADES";
            // 
            // dgvGrades
            // 
            this.dgvGrades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrades.Location = new System.Drawing.Point(131, 228);
            this.dgvGrades.Name = "dgvGrades";
            this.dgvGrades.RowTemplate.Height = 25;
            this.dgvGrades.Size = new System.Drawing.Size(240, 150);
            this.dgvGrades.TabIndex = 1;
            // 
            // gradesGb
            // 
            this.gradesGb.Controls.Add(this.label4);
            this.gradesGb.Controls.Add(this.label3);
            this.gradesGb.Controls.Add(this.label2);
            this.gradesGb.Controls.Add(this.label1);
            this.gradesGb.Controls.Add(this.termCmb);
            this.gradesGb.Controls.Add(this.gradeCmb);
            this.gradesGb.Controls.Add(this.courseCmb);
            this.gradesGb.Controls.Add(this.studentCmb);
            this.gradesGb.Controls.Add(this.gradesBtn);
            this.gradesGb.Location = new System.Drawing.Point(46, 27);
            this.gradesGb.Name = "gradesGb";
            this.gradesGb.Size = new System.Drawing.Size(266, 177);
            this.gradesGb.TabIndex = 0;
            this.gradesGb.TabStop = false;
            this.gradesGb.Text = "Add Grade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Term";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Grade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Course";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Student";
            // 
            // termCmb
            // 
            this.termCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.termCmb.FormattingEnabled = true;
            this.termCmb.Location = new System.Drawing.Point(129, 104);
            this.termCmb.Name = "termCmb";
            this.termCmb.Size = new System.Drawing.Size(121, 23);
            this.termCmb.TabIndex = 4;
            // 
            // gradeCmb
            // 
            this.gradeCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gradeCmb.FormattingEnabled = true;
            this.gradeCmb.Location = new System.Drawing.Point(130, 76);
            this.gradeCmb.Name = "gradeCmb";
            this.gradeCmb.Size = new System.Drawing.Size(121, 23);
            this.gradeCmb.TabIndex = 3;
            // 
            // courseCmb
            // 
            this.courseCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.courseCmb.FormattingEnabled = true;
            this.courseCmb.Location = new System.Drawing.Point(130, 49);
            this.courseCmb.Name = "courseCmb";
            this.courseCmb.Size = new System.Drawing.Size(121, 23);
            this.courseCmb.TabIndex = 2;
            // 
            // studentCmb
            // 
            this.studentCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.studentCmb.FormattingEnabled = true;
            this.studentCmb.Location = new System.Drawing.Point(128, 20);
            this.studentCmb.Name = "studentCmb";
            this.studentCmb.Size = new System.Drawing.Size(121, 23);
            this.studentCmb.TabIndex = 1;
            // 
            // gradesBtn
            // 
            this.gradesBtn.Location = new System.Drawing.Point(42, 147);
            this.gradesBtn.Name = "gradesBtn";
            this.gradesBtn.Size = new System.Drawing.Size(75, 23);
            this.gradesBtn.TabIndex = 0;
            this.gradesBtn.Text = "Add grade";
            this.gradesBtn.UseVisualStyleBackColor = true;
            this.gradesBtn.Click += new System.EventHandler(this.gradesBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 510);
            this.Controls.Add(this.pboxOldMain);
            this.Controls.Add(this.pnlStudents);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.gradesPnl);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlStudents.ResumeLayout(false);
            this.pnlStudents.PerformLayout();
            this.StudentGb.ResumeLayout(false);
            this.StudentGb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxOldMain)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gradesPnl.ResumeLayout(false);
            this.gradesPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrades)).EndInit();
            this.gradesGb.ResumeLayout(false);
            this.gradesGb.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel pnlStudents;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem studentsToolStripMenuItem;
        private ToolStripMenuItem gradesToolStripMenuItem;
        private PictureBox pboxOldMain;
        private ComboBox cmbCollege;
        private Label lblCollege;
        private ComboBox cmbMajors;
        private TextBox txtName;
        private Label lblMajor;
        private Label lblName;
        private ToolStripMenuItem mainMenuToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private DataGridView dgvStudents;
        private GroupBox StudentGb;
        private Button studentBtn;
        private Panel gradesPnl;
        private DataGridView dgvGrades;
        private GroupBox gradesGb;
        private Button gradesBtn;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox termCmb;
        private ComboBox gradeCmb;
        private ComboBox courseCmb;
        private ComboBox studentCmb;
        private Label label5;
        private Label gradelbl;
    }
}