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
    public partial class LecturerRegistrationForm : Form
    {
        double val = 0;

        public LecturerRegistrationForm()
        {
            InitializeComponent();
            AutoIdNumber();

         }



        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sachi\Downloads\LMS1\LMS1\abc_lms\abc_lms\lms.mdf;Integrated Security=True;Connect Timeout=30");

        SqlDataAdapter adapter;

        DataTable LecturerRegistration = new DataTable();


        private void AutoIdNumber()
        {
            con.Open();
            SqlCommand command = new SqlCommand("Select count(LecturerId) from [LecturerRegistration]", con);
            int i = Convert.ToInt32(command.ExecuteScalar());
            con.Close();
            i++;
            txtLecturerId.Text = val + i.ToString();

        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand cnn = new SqlCommand("Insert into LecturerRegistration values(@LecturerId,@LecturerName,@Address,@Department,@Gender,@ContactNo,@Email)", con);

            cnn.Parameters.AddWithValue("@LecturerId", int.Parse(txtLecturerId.Text));
            cnn.Parameters.AddWithValue("@LecturerName", txtLecturerName.Text);
            cnn.Parameters.AddWithValue("@Address", txtAddress.Text);
            cnn.Parameters.AddWithValue("@Department", txtDepartment.Text);
            cnn.Parameters.AddWithValue("@Gender", txtGender.Text);
            cnn.Parameters.AddWithValue("@ContactNo", int.Parse(txtContactNo.Text));
            cnn.Parameters.AddWithValue("@Email", txtEmail.Text);

            cnn.ExecuteNonQuery();
            MessageBox.Show("Save Successfully");


            con.Close();

            // txtLecturerId.Text = "";
            txtLecturerName.Text = "";
            txtAddress.Text = "";
            txtDepartment.Text = "";
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

                string updateQuery = "UPDATE LecturerRegistration SET LecturerName  = @LecturerName, Address = @Address, Department = @Department, Gender =@Gender, ContactNo = @ContactNo, Email = @Email  WHERE LecturerId = @LecturerId";

                using (SqlCommand cnn = new SqlCommand(updateQuery, con))
                {
                    cnn.Parameters.AddWithValue("@LecturerId", txtLecturerId.Text);
                    cnn.Parameters.AddWithValue("@LecturerName", txtLecturerName.Text);
                    cnn.Parameters.AddWithValue("@Address", txtAddress.Text);
                    cnn.Parameters.AddWithValue("@Department", txtDepartment.Text);
                    cnn.Parameters.AddWithValue("@Gender", txtGender.Text);
                    cnn.Parameters.AddWithValue("@ContactNo", txtContactNo.Text);
                    cnn.Parameters.AddWithValue("@Email", txtEmail.Text);

                    int rowsAffected = cnn.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Updated successfully");
                        txtLecturerId.Text = "";
                        txtLecturerName.Text = "";
                        txtAddress.Text = "";
                        txtDepartment.Text = "";
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
                string idToDelete = txtLecturerId.Text;

                string deleteQuery = "DELETE FROM LecturerRegistration WHERE LecturerId = @LecturerId";

                using (SqlCommand cnn = new SqlCommand(deleteQuery, con))
                {
                    cnn.Parameters.AddWithValue("@LecturerId", idToDelete);
                    int rowsAffected = cnn.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Deletion successful");
                        txtLecturerId.Text = "";
                        txtLecturerName.Text = "";
                        txtAddress.Text = "";
                        txtDepartment.Text = "";
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string search = txtSearch.Text;
                string query_select = "select * from LecturerRegistration where LecturerId = '" + search + "'";

                SqlCommand citb = new SqlCommand(query_select, con);
                con.Open();
                SqlDataReader r = citb.ExecuteReader();
                while (r.Read())
                {
                    txtLecturerId.Text = r[0].ToString();
                    txtLecturerName.Text = r[1].ToString();
                    txtAddress.Text = r[2].ToString();
                    txtDepartment.Text = r[3].ToString();
                    txtGender.Text = r[4].ToString();
                    txtContactNo.Text = r[5].ToString();
                    txtEmail.Text = r[6].ToString();

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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtLecturerId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
