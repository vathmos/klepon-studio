
namespace StudioMusik
{
    partial class DashboardAdmin
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
            this.label1 = new System.Windows.Forms.Label();
            this.settingMenu = new System.Windows.Forms.Button();
            this.historyMenu = new System.Windows.Forms.Button();
            this.reportMenu = new System.Windows.Forms.Button();
            this.instrumentMenu = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.operatorMenu = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.logoutMenu = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins Medium", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(565, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(574, 99);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dashboard Admin";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // settingMenu
            // 
            this.settingMenu.BackColor = System.Drawing.Color.Black;
            this.settingMenu.Font = new System.Drawing.Font("Tahoma", 15F);
            this.settingMenu.ForeColor = System.Drawing.Color.White;
            this.settingMenu.Location = new System.Drawing.Point(44, 220);
            this.settingMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.settingMenu.Name = "settingMenu";
            this.settingMenu.Size = new System.Drawing.Size(368, 80);
            this.settingMenu.TabIndex = 1;
            this.settingMenu.Text = "Pengaturan studio";
            this.settingMenu.UseVisualStyleBackColor = false;
            this.settingMenu.Click += new System.EventHandler(this.button1_Click);
            // 
            // historyMenu
            // 
            this.historyMenu.BackColor = System.Drawing.Color.Black;
            this.historyMenu.Font = new System.Drawing.Font("Tahoma", 15F);
            this.historyMenu.ForeColor = System.Drawing.Color.White;
            this.historyMenu.Location = new System.Drawing.Point(44, 459);
            this.historyMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.historyMenu.Name = "historyMenu";
            this.historyMenu.Size = new System.Drawing.Size(368, 80);
            this.historyMenu.TabIndex = 2;
            this.historyMenu.Text = "Riwayat pesanan";
            this.historyMenu.UseVisualStyleBackColor = false;
            this.historyMenu.Click += new System.EventHandler(this.button2_Click);
            // 
            // reportMenu
            // 
            this.reportMenu.BackColor = System.Drawing.Color.Black;
            this.reportMenu.Font = new System.Drawing.Font("Tahoma", 15F);
            this.reportMenu.ForeColor = System.Drawing.Color.White;
            this.reportMenu.Location = new System.Drawing.Point(44, 342);
            this.reportMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.reportMenu.Name = "reportMenu";
            this.reportMenu.Size = new System.Drawing.Size(368, 80);
            this.reportMenu.TabIndex = 3;
            this.reportMenu.Text = "Laporan";
            this.reportMenu.UseVisualStyleBackColor = false;
            this.reportMenu.Click += new System.EventHandler(this.button3_Click);
            // 
            // instrumentMenu
            // 
            this.instrumentMenu.BackColor = System.Drawing.Color.Black;
            this.instrumentMenu.Font = new System.Drawing.Font("Tahoma", 15F);
            this.instrumentMenu.ForeColor = System.Drawing.Color.White;
            this.instrumentMenu.Location = new System.Drawing.Point(44, 578);
            this.instrumentMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.instrumentMenu.Name = "instrumentMenu";
            this.instrumentMenu.Size = new System.Drawing.Size(368, 80);
            this.instrumentMenu.TabIndex = 4;
            this.instrumentMenu.Text = "Kelola Alat musik";
            this.instrumentMenu.UseVisualStyleBackColor = false;
            this.instrumentMenu.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(113)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.logoutMenu);
            this.panel1.Controls.Add(this.operatorMenu);
            this.panel1.Controls.Add(this.settingMenu);
            this.panel1.Controls.Add(this.reportMenu);
            this.panel1.Controls.Add(this.instrumentMenu);
            this.panel1.Controls.Add(this.historyMenu);
            this.panel1.Location = new System.Drawing.Point(-4, -7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(510, 1059);
            this.panel1.TabIndex = 6;
            this.panel1.TabStop = true;
            // 
            // operatorMenu
            // 
            this.operatorMenu.BackColor = System.Drawing.Color.Black;
            this.operatorMenu.Font = new System.Drawing.Font("Tahoma", 15F);
            this.operatorMenu.ForeColor = System.Drawing.Color.White;
            this.operatorMenu.Location = new System.Drawing.Point(44, 696);
            this.operatorMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.operatorMenu.Name = "operatorMenu";
            this.operatorMenu.Size = new System.Drawing.Size(368, 80);
            this.operatorMenu.TabIndex = 5;
            this.operatorMenu.Text = "Kelole Operator";
            this.operatorMenu.UseVisualStyleBackColor = false;
            this.operatorMenu.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(113)))), ((int)(((byte)(68)))));
            this.panel2.Location = new System.Drawing.Point(1722, -7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(204, 1059);
            this.panel2.TabIndex = 8;
            // 
            // logoutMenu
            // 
            this.logoutMenu.BackColor = System.Drawing.Color.Black;
            this.logoutMenu.Font = new System.Drawing.Font("Tahoma", 15F);
            this.logoutMenu.ForeColor = System.Drawing.Color.White;
            this.logoutMenu.Location = new System.Drawing.Point(44, 810);
            this.logoutMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.logoutMenu.Name = "logoutMenu";
            this.logoutMenu.Size = new System.Drawing.Size(368, 80);
            this.logoutMenu.TabIndex = 6;
            this.logoutMenu.Text = "Logout";
            this.logoutMenu.UseVisualStyleBackColor = false;
            this.logoutMenu.Click += new System.EventHandler(this.logoutMenu_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::StudioMusik.Properties.Resources.Logo_Klepon_Studio;
            this.pictureBox1.Location = new System.Drawing.Point(650, 141);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1151, 887);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // DashboardAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DashboardAdmin";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DashboardAdmin_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button settingMenu;
        private System.Windows.Forms.Button historyMenu;
        private System.Windows.Forms.Button reportMenu;
        private System.Windows.Forms.Button instrumentMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button operatorMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button logoutMenu;
    }
}