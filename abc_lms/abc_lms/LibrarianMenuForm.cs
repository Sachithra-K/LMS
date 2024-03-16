using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace abc_lms
{
    public partial class LibrarianMenuForm : Form
    {
        public LibrarianMenuForm()
        {
            InitializeComponent();
        }

        public void loadform(object Form)

        {
            if (this.panel3.Controls.Count > 0)
                this.panel3.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panel3.Controls.Add(f);
            this.panel3.Tag = f;
            f.Show();
        }



        private void btnAddLecturer_Click(object sender, EventArgs e)
        {
 
            loadform(new LecturerRegistrationForm());

        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            loadform(new StudentRegistrationForm());


        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            loadform(new AddBookForm());
        }

        private void btnViewBook_Click(object sender, EventArgs e)
        {
            loadform(new ViewBookForm());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnViewBorrowing_Click(object sender, EventArgs e)
        {
            loadform(new ViewBorrowingForm());


        }

        private void btnViewReturn_Click(object sender, EventArgs e)
        {
            loadform(new ViewReturnForm());
        }

        private void btnCalculation_Click(object sender, EventArgs e)
        {
            loadform(new CalculateForm());
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
			this.Hide();
			StudentLoginForm obj = new StudentLoginForm();
			obj.Show();
		}

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {

            this.Hide();
            StudentLoginForm obj = new StudentLoginForm();
            obj.Show();

        }

        private void dashbackground_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
	}
}
