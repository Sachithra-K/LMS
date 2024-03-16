namespace abc_lms
{
    partial class ViewBookForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewBookForm));
			this.btnSearch = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.lblBookId = new System.Windows.Forms.Label();
			this.lblBookQuantity = new System.Windows.Forms.Label();
			this.lblBookPurchaseDate = new System.Windows.Forms.Label();
			this.lblBookPublisher = new System.Windows.Forms.Label();
			this.lblBookAuthor = new System.Windows.Forms.Label();
			this.txtBookId = new System.Windows.Forms.TextBox();
			this.txtBookAuthor = new System.Windows.Forms.TextBox();
			this.txtBookPublisher = new System.Windows.Forms.TextBox();
			this.txtBookQuantity = new System.Windows.Forms.TextBox();
			this.txtBookPurchaseDate = new System.Windows.Forms.TextBox();
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.label5 = new System.Windows.Forms.Label();
			this.lecpanel2 = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
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
			this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(163, 37);
			this.btnSearch.TabIndex = 0;
			this.btnSearch.Text = "SEARCH";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(1011, 414);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(0, 16);
			this.label1.TabIndex = 1;
			// 
			// lblBookId
			// 
			this.lblBookId.Font = new System.Drawing.Font("Tahoma", 9.75F);
			this.lblBookId.Location = new System.Drawing.Point(11, 257);
			this.lblBookId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblBookId.Name = "lblBookId";
			this.lblBookId.Size = new System.Drawing.Size(115, 20);
			this.lblBookId.TabIndex = 6;
			this.lblBookId.Text = "Book Id :";
			// 
			// lblBookQuantity
			// 
			this.lblBookQuantity.Font = new System.Drawing.Font("Tahoma", 9.75F);
			this.lblBookQuantity.Location = new System.Drawing.Point(11, 207);
			this.lblBookQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblBookQuantity.Name = "lblBookQuantity";
			this.lblBookQuantity.Size = new System.Drawing.Size(139, 20);
			this.lblBookQuantity.TabIndex = 7;
			this.lblBookQuantity.Text = "Book Quantity :";
			// 
			// lblBookPurchaseDate
			// 
			this.lblBookPurchaseDate.Font = new System.Drawing.Font("Tahoma", 9.75F);
			this.lblBookPurchaseDate.Location = new System.Drawing.Point(11, 156);
			this.lblBookPurchaseDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblBookPurchaseDate.Name = "lblBookPurchaseDate";
			this.lblBookPurchaseDate.Size = new System.Drawing.Size(145, 20);
			this.lblBookPurchaseDate.TabIndex = 9;
			this.lblBookPurchaseDate.Text = "Purchase Date :";
			// 
			// lblBookPublisher
			// 
			this.lblBookPublisher.Font = new System.Drawing.Font("Tahoma", 9.75F);
			this.lblBookPublisher.Location = new System.Drawing.Point(11, 358);
			this.lblBookPublisher.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblBookPublisher.Name = "lblBookPublisher";
			this.lblBookPublisher.Size = new System.Drawing.Size(139, 20);
			this.lblBookPublisher.TabIndex = 10;
			this.lblBookPublisher.Text = "Book Publisher :";
			// 
			// lblBookAuthor
			// 
			this.lblBookAuthor.Font = new System.Drawing.Font("Tahoma", 9.75F);
			this.lblBookAuthor.Location = new System.Drawing.Point(11, 308);
			this.lblBookAuthor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblBookAuthor.Name = "lblBookAuthor";
			this.lblBookAuthor.Size = new System.Drawing.Size(115, 20);
			this.lblBookAuthor.TabIndex = 11;
			this.lblBookAuthor.Text = "Book Author :";
			// 
			// txtBookId
			// 
			this.txtBookId.Location = new System.Drawing.Point(164, 257);
			this.txtBookId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtBookId.Name = "txtBookId";
			this.txtBookId.Size = new System.Drawing.Size(223, 22);
			this.txtBookId.TabIndex = 12;
			// 
			// txtBookAuthor
			// 
			this.txtBookAuthor.Location = new System.Drawing.Point(164, 308);
			this.txtBookAuthor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtBookAuthor.Name = "txtBookAuthor";
			this.txtBookAuthor.Size = new System.Drawing.Size(223, 22);
			this.txtBookAuthor.TabIndex = 13;
			// 
			// txtBookPublisher
			// 
			this.txtBookPublisher.Location = new System.Drawing.Point(164, 358);
			this.txtBookPublisher.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtBookPublisher.Name = "txtBookPublisher";
			this.txtBookPublisher.Size = new System.Drawing.Size(223, 22);
			this.txtBookPublisher.TabIndex = 14;
			// 
			// txtBookQuantity
			// 
			this.txtBookQuantity.Location = new System.Drawing.Point(164, 207);
			this.txtBookQuantity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtBookQuantity.Name = "txtBookQuantity";
			this.txtBookQuantity.Size = new System.Drawing.Size(223, 22);
			this.txtBookQuantity.TabIndex = 15;
			// 
			// txtBookPurchaseDate
			// 
			this.txtBookPurchaseDate.Location = new System.Drawing.Point(164, 156);
			this.txtBookPurchaseDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtBookPurchaseDate.Name = "txtBookPurchaseDate";
			this.txtBookPurchaseDate.Size = new System.Drawing.Size(223, 22);
			this.txtBookPurchaseDate.TabIndex = 17;
			// 
			// txtSearch
			// 
			this.txtSearch.Location = new System.Drawing.Point(568, 49);
			this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(471, 22);
			this.txtSearch.TabIndex = 18;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.pictureBox2);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.lblBookPublisher);
			this.panel1.Controls.Add(this.lblBookAuthor);
			this.panel1.Controls.Add(this.txtBookPurchaseDate);
			this.panel1.Controls.Add(this.txtBookQuantity);
			this.panel1.Controls.Add(this.lblBookId);
			this.panel1.Controls.Add(this.lblBookQuantity);
			this.panel1.Controls.Add(this.lblBookPurchaseDate);
			this.panel1.Controls.Add(this.txtBookPublisher);
			this.panel1.Controls.Add(this.txtBookAuthor);
			this.panel1.Controls.Add(this.txtBookId);
			this.panel1.Location = new System.Drawing.Point(16, 15);
			this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(409, 647);
			this.panel1.TabIndex = 25;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.pictureBox2.Location = new System.Drawing.Point(107, 30);
			this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(40, 37);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 26;
			this.pictureBox2.TabStop = false;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Tahoma", 14.25F);
			this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label5.Location = new System.Drawing.Point(153, 34);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(134, 29);
			this.label5.TabIndex = 25;
			this.label5.Text = "View Books";
			// 
			// lecpanel2
			// 
			this.lecpanel2.BackColor = System.Drawing.Color.WhiteSmoke;
			this.lecpanel2.Location = new System.Drawing.Point(445, 103);
			this.lecpanel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.lecpanel2.Name = "lecpanel2";
			this.lecpanel2.Size = new System.Drawing.Size(764, 559);
			this.lecpanel2.TabIndex = 27;
			// 
			// ViewBookForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1227, 682);
			this.Controls.Add(this.lecpanel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.txtSearch);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnSearch);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "ViewBookForm";
			this.Text = "ViewBookForm";
			this.Load += new System.EventHandler(this.ViewBookForm_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBookId;
        private System.Windows.Forms.Label lblBookQuantity;
        private System.Windows.Forms.Label lblBookPurchaseDate;
        private System.Windows.Forms.Label lblBookPublisher;
        private System.Windows.Forms.Label lblBookAuthor;
        private System.Windows.Forms.TextBox txtBookId;
        private System.Windows.Forms.TextBox txtBookAuthor;
        private System.Windows.Forms.TextBox txtBookPublisher;
        private System.Windows.Forms.TextBox txtBookQuantity;
        private System.Windows.Forms.TextBox txtBookPurchaseDate;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel lecpanel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
    }
}