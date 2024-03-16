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
    public partial class LSMenuForm : Form
    {
        public LSMenuForm()
        {
            InitializeComponent();
        }

        private void btnViewBook_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewBookForm obj = new ViewBookForm();
            obj.Show();
        }

        private void btnBorrowing_Click(object sender, EventArgs e)
        {
            this.Hide();
            BorrowingForm obj = new BorrowingForm();
            obj.Show();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReturnForm obj = new ReturnForm();
            obj.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }

        private void LSMenuForm_Load(object sender, EventArgs e)
        {

        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuForm obj = new MenuForm();
            obj.Show();
        }
    }
}
