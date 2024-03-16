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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sachi\Downloads\LMS1\LMS1\abc_lms\abc_lms\lms.mdf;Integrated Security=True;Connect Timeout=30");

        SqlDataAdapter adapter;

        DataTable Login = new DataTable();

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand cnn = new SqlCommand("Insert into Login values(@Username,@Password)", con);

            cnn.Parameters.AddWithValue("@Username", txtUsername.Text);
            cnn.Parameters.AddWithValue("@Password", txtPassword.Text);

            cnn.ExecuteNonQuery();
            MessageBox.Show("Saved Successfully");


            this.Hide();
            MenuForm obj = new MenuForm();
            obj.Show();


            con.Close();

            txtUsername.Text = "";
            txtPassword.Text = "";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {

                string search = txtUsername.Text;
                string query_select = "select * from Login where Username = '" + search + "'";

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
                        MenuForm obj = new MenuForm();
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            try
            {

                string search = txtUsername.Text;
                string query_select = "select * from Login where Username = '" + search + "'";

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
                        MessageBox.Show("Exit Sucsess");
                        txtUsername.Text = "";
                        txtPassword.Text = "";
                    
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Exit not Sucsess");
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

        private void cbnShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = cbnShowPassword.Checked ? '\0' : '*';
        }
    }
}
       
