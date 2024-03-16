namespace abc_lms
{
    partial class LibrarianLoginForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LibrarianLoginForm));
			this.lblUsername = new System.Windows.Forms.Label();
			this.lblPassword = new System.Windows.Forms.Label();
			this.txtUsername = new System.Windows.Forms.TextBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.btnSave = new System.Windows.Forms.Button();
			this.txtComPassword = new System.Windows.Forms.TextBox();
			this.lblComPassword = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblUsername
			// 
			this.lblUsername.Font = new System.Drawing.Font("Tahoma", 9.75F);
			this.lblUsername.Location = new System.Drawing.Point(45, 103);
			this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblUsername.Name = "lblUsername";
			this.lblUsername.Size = new System.Drawing.Size(145, 20);
			this.lblUsername.TabIndex = 1;
			this.lblUsername.Text = "Username :";
			this.lblUsername.Click += new System.EventHandler(this.lblUsername_Click);
			// 
			// lblPassword
			// 
			this.lblPassword.Font = new System.Drawing.Font("Tahoma", 9.75F);
			this.lblPassword.Location = new System.Drawing.Point(45, 149);
			this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblPassword.Name = "lblPassword";
			this.lblPassword.Size = new System.Drawing.Size(145, 20);
			this.lblPassword.TabIndex = 2;
			this.lblPassword.Text = "Password :";
			// 
			// txtUsername
			// 
			this.txtUsername.Location = new System.Drawing.Point(223, 98);
			this.txtUsername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Size = new System.Drawing.Size(223, 22);
			this.txtUsername.TabIndex = 4;
			this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(223, 146);
			this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(223, 22);
			this.txtPassword.TabIndex = 5;
			this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
			// 
			// btnSave
			// 
			this.btnSave.BackColor = System.Drawing.Color.DarkGreen;
			this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen;
			this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSave.Font = new System.Drawing.Font("Arial Narrow", 10F);
			this.btnSave.ForeColor = System.Drawing.Color.White;
			this.btnSave.Location = new System.Drawing.Point(37, 255);
			this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(397, 49);
			this.btnSave.TabIndex = 7;
			this.btnSave.Text = "SAVE";
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// txtComPassword
			// 
			this.txtComPassword.Location = new System.Drawing.Point(223, 194);
			this.txtComPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtComPassword.Name = "txtComPassword";
			this.txtComPassword.Size = new System.Drawing.Size(223, 22);
			this.txtComPassword.TabIndex = 9;
			// 
			// lblComPassword
			// 
			this.lblComPassword.Font = new System.Drawing.Font("Tahoma", 9.75F);
			this.lblComPassword.Location = new System.Drawing.Point(45, 194);
			this.lblComPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblComPassword.Name = "lblComPassword";
			this.lblComPassword.Size = new System.Drawing.Size(165, 25);
			this.lblComPassword.TabIndex = 8;
			this.lblComPassword.Text = "Comfirm Password :";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(109, 23);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(256, 25);
			this.label2.TabIndex = 11;
			this.label2.Text = "Set Student\'s Credentials";
			// 
			// label1
			// 
			this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.label1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
			this.label1.Location = new System.Drawing.Point(440, 5);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(27, 25);
			this.label1.TabIndex = 10;
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// LibrarianLoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(475, 334);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtComPassword);
			this.Controls.Add(this.lblComPassword);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.txtUsername);
			this.Controls.Add(this.lblPassword);
			this.Controls.Add(this.lblUsername);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "LibrarianLoginForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "LibrarianLoginForm";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtComPassword;
        private System.Windows.Forms.Label lblComPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}