using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace abc_lms
{
    public partial class StudentLoginForm : Form
    {
        public StudentLoginForm()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sachi\Desktop\abc_lms\abc_lms\abc_lms\lms.mdf;Integrated Security=True;Connect Timeout=30");

        SqlDataAdapter adapter;

        DataTable StudentLogin = new DataTable();
        DataTable LibrarianLogin = new DataTable();
        DataTable LecturerLogin = new DataTable();


        private void btnSave_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand cnn = new SqlCommand("Insert into StudentLogin values(@Username,@Password,@ComPassword)", con);

            cnn.Parameters.AddWithValue("@Username", txtUsername.Text);
            cnn.Parameters.AddWithValue("@Password", txtPassword.Text);
          

            cnn.ExecuteNonQuery();
            MessageBox.Show("Saved Successfully");

            


            con.Close();

            txtUsername.Text = "";
            txtPassword.Text = "";
           

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Student")
            {


                try
                {

                    string search = txtUsername.Text;
                    string query_select = "select * from StudentLogin where Username = '" + search + "'";

                    SqlCommand cnn = new SqlCommand(query_select, con);
                    con.Open();
                    SqlDataReader r = cnn.ExecuteReader();


                    while (r.Read())
                    {

                        string X = r[0].ToString();
                        string Y = r[1].ToString();

                        string Username = txtUsername.Text;
                        string Password = txtPassword.Text;
                        //string ComPassword = txtComPassword.Text;

                        if (Username == X && Password == Y)
                        {
                            MessageBox.Show("Login Sucsess");
                            txtUsername.Text = "";
                            txtPassword.Text = "";

                            this.Hide();
							CommonMenuForm obj = new CommonMenuForm();
                            obj.Show();
                        }
                        else
                        {
                            MessageBox.Show("Login not Sucsess");
                            txtUsername.Text = "";
                            txtPassword.Text = "";
                        }

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("error while searching" + ex);
                }
                finally
                {
                    con.Close();
                }
            }


            else if(comboBox1.Text == "Librarian")
            {


                try
                {

                    string search = txtUsername.Text;
                    string query_select = "select * from LibrarianLogin where Username = '" + search + "'";

                    SqlCommand cnn = new SqlCommand(query_select, con);
                    con.Open();
                    SqlDataReader r = cnn.ExecuteReader();


                    while (r.Read())
                    {

                        string X = r[0].ToString();
                        string Y = r[1].ToString();

                        string Username = txtUsername.Text;
                        string Password = txtPassword.Text;


                        if (Username == X && Password == Y)
                        {
                            MessageBox.Show("Login Sucsess");
                            txtUsername.Text = "";
                            txtPassword.Text = "";

                            this.Hide();
                            LibrarianMenuForm obj = new LibrarianMenuForm();
                            obj.Show();

                        }
                        else
                        {
                            MessageBox.Show("Login not Sucsess");
                            txtUsername.Text = "";
                            txtPassword.Text = "";
                        }

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("error while searching" + ex);
                }
                finally
                {
                    con.Close();
                }


            }



			else if (comboBox1.Text == "Lecturer")
			{


                try
                {

                    string search = txtUsername.Text;
                    string query_select = "select * from LecturerLogin where Username = '" + search + "'";

                    SqlCommand cnn = new SqlCommand(query_select, con);
                    con.Open();
                    SqlDataReader r = cnn.ExecuteReader();


                    while (r.Read())
                    {

                        string X = r[0].ToString();
                        string Y = r[2].ToString();

                        string Username = txtUsername.Text;
                        string Password = txtPassword.Text;
                        //string ComPassword = txtComPassword.Text;

                        if (Username == X && Password == Y)
                        {
                            MessageBox.Show("Login Sucsess");
                            txtUsername.Text = "";
                            txtPassword.Text = "";

                            this.Hide();
                            CommonMenuForm obj = new CommonMenuForm();
                            obj.Show();
                        }
                        else
                        {
                            MessageBox.Show("Login not Sucsess");
                            txtUsername.Text = "";
                            txtPassword.Text = "";
                        }

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("error while searching" + ex);
                }
                finally
                {
                    con.Close();
                }

            }


            else { MessageBox.Show("Please select who you are ?"); }



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_showPass_CheckedChanged(object sender, EventArgs e)
        {

            txtPassword.PasswordChar = login_showPass.Checked ? '\0' : '*';
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

		private void StudentLoginForm_Load(object sender, EventArgs e)
		{

		}
	}
}

  




    