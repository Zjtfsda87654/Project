namespace SMMS_Part_13_
{
    partial class Selr
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Selr));
            this.panel1 = new System.Windows.Forms.Panel();
            this.SellerDGV = new Guna.UI.WinForms.GunaDataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.Seller_Email = new System.Windows.Forms.TextBox();
            this.Seller_Password = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Seller_id = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Prod_Quant = new System.Windows.Forms.Label();
            this.Seller_Account = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Seller_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Cat = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SellerDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.SellerDGV);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Seller_Email);
            this.panel1.Controls.Add(this.Seller_Password);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.Seller_id);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.Prod_Quant);
            this.panel1.Controls.Add(this.Seller_Account);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Seller_Name);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(50, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(838, 538);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // SellerDGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(199)))), ((int)(((byte)(195)))));
            this.SellerDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.SellerDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SellerDGV.BackgroundColor = System.Drawing.Color.White;
            this.SellerDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SellerDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.SellerDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SellerDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.SellerDGV.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(217)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(129)))), ((int)(((byte)(121)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SellerDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.SellerDGV.EnableHeadersVisualStyles = false;
            this.SellerDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(189)))), ((int)(((byte)(184)))));
            this.SellerDGV.Location = new System.Drawing.Point(18, 309);
            this.SellerDGV.Name = "SellerDGV";
            this.SellerDGV.RowHeadersVisible = false;
            this.SellerDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SellerDGV.Size = new System.Drawing.Size(802, 196);
            this.SellerDGV.TabIndex = 25;
            this.SellerDGV.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Red;
            this.SellerDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(199)))), ((int)(((byte)(195)))));
            this.SellerDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.SellerDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.SellerDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.SellerDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.SellerDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.SellerDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(189)))), ((int)(((byte)(184)))));
            this.SellerDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.SellerDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.SellerDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SellerDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.SellerDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.SellerDGV.ThemeStyle.HeaderStyle.Height = 30;
            this.SellerDGV.ThemeStyle.ReadOnly = false;
            this.SellerDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(217)))), ((int)(((byte)(215)))));
            this.SellerDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.SellerDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.SellerDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.SellerDGV.ThemeStyle.RowsStyle.Height = 22;
            this.SellerDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(129)))), ((int)(((byte)(121)))));
            this.SellerDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.SellerDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SellerDGV_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(14, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 23);
            this.label4.TabIndex = 24;
            this.label4.Text = "Password";
            // 
            // Seller_Email
            // 
            this.Seller_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Seller_Email.Location = new System.Drawing.Point(495, 166);
            this.Seller_Email.Multiline = true;
            this.Seller_Email.Name = "Seller_Email";
            this.Seller_Email.Size = new System.Drawing.Size(209, 31);
            this.Seller_Email.TabIndex = 23;
            // 
            // Seller_Password
            // 
            this.Seller_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Seller_Password.Location = new System.Drawing.Point(136, 216);
            this.Seller_Password.Multiline = true;
            this.Seller_Password.Name = "Seller_Password";
            this.Seller_Password.Size = new System.Drawing.Size(205, 32);
            this.Seller_Password.TabIndex = 22;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkRed;
            this.button2.Font = new System.Drawing.Font("Magneto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(672, 266);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 37);
            this.button2.TabIndex = 20;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DarkRed;
            this.button5.Font = new System.Drawing.Font("Magneto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(522, 266);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(109, 37);
            this.button5.TabIndex = 15;
            this.button5.Text = "Update";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkRed;
            this.button4.Font = new System.Drawing.Font("Magneto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(369, 266);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(114, 37);
            this.button4.TabIndex = 11;
            this.button4.Text = "Insert";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // Seller_id
            // 
            this.Seller_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Seller_id.Location = new System.Drawing.Point(136, 120);
            this.Seller_id.Multiline = true;
            this.Seller_id.Name = "Seller_id";
            this.Seller_id.Size = new System.Drawing.Size(205, 32);
            this.Seller_id.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(399, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "Email";
            // 
            // Prod_Quant
            // 
            this.Prod_Quant.AutoSize = true;
            this.Prod_Quant.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Prod_Quant.ForeColor = System.Drawing.Color.DarkRed;
            this.Prod_Quant.Location = new System.Drawing.Point(14, 175);
            this.Prod_Quant.Name = "Prod_Quant";
            this.Prod_Quant.Size = new System.Drawing.Size(116, 23);
            this.Prod_Quant.TabIndex = 6;
            this.Prod_Quant.Text = "Account no";
            // 
            // Seller_Account
            // 
            this.Seller_Account.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Seller_Account.Location = new System.Drawing.Point(136, 166);
            this.Seller_Account.Multiline = true;
            this.Seller_Account.Name = "Seller_Account";
            this.Seller_Account.Size = new System.Drawing.Size(205, 32);
            this.Seller_Account.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(399, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name";
            // 
            // Seller_Name
            // 
            this.Seller_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Seller_Name.Location = new System.Drawing.Point(495, 120);
            this.Seller_Name.Multiline = true;
            this.Seller_Name.Name = "Seller_Name";
            this.Seller_Name.Size = new System.Drawing.Size(209, 32);
            this.Seller_Name.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(14, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Magneto", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(236, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(415, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Seller";
            // 
            // Cat
            // 
            this.Cat.BackColor = System.Drawing.Color.DarkRed;
            this.Cat.Font = new System.Drawing.Font("Magneto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cat.ForeColor = System.Drawing.Color.White;
            this.Cat.Location = new System.Drawing.Point(328, 589);
            this.Cat.Name = "Cat";
            this.Cat.Size = new System.Drawing.Size(283, 46);
            this.Cat.TabIndex = 30;
            this.Cat.Text = "Selling";
            this.Cat.UseVisualStyleBackColor = false;
            this.Cat.Click += new System.EventHandler(this.Cat_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkRed;
            this.label6.Location = new System.Drawing.Point(898, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 25);
            this.label6.TabIndex = 32;
            this.label6.Text = "X";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Selr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(936, 647);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Cat);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Selr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selr";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SellerDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Seller_Email;
        private System.Windows.Forms.TextBox Seller_Password;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox Seller_id;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Prod_Quant;
        private System.Windows.Forms.TextBox Seller_Account;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Seller_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Cat;
        private System.Windows.Forms.Label label6;
        private Guna.UI.WinForms.GunaDataGridView SellerDGV;
    }
}