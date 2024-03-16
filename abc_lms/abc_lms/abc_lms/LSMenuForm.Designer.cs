namespace abc_lms
{
    partial class LSMenuForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LSMenuForm));
			this.lblMenuForm = new System.Windows.Forms.Label();
			this.btnBorrowing = new System.Windows.Forms.Button();
			this.btnReturn = new System.Windows.Forms.Button();
			this.btnViewBook = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.btnPrevious = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblMenuForm
			// 
			this.lblMenuForm.AutoSize = true;
			this.lblMenuForm.BackColor = System.Drawing.Color.Transparent;
			this.lblMenuForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMenuForm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.lblMenuForm.Location = new System.Drawing.Point(83, 11);
			this.lblMenuForm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblMenuForm.Name = "lblMenuForm";
			this.lblMenuForm.Size = new System.Drawing.Size(294, 52);
			this.lblMenuForm.TabIndex = 0;
			this.lblMenuForm.Text = "Menu Form...";
			// 
			// btnBorrowing
			// 
			this.btnBorrowing.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBorrowing.Location = new System.Drawing.Point(113, 164);
			this.btnBorrowing.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnBorrowing.Name = "btnBorrowing";
			this.btnBorrowing.Size = new System.Drawing.Size(181, 42);
			this.btnBorrowing.TabIndex = 1;
			this.btnBorrowing.Text = "Borrowing";
			this.btnBorrowing.UseVisualStyleBackColor = true;
			this.btnBorrowing.Click += new System.EventHandler(this.btnBorrowing_Click);
			// 
			// btnReturn
			// 
			this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnReturn.Location = new System.Drawing.Point(113, 239);
			this.btnReturn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnReturn.Name = "btnReturn";
			this.btnReturn.Size = new System.Drawing.Size(181, 37);
			this.btnReturn.TabIndex = 2;
			this.btnReturn.Text = "Return";
			this.btnReturn.UseVisualStyleBackColor = true;
			this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
			// 
			// btnViewBook
			// 
			this.btnViewBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnViewBook.Location = new System.Drawing.Point(113, 97);
			this.btnViewBook.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnViewBook.Name = "btnViewBook";
			this.btnViewBook.Size = new System.Drawing.Size(181, 41);
			this.btnViewBook.TabIndex = 3;
			this.btnViewBook.Text = "View Book";
			this.btnViewBook.UseVisualStyleBackColor = true;
			this.btnViewBook.Click += new System.EventHandler(this.btnViewBook_Click);
			// 
			// btnExit
			// 
			this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExit.Location = new System.Drawing.Point(113, 368);
			this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(181, 37);
			this.btnExit.TabIndex = 4;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// btnPrevious
			// 
			this.btnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPrevious.Location = new System.Drawing.Point(113, 309);
			this.btnPrevious.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnPrevious.Name = "btnPrevious";
			this.btnPrevious.Size = new System.Drawing.Size(181, 37);
			this.btnPrevious.TabIndex = 5;
			this.btnPrevious.Text = "Previous";
			this.btnPrevious.UseVisualStyleBackColor = true;
			this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
			// 
			// LSMenuForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(746, 512);
			this.Controls.Add(this.btnPrevious);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnViewBook);
			this.Controls.Add(this.btnReturn);
			this.Controls.Add(this.btnBorrowing);
			this.Controls.Add(this.lblMenuForm);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "LSMenuForm";
			this.Text = "LSMenuForm";
			this.Load += new System.EventHandler(this.LSMenuForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMenuForm;
        private System.Windows.Forms.Button btnBorrowing;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnViewBook;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnPrevious;
    }
}