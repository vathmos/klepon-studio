namespace StudioMusik
{
    partial class RiwayatBooking
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
            this.newBookMenu = new System.Windows.Forms.Button();
            this.paymentMenu = new System.Windows.Forms.Button();
            this.logoutMennu = new System.Windows.Forms.Button();
            this.historyMennu = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // newBookMenu
            // 
            this.newBookMenu.BackColor = System.Drawing.Color.Black;
            this.newBookMenu.Font = new System.Drawing.Font("Poppins", 13F);
            this.newBookMenu.ForeColor = System.Drawing.Color.White;
            this.newBookMenu.Location = new System.Drawing.Point(29, 284);
            this.newBookMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.newBookMenu.Name = "newBookMenu";
            this.newBookMenu.Size = new System.Drawing.Size(338, 80);
            this.newBookMenu.TabIndex = 1;
            this.newBookMenu.Text = "Booking Baru";
            this.newBookMenu.UseVisualStyleBackColor = false;
            this.newBookMenu.Click += new System.EventHandler(this.newBookMenu_Click_1);
            // 
            // paymentMenu
            // 
            this.paymentMenu.BackColor = System.Drawing.Color.Black;
            this.paymentMenu.Font = new System.Drawing.Font("Poppins", 13F);
            this.paymentMenu.ForeColor = System.Drawing.Color.White;
            this.paymentMenu.Location = new System.Drawing.Point(29, 406);
            this.paymentMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.paymentMenu.Name = "paymentMenu";
            this.paymentMenu.Size = new System.Drawing.Size(338, 80);
            this.paymentMenu.TabIndex = 3;
            this.paymentMenu.Text = "Pembayaran Booking";
            this.paymentMenu.UseVisualStyleBackColor = false;
            this.paymentMenu.Click += new System.EventHandler(this.paymentMenu_Click);
            // 
            // logoutMennu
            // 
            this.logoutMennu.BackColor = System.Drawing.Color.Black;
            this.logoutMennu.Font = new System.Drawing.Font("Poppins", 13F);
            this.logoutMennu.ForeColor = System.Drawing.Color.White;
            this.logoutMennu.Location = new System.Drawing.Point(29, 642);
            this.logoutMennu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.logoutMennu.Name = "logoutMennu";
            this.logoutMennu.Size = new System.Drawing.Size(338, 80);
            this.logoutMennu.TabIndex = 4;
            this.logoutMennu.Text = "Logout";
            this.logoutMennu.UseVisualStyleBackColor = false;
            this.logoutMennu.Click += new System.EventHandler(this.logoutMennu_Click);
            // 
            // historyMennu
            // 
            this.historyMennu.BackColor = System.Drawing.Color.Black;
            this.historyMennu.Font = new System.Drawing.Font("Poppins", 13F);
            this.historyMennu.ForeColor = System.Drawing.Color.White;
            this.historyMennu.Location = new System.Drawing.Point(29, 523);
            this.historyMennu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.historyMennu.Name = "historyMennu";
            this.historyMennu.Size = new System.Drawing.Size(338, 80);
            this.historyMennu.TabIndex = 2;
            this.historyMennu.Text = "Riwayat Booking";
            this.historyMennu.UseVisualStyleBackColor = false;
            this.historyMennu.Click += new System.EventHandler(this.historyMennu_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(113)))), ((int)(((byte)(68)))));
            this.panel2.Controls.Add(this.newBookMenu);
            this.panel2.Controls.Add(this.paymentMenu);
            this.panel2.Controls.Add(this.logoutMennu);
            this.panel2.Controls.Add(this.historyMennu);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(438, 1059);
            this.panel2.TabIndex = 40;
            this.panel2.TabStop = true;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins Medium", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(545, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(525, 99);
            this.label1.TabIndex = 41;
            this.label1.Text = "Riwayat Booking";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // searchBox
            // 
            this.searchBox.Font = new System.Drawing.Font("Poppins", 10F);
            this.searchBox.Location = new System.Drawing.Point(835, 198);
            this.searchBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(337, 37);
            this.searchBox.TabIndex = 43;
            this.searchBox.TextChanged += new System.EventHandler(this.searchInp_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(502, 197);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(292, 42);
            this.label2.TabIndex = 42;
            this.label2.Text = "Cari Riwayat Booking";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(509, 284);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1356, 621);
            this.dataGridView1.TabIndex = 44;
            // 
            // RiwayatBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Name = "RiwayatBooking";
            this.Text = "RiwayatPemesanan";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RiwayatPemesanan_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newBookMenu;
        private System.Windows.Forms.Button paymentMenu;
        private System.Windows.Forms.Button logoutMennu;
        private System.Windows.Forms.Button historyMennu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}