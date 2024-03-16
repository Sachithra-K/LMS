namespace abc_lms
{
    partial class ViewReturnForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewReturnForm));
			this.lblMemberId = new System.Windows.Forms.Label();
			this.lblDateReturned = new System.Windows.Forms.Label();
			this.btnSearch = new System.Windows.Forms.Button();
			this.txtBookId = new System.Windows.Forms.TextBox();
			this.txtBookName = new System.Windows.Forms.TextBox();
			this.txtMemberName = new System.Windows.Forms.TextBox();
			this.txtDateRetured = new System.Windows.Forms.TextBox();
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.addbkpanel2 = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// lblMemberId
			// 
			this.lblMemberId.Font = new System.Drawing.Font("Tahoma", 9.75F);
			this.lblMemberId.Location = new System.Drawing.Point(465, 45);
			this.lblMemberId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblMemberId.Name = "lblMemberId";
			this.lblMemberId.Size = new System.Drawing.Size(145, 20);
			this.lblMemberId.TabIndex = 0;
			this.lblMemberId.Text = "Member Id :";
			// 
			// lblDateReturned
			// 
			this.lblDateReturned.Font = new System.Drawing.Font("Tahoma", 9.75F);
			this.lblDateReturned.Location = new System.Drawing.Point(26, 335);
			this.lblDateReturned.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblDateReturned.Name = "lblDateReturned";
			this.lblDateReturned.Size = new System.Drawing.Size(145, 20);
			this.lblDateReturned.TabIndex = 8;
			this.lblDateReturned.Text = "Date Returned :";
			// 
			// btnSearch
			// 
			this.btnSearch.FlatAppearance.BorderSize = 0;
			this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
			this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
			this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSearch.Font = new System.Drawing.Font("Arial Narrow", 9.75F);
			this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
			this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSearch.Location = new System.Drawing.Point(1047, 42);
			this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(163, 37);
			this.btnSearch.TabIndex = 9;
			this.btnSearch.Text = "SEARCH";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// txtBookId
			// 
			this.txtBookId.Location = new System.Drawing.Point(159, 162);
			this.txtBookId.Margin = new System.Windows.Forms.Padding(4);
			this.txtBookId.Name = "txtBookId";
			this.txtBookId.Size = new System.Drawing.Size(223, 22);
			this.txtBookId.TabIndex = 10;
			// 
			// txtBookName
			// 
			this.txtBookName.Location = new System.Drawing.Point(159, 219);
			this.txtBookName.Margin = new System.Windows.Forms.Padding(4);
			this.txtBookName.Name = "txtBookName";
			this.txtBookName.Size = new System.Drawing.Size(223, 22);
			this.txtBookName.TabIndex = 11;
			// 
			// txtMemberName
			// 
			this.txtMemberName.Location = new System.Drawing.Point(159, 276);
			this.txtMemberName.Margin = new System.Windows.Forms.Padding(4);
			this.txtMemberName.Name = "txtMemberName";
			this.txtMemberName.Size = new System.Drawing.Size(223, 22);
			this.txtMemberName.TabIndex = 12;
			// 
			// txtDateRetured
			// 
			this.txtDateRetured.Location = new System.Drawing.Point(159, 333);
			this.txtDateRetured.Margin = new System.Windows.Forms.Padding(4);
			this.txtDateRetured.Name = "txtDateRetured";
			this.txtDateRetured.Size = new System.Drawing.Size(223, 22);
			this.txtDateRetured.TabIndex = 13;
			// 
			// txtSearch
			// 
			this.txtSearch.Location = new System.Drawing.Point(568, 49);
			this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(471, 22);
			this.txtSearch.TabIndex = 14;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.txtBookId);
			this.panel1.Controls.Add(this.pictureBox2);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.txtDateRetured);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.txtMemberName);
			this.panel1.Controls.Add(this.lblDateReturned);
			this.panel1.Controls.Add(this.txtBookName);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Location = new System.Drawing.Point(12, 16);
			this.panel1.Margin = new System.Windows.Forms.Padding(4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(409, 647);
			this.panel1.TabIndex = 27;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.pictureBox2.Location = new System.Drawing.Point(63, 28);
			this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(40, 37);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 26;
			this.pictureBox2.TabStop = false;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Tahoma", 14.25F);
			this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label6.Location = new System.Drawing.Point(107, 33);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(239, 29);
			this.label6.TabIndex = 25;
			this.label6.Text = "View Returned Books";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F);
			this.label1.Location = new System.Drawing.Point(26, 164);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(145, 20);
			this.label1.TabIndex = 4;
			this.label1.Text = " Book Id :";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F);
			this.label3.Location = new System.Drawing.Point(26, 278);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(145, 20);
			this.label3.TabIndex = 11;
			this.label3.Text = "Member Name :";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F);
			this.label2.Location = new System.Drawing.Point(26, 221);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(145, 20);
			this.label2.TabIndex = 6;
			this.label2.Text = " Book Name :";
			// 
			// addbkpanel2
			// 
			this.addbkpanel2.BackColor = System.Drawing.Color.WhiteSmoke;
			this.addbkpanel2.Location = new System.Drawing.Point(444, 98);
			this.addbkpanel2.Margin = new System.Windows.Forms.Padding(4);
			this.addbkpanel2.Name = "addbkpanel2";
			this.addbkpanel2.Size = new System.Drawing.Size(764, 559);
			this.addbkpanel2.TabIndex = 28;
			this.addbkpanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.addbkpanel2_Paint);
			// 
			// ViewReturnForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1227, 682);
			this.Controls.Add(this.addbkpanel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.txtSearch);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.lblMemberId);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "ViewReturnForm";
			this.Text = "ViewReturnForm";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMemberId;
        private System.Windows.Forms.Label lblDateReturned;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtBookId;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.TextBox txtMemberName;
        private System.Windows.Forms.TextBox txtDateRetured;
        private System.Windows.Forms.TextBox txtSearch;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel addbkpanel2;
	}
}