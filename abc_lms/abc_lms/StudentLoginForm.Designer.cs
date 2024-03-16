namespace abc_lms
{
    partial class StudentLoginForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentLoginForm));
			this.lblUsername = new System.Windows.Forms.Label();
			this.txtUsername = new System.Windows.Forms.TextBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.btnSave = new System.Windows.Forms.Button();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.btnLogin = new System.Windows.Forms.Button();
			this.btnPrevious = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.login_showPass = new System.Windows.Forms.CheckBox();
			this.label2 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// lblUsername
			// 
			this.lblUsername.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblUsername.Location = new System.Drawing.Point(16, 210);
			this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblUsername.Name = "lblUsername";
			this.lblUsername.Size = new System.Drawing.Size(107, 22);
			this.lblUsername.TabIndex = 1;
			this.lblUsername.Text = "Username";
			// 
			// txtUsername
			// 
			this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUsername.Location = new System.Drawing.Point(15, 236);
			this.txtUsername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtUsername.Multiline = true;
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Size = new System.Drawing.Size(373, 36);
			this.txtUsername.TabIndex = 4;
			// 
			// txtPassword
			// 
			this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPassword.Location = new System.Drawing.Point(15, 303);
			this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtPassword.Multiline = true;
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '*';
			this.txtPassword.Size = new System.Drawing.Size(373, 36);
			this.txtPassword.TabIndex = 5;
			// 
			// btnSave
			// 
			this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSave.Location = new System.Drawing.Point(148, 572);
			this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(100, 32);
			this.btnSave.TabIndex = 7;
			this.btnSave.Text = "SAVE";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Visible = false;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// comboBox1
			// 
			this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "Librarian",
            "Lecturer",
            "Student"});
			this.comboBox1.Location = new System.Drawing.Point(16, 379);
			this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(372, 28);
			this.comboBox1.TabIndex = 10;
			this.comboBox1.Text = "I am a";
			// 
			// btnLogin
			// 
			this.btnLogin.BackColor = System.Drawing.Color.DarkGreen;
			this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
			this.btnLogin.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
			this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen;
			this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
			this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLogin.Font = new System.Drawing.Font("Arial Narrow", 10F);
			this.btnLogin.ForeColor = System.Drawing.Color.White;
			this.btnLogin.Location = new System.Drawing.Point(15, 463);
			this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(375, 49);
			this.btnLogin.TabIndex = 8;
			this.btnLogin.Text = "LOGIN";
			this.btnLogin.UseVisualStyleBackColor = false;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// btnPrevious
			// 
			this.btnPrevious.BackColor = System.Drawing.Color.DarkGreen;
			this.btnPrevious.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
			this.btnPrevious.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
			this.btnPrevious.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen;
			this.btnPrevious.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
			this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPrevious.Font = new System.Drawing.Font("Arial Narrow", 10F);
			this.btnPrevious.ForeColor = System.Drawing.Color.White;
			this.btnPrevious.Location = new System.Drawing.Point(15, 565);
			this.btnPrevious.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnPrevious.Name = "btnPrevious";
			this.btnPrevious.Size = new System.Drawing.Size(375, 49);
			this.btnPrevious.TabIndex = 9;
			this.btnPrevious.Text = "EXIT";
			this.btnPrevious.UseVisualStyleBackColor = false;
			this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(16, 277);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(107, 22);
			this.label1.TabIndex = 11;
			this.label1.Text = "Password";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// login_showPass
			// 
			this.login_showPass.AutoSize = true;
			this.login_showPass.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.login_showPass.Location = new System.Drawing.Point(255, 347);
			this.login_showPass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.login_showPass.Name = "login_showPass";
			this.login_showPass.Size = new System.Drawing.Size(126, 21);
			this.login_showPass.TabIndex = 12;
			this.login_showPass.Text = "Show Password";
			this.login_showPass.UseVisualStyleBackColor = true;
			this.login_showPass.CheckedChanged += new System.EventHandler(this.login_showPass_CheckedChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(152, 144);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(83, 24);
			this.label2.TabIndex = 14;
			this.label2.Text = "Welcome!";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(165, 81);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(65, 59);
			this.pictureBox1.TabIndex = 13;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.BackColor = System.Drawing.Color.DarkGreen;
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(405, 37);
			this.flowLayoutPanel1.TabIndex = 15;
			// 
			// StudentLoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(405, 646);
			this.Controls.Add(this.flowLayoutPanel1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.login_showPass);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.btnPrevious);
			this.Controls.Add(this.btnLogin);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.txtUsername);
			this.Controls.Add(this.lblUsername);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "StudentLoginForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "StudentLoginForm";
			this.Load += new System.EventHandler(this.StudentLoginForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox login_showPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}