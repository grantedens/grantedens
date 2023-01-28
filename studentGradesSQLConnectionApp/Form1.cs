using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Project4fr
{
    public partial class Form1 : Form
    {
        DataTable dtStudents = new DataTable();
        DataTable dtColleges = new DataTable();
        DataTable dtMajors = new DataTable();
        DataTable dtGradelist = new DataTable();
   

        public Form1()
        {
            InitializeComponent();
        }

        private void ShowStudentMenu()
        {
            pboxOldMain.Hide();
            gradesPnl.Hide();
            pnlStudents.Show();
        }

        private void ShowMainMenu()
        {
            pboxOldMain.Show();
            pnlStudents.Hide();
            gradesPnl.Hide();
        }
        private void ShowGradeMenu()
        {
            pboxOldMain.Hide();
            gradesPnl.Show();
            pnlStudents.Hide();
        }

        private void RefreshCollegeComboBox()
        {
            cmbCollege.Items.Clear();
            string sqlColleges = "SELECT CollegeID, College FROM tbl_Colleges order by CollegeID";

            if (Walton_DB.FillDataTable_ViaSql(ref dtColleges, sqlColleges) == true)
            {
                foreach (DataRow row in dtColleges.Rows)
                {
                    cmbCollege.Items.Add(row["College"]);
                }
            }
            else
            {
                MessageBox.Show("An error occured");
            }
        }

        private void FillStudentDGV()
        {

            //string sqlStudents = "SELECT StudentID, StudentName FROM tbl_Students order by StudentName";
            string sqlStudents = "SELECT tbl_Students.StudentID, tbl_Students.StudentName, tbl_Colleges.College, tbl_Majors.Major FROM tbl_Students INNER JOIN tbl_Colleges ON tbl_Students.StudentCollege = tbl_Colleges.CollegeID INNER JOIN tbl_Majors ON tbl_Students.StudentMajor = tbl_Majors.MajorID";
            if (Walton_DB.FillDataTable_ViaSql(ref dtStudents, sqlStudents) == true)
            {
                dgvStudents.DataSource = dtStudents;
                dgvStudents.Refresh();
            }
            else
            {
                MessageBox.Show("An error occurred while populating the college drop down list");
            }
        }

        private void FillGradeDGV()
        {

            string sqlGrade = "SELECT tbl_Students.StudentName, tbl_Courses.Course, tbl_Terms.Term, tbl_Grades.Grade FROM tbl_Grades INNER JOIN tbl_Students ON tbl_Grades.Student = tbl_Students.StudentID INNER JOIN tbl_Courses ON tbl_Grades.Course = tbl_Courses.CourseID INNER JOIN tbl_Terms ON tbl_Grades.Term = tbl_Terms.TermID";
            if (Walton_DB.FillDataTable_ViaSql(ref dtGradelist, sqlGrade) == true)
            {
                dgvGrades.DataSource = dtGradelist;
                dgvGrades.Refresh();
            }
            else
            {
                MessageBox.Show("An error occurred while populating the grade drop down list");
            }
        }

        private void RefreshMajorComboBox()
        {

            int collegeID = 0;
            cmbMajors.Items.Clear();

            if (cmbCollege.SelectedIndex != -1)
            {
                collegeID = int.Parse(dtColleges.Select("College = '" + cmbCollege.Text + "'")[0]["CollegeID"].ToString());


                string sqlMajors = "SELECT MajorID, Major FROM tbl_Majors where CollegeID = " + collegeID.ToString();
                //DataTable dtMajors = new DataTable();

                if (Walton_DB.FillDataTable_ViaSql(ref dtMajors, sqlMajors) == true)
                {
                    foreach (DataRow row in dtMajors.Rows)
                    {
                        cmbMajors.Items.Add(row["Major"]);
                    }
                }
                else
                {
                    MessageBox.Show("An error occurred while populating the majors combo box");

                }
            }
}

        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pboxOldMain.Hide();
            gradesPnl.Hide();
            pnlStudents.Show();
            RefreshCollegeComboBox();
            ShowStudentMenu();
            FillStudentDGV();
        }

        private void addStudent()
        {
            string studentName;
            if (txtName.Text.Trim() == "")
            {
                MessageBox.Show("You must enter a name you fool");
                return;
            }
            else
            {
                studentName = txtName.Text;
            }
            int majorID = 0;
            int collegeID = 0;
            if (cmbCollege.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a college");
                return;
            }
            else
            {
                collegeID = int.Parse(dtColleges.Select("College = '" + cmbCollege.Text + "'")[0]["CollegeID"].ToString());

            }

            if (cmbMajors.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a major");
                return;
            }
            else
            {
                majorID = int.Parse(dtMajors.Select("Major = '" + cmbMajors.Text + "'")[0]["MajorID"].ToString());

            }

            Walton_DB.ExecSqlString("Insert into tbl_Students (StudentName, StudentCollege, StudentMajor) Values ('" + studentName + "'," + collegeID.ToString() + "," + majorID.ToString() + ")");



            FillStudentDGV();
        }

        DataTable dtTerm = new DataTable();
        private void refreshTermComboBox()
        {
            termCmb.Items.Clear();
            string sqlTerm = "SELECT TermID, Term FROM tbl_Terms order by Term";

            if (Walton_DB.FillDataTable_ViaSql(ref dtTerm, sqlTerm) == true)
            {
                foreach (DataRow row in dtTerm.Rows)
                {
                    termCmb.Items.Add(row["Term"]);
                }
            }
            else
            {
                MessageBox.Show("An error occured");
            }
        }

        private void refreshStudentComboBox()
        {
            studentCmb.Items.Clear();
            string sqlStudents = "SELECT StudentID, StudentName FROM tbl_Students order by StudentName";

            if (Walton_DB.FillDataTable_ViaSql(ref dtStudents, sqlStudents) == true)
            {
                foreach (DataRow row in dtStudents.Rows)
                {
                    studentCmb.Items.Add(row["StudentName"]);
                }
            }
            else
            {
                MessageBox.Show("An error occured while populating the student drop down list");
            }
        }

        private void refreshGradeComboBox()
        {
            gradeCmb.Items.Clear();
            gradeCmb.Items.Add("A");
            gradeCmb.Items.Add("B");
            gradeCmb.Items.Add("C");
            gradeCmb.Items.Add("D");
            gradeCmb.Items.Add("F");

        }
        DataTable dtCourses = new DataTable();
        private void refreshCourseComboBox()
        {
            courseCmb.Items.Clear();
            string sqlCourses = "SELECT CourseID, Course FROM tbl_Courses order by Course";

            if (Walton_DB.FillDataTable_ViaSql(ref dtCourses, sqlCourses) == true)
            {
                foreach (DataRow row in dtCourses.Rows)
                {
                    courseCmb.Items.Add(row["Course"]);
                }
            }
            else
            {
                MessageBox.Show("An error occured while populating the course drop down list");
            }
        }

        private void AddGrade()
        {
            int StudentID = 0;
            int CourseID = 0;
            int TermID = 0;
            string Grade = "";
            if (studentCmb.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a student");
                return;
            }
            else
            {
                StudentID = int.Parse(dtStudents.Select("StudentName = '" + studentCmb.Text + "'")[0]["StudentID"].ToString());
                
            }

            if (termCmb.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a term");
                return;
            }
            else
            {
                TermID = int.Parse(dtTerm.Select("Term = '" + termCmb.Text + "'")[0]["TermID"].ToString());
               
            }
            if (courseCmb.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a course");
                return;
            }
            else
            {
                CourseID = int.Parse(dtCourses.Select("Course = '" + courseCmb.Text + "'")[0]["CourseID"].ToString());
               
            }
            if (gradeCmb.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a grade");
                return;
            }
            else
            {
                Grade = gradeCmb.Text;
               
            }

            Walton_DB.ExecSqlString("INSERT INTO tbl_Grades (Student, Course, Term, Grade) VALUES (" + StudentID.ToString() + "," + CourseID.ToString() + "," + TermID.ToString() + ",'" + Grade + "')");
         


        }



        private void Form1_Load(object sender, EventArgs e)
        {
            ShowMainMenu();
            
        }

        private void pnlStudents_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbCollege_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshMajorComboBox();
        }

        private void pboxOldMain_Click(object sender, EventArgs e)
        {

        }

        private void lblMajor_Click(object sender, EventArgs e)
        {

        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowMainMenu();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gradesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowGradeMenu();
            refreshStudentComboBox();
            refreshTermComboBox();
            refreshGradeComboBox();
            refreshCourseComboBox();
            FillGradeDGV();
        }

        private void studentBtn_Click(object sender, EventArgs e)
        {
            addStudent();
            FillStudentDGV();
        }

        private void gradesBtn_Click(object sender, EventArgs e)
        {
            AddGrade();
            FillGradeDGV();
        }
    }
}