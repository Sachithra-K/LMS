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
    public partial class CalculateForm : Form
    {
        public CalculateForm()
        {
            InitializeComponent();
        }


        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sachi\Downloads\LMS1\LMS1\abc_lms\abc_lms\lms.mdf;Integrated Security=True;Connect Timeout=30");


        SqlDataAdapter adapter;

        DataTable CalculateTable = new DataTable();


        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int days = Int16.Parse(txtDelayed.Text);
            double fine = Double.Parse(txtFine.Text);
            double total = fine * days;
            txtTotalFine.Text = total.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand cnn = new SqlCommand("Insert into CalculateTable values(@MemberId, @TotalFine)", con);

            cnn.Parameters.AddWithValue("@MemberId", txtMemberId.Text);
            cnn.Parameters.AddWithValue("@TotalFine", txtTotalFine.Text);

            cnn.ExecuteNonQuery();
            MessageBox.Show("Saved Successfully");


            con.Close();

            txtMemberId.Text = "";
            txtTotalFine.Text = "";
        }

        private void CalculateForm_Load(object sender, EventArgs e)
        {

        }
    }
}
