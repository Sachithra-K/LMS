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
    public partial class StudentRegistrationForm : Form
    {
        
        double val = 0;
    
        public StudentRegistrationForm()
        {
            InitializeComponent();
            AutoIdNumber();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sachi\Downloads\LMS1\LMS1\abc_lms\abc_lms\lms.mdf;Integrated Security=True;Connect Timeout=30");

        SqlDataAdapter adapter;

        DataTable StudentRegistration = new DataTable();

        private void AutoIdNumber()
        {
            con.Open();
            SqlCommand command = new SqlCommand("Select count(StudentId) from [StudentRegistration]", con);
            int i = Convert.ToInt32(command.ExecuteScalar());
            con.Close();
            i++;
            txtStudentId.Text = val + i.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand cnn = new SqlCommand("Insert into StudentRegistration values(@StudentId,@StudentName,@Address,@Gender,@ContactNo,@Email)", con);

            cnn.Parameters.AddWithValue("@StudentId", int.Parse(txtStudentId.Text));
            cnn.Parameters.AddWithValue("@StudentName", txtStudentName.Text);
            cnn.Parameters.AddWithValue("@Address", txtAddress.Text);
            cnn.Parameters.AddWithValue("@Gender", txtGender.Text);
            cnn.Parameters.AddWithValue("@ContactNo", int.Parse(txtContactNo.Text));
            cnn.Parameters.AddWithValue("@Email", txtEmail.Text);

            cnn.ExecuteNonQuery();
            MessageBox.Show("Save Successfully");


            con.Close();

            // txtStudentId.Text = "";
            txtStudentName.Text = "";
            txtAddress.Text = "";
            txtGender.Text = "";
            txtContactNo.Text = "";
            txtEmail.Text = "";
            AutoIdNumber();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            try
            {

                con.Open();

                string updateQuery = "UPDATE StudentRegistration SET StudentName  = @StudentName, Address = @Address,Gender =@Gender, ContactNo = @ContactNo, Email = @Email  WHERE StudentId = @StudentId";

                using (SqlCommand cnn = new SqlCommand(updateQuery, con))
                {
                    cnn.Parameters.AddWithValue("@StudentId", txtStudentId.Text);
                    cnn.Parameters.AddWithValue("@StudentName", txtStudentName.Text);
                    cnn.Parameters.AddWithValue("@Address", txtAddress.Text);
                    cnn.Parameters.AddWithValue("@Gender", txtGender.Text);
                    cnn.Parameters.AddWithValue("@ContactNo", txtContactNo.Text);
                    cnn.Parameters.AddWithValue("@Email", txtEmail.Text);

                    int rowsAffected = cnn.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Updated successfully");
                        txtStudentId.Text = "";
                        txtStudentName.Text = "";
                        txtAddress.Text = "";
                        txtGender.Text = "";
                        txtContactNo.Text = "";
                        txtEmail.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("No records were updated");
                    }
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show("SQL Error: " + ex.Message, "Error");
            }

            finally
            {
                con.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string idToDelete = txtStudentId.Text;

                string deleteQuery = "DELETE FROM StudentRegistration WHERE StudentId = @StudentId";

                using (SqlCommand cnn = new SqlCommand(deleteQuery, con))
                {
                    cnn.Parameters.AddWithValue("@StudentId", idToDelete);
                    int rowsAffected = cnn.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Deletion successful");
                        txtStudentId.Text = "";
                        txtStudentName.Text = "";
                        txtAddress.Text = "";
                        txtGender.Text = "";
                        txtContactNo.Text = "";
                        txtEmail.Text = "";

                    }
                    else
                    {
                        MessageBox.Show("No rows were deleted. Record not found.", "Information");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        { 
            
        
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
             try
            {
                string search = txtSearch.Text;
                string query_select = "select * from StudentRegistration where StudentId = '" + search + "'";

                SqlCommand citb = new SqlCommand(query_select, con);
                con.Open();
                SqlDataReader r = citb.ExecuteReader();
                while (r.Read())
                {
                    txtStudentId.Text = r[0].ToString();
                    txtStudentName.Text = r[1].ToString();
                    txtGender.Text = r[2].ToString();
                    txtAddress.Text = r[3].ToString();
                    txtContactNo.Text = r[4].ToString();
                    txtEmail.Text = r[5].ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                con.Close();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}



        
    


