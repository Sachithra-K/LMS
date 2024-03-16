using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace abc_lms
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void btnLibrarian_Click(object sender, EventArgs e)
        {
            this.Hide();
            LibrarianLoginForm obj = new LibrarianLoginForm();
            obj.Show();
        }

        private void btnLecturer_Click(object sender, EventArgs e)
        {
            this.Hide();
            LecturerLoginForm obj = new LecturerLoginForm();
            obj.Show();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentLoginForm obj = new StudentLoginForm();
            obj.Show();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm obj = new LoginForm();
            obj.Show();
        }
    }
}
