namespace abc_lms
{
    partial class ReturnForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnForm));
			this.txtBookId = new System.Windows.Forms.TextBox();
			this.txtBookName = new System.Windows.Forms.TextBox();
			this.txtMemberId = new System.Windows.Forms.TextBox();
			this.txtMemberName = new System.Windows.Forms.TextBox();
			this.dtpDateReturned = new System.Windows.Forms.DateTimePicker();
			this.btnSave = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.addBooks_clearBtn = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lblDateBorrowed = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// txtBookId
			// 
			this.txtBookId.Location = new System.Drawing.Point(228, 118);
			this.txtBookId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtBookId.Name = "txtBookId";
			this.txtBookId.Size = new System.Drawing.Size(223, 22);
			this.txtBookId.TabIndex = 6;
			// 
			// txtBookName
			// 
			this.txtBookName.Location = new System.Drawing.Point(228, 185);
			this.txtBookName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtBookName.Name = "txtBookName";
			this.txtBookName.Size = new System.Drawing.Size(223, 22);
			this.txtBookName.TabIndex = 7;
			// 
			// txtMemberId
			// 
			this.txtMemberId.Location = new System.Drawing.Point(228, 252);
			this.txtMemberId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtMemberId.Name = "txtMemberId";
			this.txtMemberId.Size = new System.Drawing.Size(223, 22);
			this.txtMemberId.TabIndex = 8;
			// 
			// txtMemberName
			// 
			this.txtMemberName.Location = new System.Drawing.Point(228, 319);
			this.txtMemberName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtMemberName.Name = "txtMemberName";
			this.txtMemberName.Size = new System.Drawing.Size(223, 22);
			this.txtMemberName.TabIndex = 9;
			// 
			// dtpDateReturned
			// 
			this.dtpDateReturned.Location = new System.Drawing.Point(228, 386);
			this.dtpDateReturned.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.dtpDateReturned.Name = "dtpDateReturned";
			this.dtpDateReturned.Size = new System.Drawing.Size(223, 22);
			this.dtpDateReturned.TabIndex = 10;
			// 
			// btnSave
			// 
			this.btnSave.FlatAppearance.BorderSize = 0;
			this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
			this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSave.Font = new System.Drawing.Font("Arial Narrow", 9.75F);
			this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
			this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSave.Location = new System.Drawing.Point(41, 468);
			this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(133, 28);
			this.btnSave.TabIndex = 11;
			this.btnSave.Text = "        RETURN";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.pictureBox2);
			this.panel1.Controls.Add(this.btnSave);
			this.panel1.Controls.Add(this.dtpDateReturned);
			this.panel1.Controls.Add(this.addBooks_clearBtn);
			this.panel1.Controls.Add(this.txtMemberName);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.txtMemberId);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.txtBookName);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.txtBookId);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.lblDateBorrowed);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Location = new System.Drawing.Point(349, 16);
			this.panel1.Margin = new System.Windows.Forms.Padding(4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(489, 647);
			this.panel1.TabIndex = 29;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.pictureBox2.Location = new System.Drawing.Point(141, 28);
			this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(40, 37);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 26;
			this.pictureBox2.TabStop = false;
			// 
			// addBooks_clearBtn
			// 
			this.addBooks_clearBtn.BackColor = System.Drawing.Color.White;
			this.addBooks_clearBtn.FlatAppearance.BorderSize = 0;
			this.addBooks_clearBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkSeaGreen;
			this.addBooks_clearBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
			this.addBooks_clearBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
			this.addBooks_clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.addBooks_clearBtn.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addBooks_clearBtn.ForeColor = System.Drawing.Color.Black;
			this.addBooks_clearBtn.Image = ((System.Drawing.Image)(resources.GetObject("addBooks_clearBtn.Image")));
			this.addBooks_clearBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.addBooks_clearBtn.Location = new System.Drawing.Point(309, 461);
			this.addBooks_clearBtn.Margin = new System.Windows.Forms.Padding(4);
			this.addBooks_clearBtn.Name = "addBooks_clearBtn";
			this.addBooks_clearBtn.Size = new System.Drawing.Size(142, 42);
			this.addBooks_clearBtn.TabIndex = 23;
			this.addBooks_clearBtn.Text = "CLEAR";
			this.addBooks_clearBtn.UseVisualStyleBackColor = false;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Tahoma", 14.25F);
			this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label6.Location = new System.Drawing.Point(186, 33);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(155, 29);
			this.label6.TabIndex = 25;
			this.label6.Text = "Return Books";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F);
			this.label1.Location = new System.Drawing.Point(37, 118);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(145, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "Book Id :";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F);
			this.label2.Location = new System.Drawing.Point(37, 185);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(145, 20);
			this.label2.TabIndex = 2;
			this.label2.Text = "Book Name :";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F);
			this.label3.Location = new System.Drawing.Point(37, 252);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(145, 20);
			this.label3.TabIndex = 3;
			this.label3.Text = "Member Id :";
			// 
			// lblDateBorrowed
			// 
			this.lblDateBorrowed.Font = new System.Drawing.Font("Tahoma", 9.75F);
			this.lblDateBorrowed.Location = new System.Drawing.Point(37, 386);
			this.lblDateBorrowed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblDateBorrowed.Name = "lblDateBorrowed";
			this.lblDateBorrowed.Size = new System.Drawing.Size(145, 20);
			this.lblDateBorrowed.TabIndex = 5;
			this.lblDateBorrowed.Text = "Date Borrowed :";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F);
			this.label4.Location = new System.Drawing.Point(37, 319);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(145, 20);
			this.label4.TabIndex = 4;
			this.label4.Text = "Member Name :";
			// 
			// ReturnForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1227, 682);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "ReturnForm";
			this.Text = "ReturnForm";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtBookId;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.TextBox txtMemberId;
        private System.Windows.Forms.TextBox txtMemberName;
        private System.Windows.Forms.DateTimePicker dtpDateReturned;
        private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Button addBooks_clearBtn;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblDateBorrowed;
		private System.Windows.Forms.Label label4;
	}
}