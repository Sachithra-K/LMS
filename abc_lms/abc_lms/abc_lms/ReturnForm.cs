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
    public partial class ReturnForm : Form
    {
        public ReturnForm()
        {
            InitializeComponent();
        }


        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sachi\Downloads\LMS1\LMS1\abc_lms\abc_lms\lms.mdf;Integrated Security=True;Connect Timeout=30");


        SqlDataAdapter adapter;

        DataTable ReturnBook = new DataTable();


        private void btnSave_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand cnn = new SqlCommand("Insert into ReturnBook values(@BookId, @BookName, @MemberId, @MemberName, @DateRetured)", con);

            cnn.Parameters.AddWithValue("@BookId", int.Parse (txtBookId.Text));
            cnn.Parameters.AddWithValue("@BookName", txtBookName.Text);
            cnn.Parameters.AddWithValue("@MemberId", int.Parse (txtMemberId.Text));
            cnn.Parameters.AddWithValue("@MemberName", txtMemberName.Text);
            cnn.Parameters.AddWithValue("@DateRetured", dtpDateReturned.Value.Date);

            cnn.ExecuteNonQuery();
            MessageBox.Show("Saved Successfully");

            con.Close();

            txtBookId.Text = "";
            txtBookName.Text = "";
            txtMemberId.Text = "";
            txtMemberName.Text = "";
            dtpDateReturned.Text = "";
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            this.Hide();
            LSMenuForm obj = new LSMenuForm();
            obj.Show();
        }
    }
}
