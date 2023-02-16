using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace academicManagementApp
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            int x = (this.ClientSize.Width - groupBox1.Size.Width) / 2;
            int y = (this.ClientSize.Height - groupBox1.Size.Height) / 2;
            groupBox1.Location = new Point(x, y);
        }



        private static void ConnectToDB()
        {
            string connectionString = "Data Source=essql1.walton.uark.edu;Initial Catalog=PROJECTS2354;User ID=PROJECTS2354;Password=GohogsUA1";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Failed to connect to DB");
                }
            }
        }

        public static bool CheckLogin(string user, string pass)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=essql1.walton.uark.edu;Initial Catalog=PROJECTS2354;User ID=PROJECTS2354;Password=GohogsUA1"))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM credentials WHERE username = @username AND password = @password;", connection);
                cmd.Parameters.AddWithValue("@username", user);
                cmd.Parameters.AddWithValue("@password", pass);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Incorrect credentials");
                    return false;
                }

                reader.Close();
            }
        }







        public static bool SignUp(string user, string pass)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=essql1.walton.uark.edu;Initial Catalog=PROJECTS2354;User ID=PROJECTS2354;Password=GohogsUA1"))
                {

                    connection.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO credentials (username, password) VALUES (@username, @password);", connection);
                    cmd.Parameters.AddWithValue("@username", user);
                    cmd.Parameters.AddWithValue("@password", pass);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected == 1)
                    {
                        return true;

                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch
            {
                return false;
            }
        }





        private void signupBtn_Click(object sender, EventArgs e)
        {
            string usernameInput = userBox.Text;
            string passwordInput = passBox.Text;

            bool signUpSuccess = SignUp(usernameInput, passwordInput);
            if (signUpSuccess == true)
            {
                MessageBox.Show("Sign up successful. Please login");
                userBox.Text= "";
                passBox.Text= "";
            }
            else
            {
                MessageBox.Show("Error: Sign up failed");
            } 

        }

        private void loginBtn_Click_1(object sender, EventArgs e)
        {
            string usernameInput = userBox.Text;
            string passwordInput = passBox.Text;
            if (CheckLogin(usernameInput, passwordInput) == true)
            {
                this.Hide();
                Form2 form2= new Form2();
                form2.ShowDialog();
            }
            else
            {
                userBox.Text = "";
                passBox.Text = "";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}