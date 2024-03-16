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

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Hp\desktop\visual studio 2012\Project\abc_lms\abc_lms\LibraryManagementSystem.mdf;Integrated Security=True;");

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
            LSMenuForm obj = new LSMenuForm();
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
                        MessageBox.Show("Login Sucsess");
                        txtUsername.Text = "";
                        txtPassword.Text = "";

                        this.Hide();
                        LSMenuForm obj = new LSMenuForm();
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
            this.Hide();
            MenuForm obj = new MenuForm();
            obj.Show();
        }
    }
}
