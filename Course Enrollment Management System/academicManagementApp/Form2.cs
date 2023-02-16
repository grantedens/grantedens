using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Data.SqlTypes;

namespace academicManagementApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public void setDatagrid(string table)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=essql1.walton.uark.edu;Initial Catalog=PROJECTS2354;User ID=PROJECTS2354;Password=GohogsUA1"))
            {
                if (table == "students")
                {
                    if (recordCmb.SelectedIndex == -1)
                    {
                        using (SqlCommand command = new SqlCommand("SELECT * FROM students", connection))
                        {

                            // Create a DataTable to store the results
                            DataTable dataTable = new DataTable();

                            // Load the data into the DataTable
                            using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                            {
                                dataAdapter.Fill(dataTable);
                            }

                            // Set the DataSource property of the DataGridView to the DataTable
                            displayDGV.DataSource = dataTable;
                        }
                    }
                    else
                    {
                        string sqlString = "select classes.class_id, classes.class_name, classes.class_number, classes.meeting_time, classes.room_number, classes.instructor_id, classes.instructor_name, enrollments.enrollment_id\r\nfrom enrollments\r\njoin classes on enrollments.class_id = classes.class_id\r\nwhere student_id = " + tbOne.Text + ";";
                        using (SqlCommand command = new SqlCommand(sqlString, connection))
                        {

                            // Create a DataTable to store the results
                            DataTable dataTable = new DataTable();

                            // Load the data into the DataTable
                            using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                            {
                                dataAdapter.Fill(dataTable);
                            }

                            // Set the DataSource property of the DataGridView to the DataTable
                            displayDGV.DataSource = dataTable;
                        }
                    }
                }
                else if (table == "classes")
                {
                    if (recordCmb.SelectedIndex == -1)
                    {
                        using (SqlCommand command = new SqlCommand("SELECT * FROM classes", connection))
                        {

                            // Create a DataTable to store the results
                            DataTable dataTable = new DataTable();

                            // Load the data into the DataTable
                            using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                            {
                                dataAdapter.Fill(dataTable);
                            }

                            // Set the DataSource property of the DataGridView to the DataTable
                            displayDGV.DataSource = dataTable;
                        }
                    }
                    else
                    {
                        string sqlString = "select students.student_name, students.student_id, students.major, students.grade_level, students.age, enrollments.class_id, enrollments.enrollment_id from enrollments \r\njoin students on enrollments.student_id = students.student_id\r\nwhere class_id = " + tbOne.Text + ";";
                        using (SqlCommand command = new SqlCommand(sqlString, connection))
                        {

                            // Create a DataTable to store the results
                            DataTable dataTable = new DataTable();

                            // Load the data into the DataTable
                            using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                            {
                                dataAdapter.Fill(dataTable);
                            }

                            // Set the DataSource property of the DataGridView to the DataTable
                            displayDGV.DataSource = dataTable;
                        }
                    }
                }
                else if (table == "instructors")
                {
                    if (recordCmb.SelectedIndex == -1)
                    {
                        using (SqlCommand command = new SqlCommand("SELECT * FROM instructors", connection))
                        {

                            // Create a DataTable to store the results
                            DataTable dataTable = new DataTable();

                            // Load the data into the DataTable
                            using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                            {
                                dataAdapter.Fill(dataTable);
                            }

                            // Set the DataSource property of the DataGridView to the DataTable
                            displayDGV.DataSource = dataTable;
                        }
                    }
                    else
                    {
                        string sqlString = "select * from classes where instructor_id = " + tbOne.Text + ";";
                        using (SqlCommand command = new SqlCommand(sqlString, connection))
                        {

                            // Create a DataTable to store the results
                            DataTable dataTable = new DataTable();

                            // Load the data into the DataTable
                            using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                            {
                                dataAdapter.Fill(dataTable);
                            }

                            // Set the DataSource property of the DataGridView to the DataTable
                            displayDGV.DataSource = dataTable;
                        }
                    }
                }
                displayDGV.Refresh();
            }
        }

        public bool editRecord(string tabel)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=essql1.walton.uark.edu;Initial Catalog=PROJECTS2354;User ID=PROJECTS2354;Password=GohogsUA1"))
            {
                connection.Open();
                if (tabel == "students")
                {
                    string updateSql = "update students set student_name = '" + tbTwo.Text + "', major = '" + tbThree.Text + "', grade_level = " + tbFour.Text + ", age = " + tbFive.Text + " where student_id = " + tbOne.Text + ";";
                    using (SqlCommand command = new SqlCommand(updateSql, connection))
                    {
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            setDatagrid("students");
                            return true;
                        }

                    }
                }
                else if (tabel == "classes")
                {
                    string updateSql = "update classes set class_name = '" + tbTwo.Text + "', class_number = '" + tbThree.Text + "', room_number = '" + tbSeven.Text + "', meeting_time = '" + tbFour.Text + "', instructor_name = '" + tbSix.Text + "' where class_id = " + tbOne.Text + ";";
                    using (SqlCommand command = new SqlCommand(updateSql, connection))
                    {
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            setDatagrid("classes");
                            return true;
                        }



                    }
                }


                else if (tabel == "instructors")
                {
                    string updateSql = "update instructors set instructor_name = '" + tbTwo.Text + "' where instructor_id = " + tbOne.Text + ";";
                    using (SqlCommand command = new SqlCommand(updateSql, connection))
                    {
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            setDatagrid("instructors");
                            return true;
                        }

                    }

                }
                return false;

            }
        }



        public bool AddRecord(string tabel)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=essql1.walton.uark.edu;Initial Catalog=PROJECTS2354;User ID=PROJECTS2354;Password=GohogsUA1"))
            {
                connection.Open();
                if (tabel == "students")
                {
                    string insertSql = "INSERT INTO students (student_name, major, grade_level, age) VALUES ('" + fieldOneBox.Text + "', '" + fieldFourBox.Text + "', " + fieldThreeBox.Text + ", " + fieldTwoBox.Text + ");";
                    using (SqlCommand command = new SqlCommand(insertSql, connection))
                    {

                        int rowsInserted = command.ExecuteNonQuery();
                        if (rowsInserted == 1)
                        {
                            fieldOneBox.Text = "";
                            fieldTwoBox.Text = "";
                            fieldThreeBox.Text = "";
                            fieldFourBox.Text = "";
                            fieldFiveBox.Text = "";
                            setDatagrid("students");
                            return true;

                        }
                        else
                        {
                            return false;
                        }

                    }
                }
                else if (tabel == "classes")
                {
                    string insertSql = "INSERT INTO classes (class_name, class_number, instructor_id, room_number, meeting_time, instructor_name) \r\n" +
                        "VALUES ('" + fieldOneBox.Text + "', '" + fieldTwoBox.Text + "', (select instructor_id from instructors where instructor_name = 'Ian White'), '" + fieldFourBox.Text + "', '" + fieldFiveBox.Text + "', '" + fieldThreeBox.Text + "');";
                    using (SqlCommand command = new SqlCommand(insertSql, connection))
                    {

                        int rowsInserted = command.ExecuteNonQuery();
                        if (rowsInserted == 1)
                        {
                            fieldOneBox.Text = "";
                            fieldTwoBox.Text = "";
                            fieldThreeBox.Text = "";
                            fieldFourBox.Text = "";
                            fieldFiveBox.Text = "";
                            setDatagrid("classes");
                            return true;
                        }
                        else
                        {
                            return false;
                        }

                    }
                }


                else if (tabel == "instructors")
                {
                    string insertSql = "INSERT INTO instructors (instructor_name) VALUES ('" + fieldOneBox.Text + "');";
                    using (SqlCommand command = new SqlCommand(insertSql, connection))
                    {

                        int rowsInserted = command.ExecuteNonQuery();
                        if (rowsInserted == 1)
                        {
                            fieldOneBox.Text = "";
                            fieldTwoBox.Text = "";
                            fieldThreeBox.Text = "";
                            fieldFourBox.Text = "";
                            fieldFiveBox.Text = "";
                            setDatagrid("instructors");
                            return true;
                        }
                        else
                        {
                            return false;
                        }

                    }

                }
                else { return false; }

            }
        }
        private void enterBtn_Click(object sender, EventArgs e)
        {
            if (fieldCmb.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a field");
            }
            else if (fieldCmb.SelectedIndex == 0)
            {
                if (AddRecord("students") == true)
                {
                    MessageBox.Show("Record added successfully");
                }
                else
                {
                    MessageBox.Show("Error: Please make sure fields are correct");
                }
            }
            else if (fieldCmb.SelectedIndex == 1)
            {
                if (AddRecord("classes") == true)
                {
                    MessageBox.Show("Record added successfully");
                }
                else
                {
                    MessageBox.Show("Error: Please make sure fields are correct");
                }
            }
            else if (fieldCmb.SelectedIndex == 2)
            {
                if (AddRecord("instructors") == true)
                {
                    MessageBox.Show("Record added successfully");
                    fieldOneBox.Text = "";
                }
                else
                {
                    MessageBox.Show("Error: Please make sure fields are correct");
                }
            }
            displayDGV.Refresh();
        }

        private void tableCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            recordCmb.SelectedIndex = -1;

            if (tableCmb.SelectedIndex == 0)
            {
                fOneLbl.Text = "Student ID: ";
                fTwoLbl.Text = "Student Name: ";
                fThreeLbl.Text = "Student Major: ";
                fFourLbl.Text = "Grade level: ";
                fFiveLbl.Text = "Student Age: ";
                tbOne.Text = "";
                tbTwo.Text = "";
                tbThree.Text = "";
                tbFour.Text = "";
                tbFive.Text = "";
                tbSix.Text = "";
                tbSeven.Text = "";
                tbThree.Visible = true;
                tbFour.Visible = true;
                tbFive.Visible = true;
                tbSix.Visible = false;
                tbSeven.Visible = false;
                fSixLbl.Text = "";
                fSevenLbl.Text = "";
                // Clear the combo box

                recordCmb.Items.Clear();

                // Connect to the database
                using (SqlConnection connection = new SqlConnection("Data Source=essql1.walton.uark.edu;Initial Catalog=PROJECTS2354;User ID=PROJECTS2354;Password=GohogsUA1"))
                {
                    connection.Open();

                    // Get the students from the database
                    using (SqlCommand command = new SqlCommand("SELECT student_name FROM students", connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                                // Add each student name to the combo box
                                recordCmb.Items.Add(reader["student_name"].ToString());
                            }
                        }
                    }
                }
                setDatagrid("students");
            }
            else if (tableCmb.SelectedIndex == 1)
            {
                tbOne.Text = "";
                tbTwo.Text = "";
                tbThree.Text = "";
                tbFour.Text = "";
                tbFive.Text = "";
                tbSix.Text = "";
                tbSeven.Text = "";
                tbThree.Visible = true;
                tbFour.Visible = true;
                tbFive.Visible = true;
                tbSix.Visible = true;
                tbSeven.Visible = true;
                fOneLbl.Text = "Class ID: ";
                fTwoLbl.Text = "Class Name: ";
                fThreeLbl.Text = "Class Number: ";
                fFourLbl.Text = "Meeting Time: ";
                fFiveLbl.Text = "Instructor ID: ";
                fSixLbl.Text = "Instructor Name: ";
                fSevenLbl.Text = "Room Number: ";

                // Clear the combo box
                recordCmb.Items.Clear();

                // Connect to the database
                using (SqlConnection connection = new SqlConnection("Data Source=essql1.walton.uark.edu;Initial Catalog=PROJECTS2354;User ID=PROJECTS2354;Password=GohogsUA1"))
                {
                    connection.Open();

                    // Get the classes from the database
                    using (SqlCommand command = new SqlCommand("SELECT class_name FROM classes", connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Add each class name to the combo box
                                recordCmb.Items.Add(reader["class_name"].ToString());
                            }
                        }
                    }

                }
                setDatagrid("classes");

            }
            else if (tableCmb.SelectedIndex == 2)
            {
                tbOne.Text = "";
                tbTwo.Text = "";
                tbThree.Text = "";
                tbFour.Text = "";
                tbFive.Text = "";
                tbSix.Text = "";
                tbSeven.Text = "";
                tbThree.Visible = false;
                tbFour.Visible = false;
                tbFive.Visible = false;
                tbSix.Visible = false;
                tbSeven.Visible = false;
                fOneLbl.Text = "Instructor ID: ";
                fTwoLbl.Text = "Instructor Name: ";
                fThreeLbl.Text = "";
                fFourLbl.Text = "";
                fFiveLbl.Text = "";
                fSixLbl.Text = "";
                fSevenLbl.Text = "";
                // Clear the combo box
                recordCmb.Items.Clear();

                // Connect to the database
                using (SqlConnection connection = new SqlConnection("Data Source=essql1.walton.uark.edu;Initial Catalog=PROJECTS2354;User ID=PROJECTS2354;Password=GohogsUA1"))
                {
                    connection.Open();

                    // Get the classes from the database
                    using (SqlCommand command = new SqlCommand("SELECT instructor_name FROM instructors", connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Add each class name to the combo box
                                recordCmb.Items.Add(reader["instructor_name"].ToString());
                            }
                        }
                    }

                }
                setDatagrid("instructors");
            }

        }

        private void recordCmb_SelectedIndexChanged(object sender, EventArgs e)
        {

            using (SqlConnection connection = new SqlConnection("Data Source=essql1.walton.uark.edu;Initial Catalog=PROJECTS2354;User ID=PROJECTS2354;Password=GohogsUA1"))
            {
                connection.Open();

                if (tableCmb.SelectedIndex == 0)
                {
                    // Get the classes from the database
                    string sqlString = "SELECT * FROM students WHERE student_name = '" + recordCmb.Text + "'";
                    SqlCommand command = new SqlCommand(sqlString, connection);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows == true)
                        {
                            reader.Read();
                            tbOne.Text = reader["student_id"].ToString();
                            tbTwo.Text = reader["student_name"].ToString();
                            tbThree.Text = reader["major"].ToString();
                            tbFour.Text = reader["grade_level"].ToString();
                            tbFive.Text = reader["age"].ToString();
                        }
                        else
                        {
                            label4.Text = "";
                        }

                    }
                    setDatagrid("students");
                }
                else if (tableCmb.SelectedIndex == 2)
                {
                    // Get the classes from the database
                    string sqlString = "SELECT * FROM instructors WHERE instructor_name = '" + recordCmb.Text + "'";
                    SqlCommand command = new SqlCommand(sqlString, connection);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows == true)
                        {
                            reader.Read();
                            tbTwo.Text = reader["instructor_name"].ToString();
                            tbOne.Text = reader["instructor_id"].ToString();
                        }
                        else
                        {
                            label4.Text = "";
                        }
                    }
                    setDatagrid("instructors");
                }
                else if (tableCmb.SelectedIndex == 1)
                {
                    string sqlString = "select classes.class_id, classes.class_name, classes.class_number, classes.meeting_time, classes.instructor_id, instructors.instructor_name, classes.room_number\r\nfrom classes\r\njoin instructors on classes.instructor_id = instructors.instructor_id\r\nwhere class_name = '" + recordCmb.Text + "'";
                    SqlCommand command = new SqlCommand(sqlString, connection);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows == true)
                        {
                            reader.Read();
                            tbOne.Text = reader["class_id"].ToString();
                            tbTwo.Text = reader["class_name"].ToString();
                            tbThree.Text = reader["class_number"].ToString();
                            tbFour.Text = reader["meeting_time"].ToString();
                            tbFive.Text = reader["instructor_id"].ToString();
                            tbSix.Text = reader["instructor_name"].ToString();
                            tbSeven.Text = reader["room_number"].ToString();
                        }
                        else
                        {
                            label4.Text = "";
                        }
                    }
                    setDatagrid("classes");

                }

            }

        }

        private void fieldCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (fieldCmb.Text == "instructors")
            {
                fieldOneLbl.Text = "Enter Instructor Name:";
                fieldTwoLbl.Text = "";
                fieldThreeLabel.Text = "";
                fieldFourLabel.Text = "";
                fieldFiveLbl.Text = "";
                fieldOneBox.Visible = true;
                fieldTwoBox.Visible = false;
                fieldThreeBox.Visible = false;
                fieldFourBox.Visible = false;
                fieldFiveBox.Visible = false;
            }
            else if (fieldCmb.Text == "classes")
            {
                fieldOneLbl.Text = "Enter Class Name:";
                fieldTwoLbl.Text = "Enter Class Number:";
                fieldThreeLabel.Text = "Enter Instructor Name: ";
                fieldFourLabel.Text = "Enter Room number:";
                fieldFiveLbl.Text = "Enter meeting time: ";
                fieldOneBox.Visible = true;
                fieldTwoBox.Visible = true;
                fieldThreeBox.Visible = true;
                fieldFourBox.Visible = true;
                fieldFiveBox.Visible = true;
            }
            else if (fieldCmb.Text == "students")
            {
                fieldOneLbl.Text = "Enter Student Name:";
                fieldTwoLbl.Text = "Enter Student Age: ";
                fieldThreeLabel.Text = "Enter Student Grade: ";
                fieldFourLabel.Text = "Enter Student Major";
                fieldFiveLbl.Text = "";
                fieldOneBox.Visible = true;
                fieldTwoBox.Visible = true;
                fieldThreeBox.Visible = true;
                fieldFourBox.Visible = true;
                fieldFiveBox.Visible = false;
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (tableCmb.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a valid table and record");
            }
            else if (recordCmb.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a valid table and record");
            }
            else
            {
                string table = tableCmb.Text;
                if (editRecord(table) == true)
                {
                    MessageBox.Show("Record successfully updated");
                }
                else
                {
                    MessageBox.Show("Error: Record not updated");
                }
            }

        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            if (tableCmb.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a table");
            }
            else
            {
                string table = tableCmb.Text.Trim();
                setDatagrid(table);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            if (searchCmb.SelectedIndex == -1)
            {
                searchBox.Text = "";
                MessageBox.Show("Select a search option");
            }
            else
            {
               

                string searchTerm = searchBox.Text;
                if (searchCmb.Text == "student's classes")
                {
                    string sqlString = "select classes.class_id, classes.class_name, classes.class_number, classes.meeting_time, classes.room_number, classes.instructor_id, classes.instructor_name, enrollments.enrollment_id from enrollments join classes on enrollments.class_id = classes.class_id where student_id = (SELECT top 1 student_id FROM students WHERE student_name LIKE '%" + searchBox.Text + "%');";
                    using (SqlConnection connection = new SqlConnection("Data Source=essql1.walton.uark.edu;Initial Catalog=PROJECTS2354;User ID=PROJECTS2354;Password=GohogsUA1"))
                    {
                        connection.Open();

                        SqlCommand command = new SqlCommand(sqlString, connection);
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);
                        searchGrid.DataSource = dataTable;
                    }
                }
                else if (searchCmb.Text == "teacher's students")
                {
                    string sqlString = "select students.student_name, students.student_id, students.major, students.grade_level, students.age, enrollments.class_id, enrollments.enrollment_id from enrollments join students on enrollments.student_id = students.student_id where class_id = (select top 1 class_id from classes where instructor_name like '%" + searchTerm + "%');";
                    using (SqlConnection connection = new SqlConnection("Data Source=essql1.walton.uark.edu;Initial Catalog=PROJECTS2354;User ID=PROJECTS2354;Password=GohogsUA1"))
                    {
                        connection.Open();

                        SqlCommand command = new SqlCommand(sqlString, connection);
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);
                        searchGrid.DataSource = dataTable;
                    }
                }
                else if (searchCmb.Text == "class roster")
                {
                    string sqlString = "select students.student_name, students.student_id, students.major, students.grade_level, students.age, enrollments.enrollment_id from enrollments join students on enrollments.student_id = students.student_id where class_id = (select top 1 class_id from classes where class_name like '%" + searchTerm + "%');";
                    using (SqlConnection connection = new SqlConnection("Data Source=essql1.walton.uark.edu;Initial Catalog=PROJECTS2354;User ID=PROJECTS2354;Password=GohogsUA1"))
                    {
                        connection.Open();

                        SqlCommand command = new SqlCommand(sqlString, connection);
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);
                        searchGrid.DataSource = dataTable;
                    }
                }


     
            }

            
        }
    }
}
