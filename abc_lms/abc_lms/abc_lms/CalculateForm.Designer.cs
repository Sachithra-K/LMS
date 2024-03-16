namespace abc_lms
{
    partial class CalculateForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculateForm));
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtDelayed = new System.Windows.Forms.TextBox();
			this.txtFine = new System.Windows.Forms.TextBox();
			this.txtTotalFine = new System.Windows.Forms.TextBox();
			this.btnCalculate = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.lblMemberId = new System.Windows.Forms.Label();
			this.txtMemberId = new System.Windows.Forms.TextBox();
			this.addBooks_clearBtn = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.label6 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F);
			this.label2.Location = new System.Drawing.Point(53, 205);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(145, 20);
			this.label2.TabIndex = 1;
			this.label2.Text = "Days Delayed:";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F);
			this.label3.Location = new System.Drawing.Point(53, 263);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(145, 20);
			this.label3.TabIndex = 2;
			this.label3.Text = "Fine/day:";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F);
			this.label4.Location = new System.Drawing.Point(52, 321);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(145, 20);
			this.label4.TabIndex = 3;
			this.label4.Text = "Total Fine:";
			// 
			// txtDelayed
			// 
			this.txtDelayed.Location = new System.Drawing.Point(241, 203);
			this.txtDelayed.Margin = new System.Windows.Forms.Padding(4);
			this.txtDelayed.Name = "txtDelayed";
			this.txtDelayed.Size = new System.Drawing.Size(223, 22);
			this.txtDelayed.TabIndex = 4;
			this.txtDelayed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// txtFine
			// 
			this.txtFine.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtFine.Location = new System.Drawing.Point(241, 259);
			this.txtFine.Margin = new System.Windows.Forms.Padding(4);
			this.txtFine.Name = "txtFine";
			this.txtFine.ReadOnly = true;
			this.txtFine.Size = new System.Drawing.Size(223, 28);
			this.txtFine.TabIndex = 5;
			this.txtFine.Text = "10.00";
			this.txtFine.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// txtTotalFine
			// 
			this.txtTotalFine.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTotalFine.Location = new System.Drawing.Point(241, 321);
			this.txtTotalFine.Margin = new System.Windows.Forms.Padding(4);
			this.txtTotalFine.Name = "txtTotalFine";
			this.txtTotalFine.ReadOnly = true;
			this.txtTotalFine.Size = new System.Drawing.Size(223, 28);
			this.txtTotalFine.TabIndex = 6;
			this.txtTotalFine.Text = "0.00";
			this.txtTotalFine.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// btnCalculate
			// 
			this.btnCalculate.BackColor = System.Drawing.Color.White;
			this.btnCalculate.FlatAppearance.BorderSize = 0;
			this.btnCalculate.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
			this.btnCalculate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
			this.btnCalculate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
			this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCalculate.Font = new System.Drawing.Font("Arial Narrow", 9.75F);
			this.btnCalculate.Image = ((System.Drawing.Image)(resources.GetObject("btnCalculate.Image")));
			this.btnCalculate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCalculate.Location = new System.Drawing.Point(313, 369);
			this.btnCalculate.Margin = new System.Windows.Forms.Padding(4);
			this.btnCalculate.Name = "btnCalculate";
			this.btnCalculate.Size = new System.Drawing.Size(151, 42);
			this.btnCalculate.TabIndex = 7;
			this.btnCalculate.Text = "    CALCULATE";
			this.btnCalculate.UseVisualStyleBackColor = false;
			this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
			// 
			// btnSave
			// 
			this.btnSave.BackColor = System.Drawing.Color.White;
			this.btnSave.FlatAppearance.BorderSize = 0;
			this.btnSave.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
			this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
			this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSave.Font = new System.Drawing.Font("Arial Narrow", 9.75F);
			this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
			this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSave.Location = new System.Drawing.Point(63, 461);
			this.btnSave.Margin = new System.Windows.Forms.Padding(4);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(151, 42);
			this.btnSave.TabIndex = 8;
			this.btnSave.Text = "SAVE";
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// lblMemberId
			// 
			this.lblMemberId.Font = new System.Drawing.Font("Tahoma", 9.75F);
			this.lblMemberId.Location = new System.Drawing.Point(53, 147);
			this.lblMemberId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblMemberId.Name = "lblMemberId";
			this.lblMemberId.Size = new System.Drawing.Size(145, 20);
			this.lblMemberId.TabIndex = 9;
			this.lblMemberId.Text = "Member Id";
			// 
			// txtMemberId
			// 
			this.txtMemberId.Location = new System.Drawing.Point(241, 147);
			this.txtMemberId.Margin = new System.Windows.Forms.Padding(4);
			this.txtMemberId.Name = "txtMemberId";
			this.txtMemberId.Size = new System.Drawing.Size(223, 22);
			this.txtMemberId.TabIndex = 10;
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
			this.addBooks_clearBtn.Location = new System.Drawing.Point(319, 461);
			this.addBooks_clearBtn.Margin = new System.Windows.Forms.Padding(4);
			this.addBooks_clearBtn.Name = "addBooks_clearBtn";
			this.addBooks_clearBtn.Size = new System.Drawing.Size(151, 42);
			this.addBooks_clearBtn.TabIndex = 23;
			this.addBooks_clearBtn.Text = "CLEAR";
			this.addBooks_clearBtn.UseVisualStyleBackColor = false;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.pictureBox2);
			this.panel1.Controls.Add(this.btnSave);
			this.panel1.Controls.Add(this.addBooks_clearBtn);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.txtMemberId);
			this.panel1.Controls.Add(this.btnCalculate);
			this.panel1.Controls.Add(this.lblMemberId);
			this.panel1.Controls.Add(this.txtTotalFine);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.txtFine);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.txtDelayed);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Location = new System.Drawing.Point(349, 16);
			this.panel1.Margin = new System.Windows.Forms.Padding(4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(489, 647);
			this.panel1.TabIndex = 27;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.pictureBox2.Location = new System.Drawing.Point(126, 28);
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
			this.label6.Location = new System.Drawing.Point(171, 33);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(198, 29);
			this.label6.TabIndex = 25;
			this.label6.Text = "Fine Enumeration";
			// 
			// CalculateForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1227, 682);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "CalculateForm";
			this.Text = "CalculateForm";
			this.Load += new System.EventHandler(this.CalculateForm_Load);
			this.VisibleChanged += new System.EventHandler(this.CalculateForm_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDelayed;
        private System.Windows.Forms.TextBox txtFine;
        private System.Windows.Forms.TextBox txtTotalFine;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblMemberId;
        private System.Windows.Forms.TextBox txtMemberId;
		private System.Windows.Forms.Button addBooks_clearBtn;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label label6;
	}
}