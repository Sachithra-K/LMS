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
    public partial class LecturerLoginForm : Form
    {
        public LecturerLoginForm()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sachi\Desktop\abc_lms\abc_lms\abc_lms\lms.mdf;Integrated Security=True;Connect Timeout=30");

        SqlDataAdapter adapter;

        DataTable LecturerLogin = new DataTable();

        private void btnSave_Click(object sender, EventArgs e)
        {
             con.Open();

            SqlCommand cnn = new SqlCommand("Insert into LecturerLogin values(@Username,@Password,@ComPassword)", con);

            cnn.Parameters.AddWithValue("@Username", txtUsername.Text);
            cnn.Parameters.AddWithValue("@Password", txtPassword.Text);
            cnn.Parameters.AddWithValue("@ComPassword", txtComPassword.Text);

            cnn.ExecuteNonQuery();
            MessageBox.Show("Saved Successfully");

            this.Hide();
            LibrarianMenuForm obj = new LibrarianMenuForm();
            obj.Show();


            con.Close();

            txtUsername.Text = "";
            txtPassword.Text = "";
            txtComPassword.Text = "";

        }

        private void btnLogin_Click(object sender, EventArgs e)
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
                    string ComPassword = txtComPassword.Text;

                    if (Username == X && Password == Y)
                    {
                        
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            
        }

        private void LecturerLoginForm_Load(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtComPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void lblComPassword_Click(object sender, EventArgs e)
        {

        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
