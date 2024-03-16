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
    public partial class AddBookForm : Form
    {
        double val = 0;

        public AddBookForm()
        {
            InitializeComponent();
            AutoIdNumber();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sachi\Desktop\abc_lms\abc_lms\abc_lms\lms.mdf;Integrated Security=True;Connect Timeout=30");

        SqlDataAdapter adapter;

        DataTable AddBook = new DataTable();


        private void AutoIdNumber()
        {
            con.Open();
            SqlCommand command = new SqlCommand("Select count(BookId) from [AddBook]", con);
            int i = Convert.ToInt32(command.ExecuteScalar());
            con.Close();
            i++;
            txtBookId.Text = val + i.ToString();

        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand cnn = new SqlCommand("Insert into AddBook values(@BookId, @BookName, @BookAuthor, @BookPublisher, @BookPurchaseDate, @BookQuantity)", con);

            cnn.Parameters.AddWithValue("@BookId", int.Parse(txtBookId.Text));
            cnn.Parameters.AddWithValue("@BookName", txtBookName.Text);
            cnn.Parameters.AddWithValue("@BookAuthor", txtBookAuthor.Text);
            cnn.Parameters.AddWithValue("@BookPublisher", txtBookPublisher.Text);
            cnn.Parameters.AddWithValue("@BookPurchaseDate", dtpBookPurchaseDate.Value.Date);
            cnn.Parameters.AddWithValue("@BookQuantity",int.Parse (txtBookQuantity.Text));

            cnn.ExecuteNonQuery();
            MessageBox.Show("Save Successfully");


            con.Close();

            // txtBookId.Text = "";
            txtBookName.Text = "";
            txtBookAuthor.Text = "";
            txtBookPublisher.Text = "";
            dtpBookPurchaseDate.Text = "";
            txtBookQuantity.Text = "";
            AutoIdNumber();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
              try
            {

                con.Open();

                string updateQuery = "UPDATE AddBook SET BookName  = @BookName, BookAuthor = @BookAuthor, BookPublisher = @BookPublisher, BookPurchaseDate = @BookPurchaseDate, BookQuantity = @BookQuantity  WHERE BookId = @BookId";

                using (SqlCommand cnn = new SqlCommand(updateQuery, con))
                {
                    cnn.Parameters.AddWithValue("@BookId", txtBookId.Text);
                    cnn.Parameters.AddWithValue("@BookName", txtBookName.Text);
                    cnn.Parameters.AddWithValue("@BookAuthor", txtBookAuthor.Text);
                    cnn.Parameters.AddWithValue("@BookPublisher", txtBookPublisher.Text);
                    cnn.Parameters.AddWithValue("@BookPurchaseDate", dtpBookPurchaseDate.Value.Date);
                    cnn.Parameters.AddWithValue("@BookQuantity", txtBookQuantity.Text);

                    int rowsAffected = cnn.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Updated successfully");
                        txtBookId.Text = "";
                        txtBookName.Text = "";
                        txtBookAuthor.Text = "";
                        txtBookPublisher.Text = "";
                        dtpBookPurchaseDate.Text = "";
                        txtBookQuantity.Text = "";
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
                string idToDelete = txtBookId.Text;

                string deleteQuery = "DELETE FROM AddBook WHERE BookId = @BookId";

                using (SqlCommand cnn = new SqlCommand(deleteQuery, con))
                {
                    cnn.Parameters.AddWithValue("@BookId", idToDelete);
                    int rowsAffected = cnn.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Deletion successful");
                        txtBookId.Text = "";
                        txtBookName.Text = "";
                        txtBookAuthor.Text = "";
                        txtBookPublisher.Text = "";
                        dtpBookPurchaseDate.Text = "";
                        txtBookQuantity.Text = "";

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
                string query_select = "select * from AddBook where BookId = '" + search + "'";

                SqlCommand citb = new SqlCommand(query_select, con);
                con.Open();
                SqlDataReader r = citb.ExecuteReader();
                while (r.Read())
                {
                    txtBookId.Text = r[0].ToString();
                    txtBookName.Text = r[1].ToString();
                    txtBookAuthor.Text = r[2].ToString();
                    txtBookPublisher.Text = r[3].ToString();
                    dtpBookPurchaseDate.Text = r[4].ToString();
                    txtBookQuantity.Text = r[5].ToString();

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
            this.Hide();
            LibrarianMenuForm obj = new LibrarianMenuForm();
            obj.Show();
        }

        private void AddBookForm_Load(object sender, EventArgs e)
        {

        }
    }
}
