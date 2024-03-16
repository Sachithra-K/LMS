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
    public partial class ViewReturnForm : Form
    {
        public ViewReturnForm()
        {
            InitializeComponent();
        }


        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sachi\Downloads\LMS1\LMS1\abc_lms\abc_lms\lms.mdf;Integrated Security=True;Connect Timeout=30");

        SqlDataAdapter adapter;

        DataTable BorrowingBook = new DataTable();

        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string search = txtSearch.Text;
                string query_select = "select * from BorrowingBook where MemberId = '" + search + "'";

                SqlCommand citb = new SqlCommand(query_select, con);
                con.Open();
                SqlDataReader r = citb.ExecuteReader();
                while (r.Read())
                {
                    txtBookId.Text = r[0].ToString();
                    txtBookName.Text = r[1].ToString();
                    txtMemberName.Text = r[2].ToString();
                    txtDateRetured.Text = r[3].ToString();

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
           LSMenuForm obj = new LSMenuForm();
            obj.Show();

        }
    }
}
