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
	public partial class CommonMenuForm : Form
	{
		public CommonMenuForm()
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

		private void btnViewBook_Click(object sender, EventArgs e)
		{
			loadform(new ViewBookForm());
		}

		private void button1_Click(object sender, EventArgs e)
		{
			loadform(new BorrowingForm());
		}

		private void logout_btn_Click(object sender, EventArgs e)
		{
			this.Hide();
			StudentLoginForm obj = new StudentLoginForm();
			obj.Show();
		}

		private void panel2_Paint(object sender, PaintEventArgs e)
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

		private void greet_label_Click(object sender, EventArgs e)
		{

		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void panel3_Paint(object sender, PaintEventArgs e)
		{

		}
	}

}
