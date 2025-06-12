namespace StudioMusik
{
    partial class RiwayatBookingAdmin
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
            this.historyDataGridView = new System.Windows.Forms.DataGridView();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.logoutMenu = new System.Windows.Forms.Button();
            this.operatorMenu = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.settingMenu = new System.Windows.Forms.Button();
            this.instrumentMenu = new System.Windows.Forms.Button();
            this.reportMenu = new System.Windows.Forms.Button();
            this.historyMenu = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.historyDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // historyDataGridView
            // 
            this.historyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.historyDataGridView.Location = new System.Drawing.Point(510, 285);
            this.historyDataGridView.Name = "historyDataGridView";
            this.historyDataGridView.RowHeadersWidth = 62;
            this.historyDataGridView.RowTemplate.Height = 28;
            this.historyDataGridView.Size = new System.Drawing.Size(1356, 621);
            this.historyDataGridView.TabIndex = 49;
            this.historyDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // searchBox
            // 
            this.searchBox.Font = new System.Drawing.Font("Poppins", 10F);
            this.searchBox.Location = new System.Drawing.Point(836, 199);
            this.searchBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(337, 37);
            this.searchBox.TabIndex = 48;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(503, 198);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(292, 42);
            this.label2.TabIndex = 47;
            this.label2.Text = "Cari Riwayat Booking";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins Medium", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(545, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(525, 99);
            this.label1.TabIndex = 46;
            this.label1.Text = "Riwayat Booking";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(113)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.logoutMenu);
            this.panel1.Controls.Add(this.operatorMenu);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.settingMenu);
            this.panel1.Controls.Add(this.instrumentMenu);
            this.panel1.Controls.Add(this.reportMenu);
            this.panel1.Controls.Add(this.historyMenu);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.button10);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(402, 1074);
            this.panel1.TabIndex = 50;
            this.panel1.TabStop = true;
            // 
            // logoutMenu
            // 
            this.logoutMenu.BackColor = System.Drawing.Color.Black;
            this.logoutMenu.Font = new System.Drawing.Font("Poppins", 13F);
            this.logoutMenu.ForeColor = System.Drawing.Color.White;
            this.logoutMenu.Location = new System.Drawing.Point(32, 814);
            this.logoutMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.logoutMenu.Name = "logoutMenu";
            this.logoutMenu.Size = new System.Drawing.Size(291, 80);
            this.logoutMenu.TabIndex = 6;
            this.logoutMenu.Text = "Logout";
            this.logoutMenu.UseVisualStyleBackColor = false;
            this.logoutMenu.Click += new System.EventHandler(this.logoutMenu_Click_1);
            // 
            // operatorMenu
            // 
            this.operatorMenu.BackColor = System.Drawing.Color.Black;
            this.operatorMenu.Font = new System.Drawing.Font("Poppins", 13F);
            this.operatorMenu.ForeColor = System.Drawing.Color.White;
            this.operatorMenu.Location = new System.Drawing.Point(32, 696);
            this.operatorMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.operatorMenu.Name = "operatorMenu";
            this.operatorMenu.Size = new System.Drawing.Size(291, 80);
            this.operatorMenu.TabIndex = 5;
            this.operatorMenu.Text = "Kelola Operator";
            this.operatorMenu.UseVisualStyleBackColor = false;
            this.operatorMenu.Click += new System.EventHandler(this.logoutMenu_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Black;
            this.button6.Font = new System.Drawing.Font("Poppins", 13F);
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(32, 696);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(291, 80);
            this.button6.TabIndex = 5;
            this.button6.Text = "Logout";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // settingMenu
            // 
            this.settingMenu.BackColor = System.Drawing.Color.Black;
            this.settingMenu.Font = new System.Drawing.Font("Poppins", 13F);
            this.settingMenu.ForeColor = System.Drawing.Color.White;
            this.settingMenu.Location = new System.Drawing.Point(32, 220);
            this.settingMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.settingMenu.Name = "settingMenu";
            this.settingMenu.Size = new System.Drawing.Size(291, 80);
            this.settingMenu.TabIndex = 1;
            this.settingMenu.Text = "Pengaturan studio";
            this.settingMenu.UseVisualStyleBackColor = false;
            this.settingMenu.Click += new System.EventHandler(this.settingMenu_Click);
            // 
            // instrumentMenu
            // 
            this.instrumentMenu.BackColor = System.Drawing.Color.Black;
            this.instrumentMenu.Font = new System.Drawing.Font("Poppins", 13F);
            this.instrumentMenu.ForeColor = System.Drawing.Color.White;
            this.instrumentMenu.Location = new System.Drawing.Point(32, 578);
            this.instrumentMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.instrumentMenu.Name = "instrumentMenu";
            this.instrumentMenu.Size = new System.Drawing.Size(291, 80);
            this.instrumentMenu.TabIndex = 4;
            this.instrumentMenu.Text = "Kelola Alat musik";
            this.instrumentMenu.UseVisualStyleBackColor = false;
            this.instrumentMenu.Click += new System.EventHandler(this.instrumentMenu_Click);
            // 
            // reportMenu
            // 
            this.reportMenu.BackColor = System.Drawing.Color.Black;
            this.reportMenu.Font = new System.Drawing.Font("Poppins", 13F);
            this.reportMenu.ForeColor = System.Drawing.Color.White;
            this.reportMenu.Location = new System.Drawing.Point(32, 342);
            this.reportMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.reportMenu.Name = "reportMenu";
            this.reportMenu.Size = new System.Drawing.Size(291, 80);
            this.reportMenu.TabIndex = 3;
            this.reportMenu.Text = "Laporan";
            this.reportMenu.UseVisualStyleBackColor = false;
            this.reportMenu.Click += new System.EventHandler(this.reportMenu_Click);
            // 
            // historyMenu
            // 
            this.historyMenu.BackColor = System.Drawing.Color.Black;
            this.historyMenu.Font = new System.Drawing.Font("Poppins", 13F);
            this.historyMenu.ForeColor = System.Drawing.Color.White;
            this.historyMenu.Location = new System.Drawing.Point(32, 459);
            this.historyMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.historyMenu.Name = "historyMenu";
            this.historyMenu.Size = new System.Drawing.Size(291, 80);
            this.historyMenu.TabIndex = 2;
            this.historyMenu.Text = "Riwayat booking";
            this.historyMenu.UseVisualStyleBackColor = false;
            this.historyMenu.Click += new System.EventHandler(this.historyMenu_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Black;
            this.button9.Font = new System.Drawing.Font("Poppins", 13F);
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(32, 578);
            this.button9.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(291, 80);
            this.button9.TabIndex = 4;
            this.button9.Text = "Kelola Alat musik";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Black;
            this.button10.Font = new System.Drawing.Font("Poppins", 13F);
            this.button10.ForeColor = System.Drawing.Color.White;
            this.button10.Location = new System.Drawing.Point(32, 459);
            this.button10.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(291, 80);
            this.button10.TabIndex = 2;
            this.button10.Text = "Riwayat pesanan";
            this.button10.UseVisualStyleBackColor = false;
            // 
            // RiwayatBookingAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.historyDataGridView);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RiwayatBookingAdmin";
            this.Text = "RiwayatPemesananAdmin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RiwayatPemesananAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.historyDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView historyDataGridView;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button operatorMenu;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button settingMenu;
        private System.Windows.Forms.Button instrumentMenu;
        private System.Windows.Forms.Button reportMenu;
        private System.Windows.Forms.Button historyMenu;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button logoutMenu;
    }
}