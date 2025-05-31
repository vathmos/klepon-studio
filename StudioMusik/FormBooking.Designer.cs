namespace StudioMusik
{
    partial class FormBooking
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.studioComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nameInp = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.submitBtn = new System.Windows.Forms.Button();
            this.resBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.instrumentCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.extraCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.durInp = new System.Windows.Forms.NumericUpDown();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.logoutMenu = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.settingMenu = new System.Windows.Forms.Button();
            this.instrumentMenu = new System.Windows.Forms.Button();
            this.reportMenu = new System.Windows.Forms.Button();
            this.historyMenu = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.newBookMenu = new System.Windows.Forms.Button();
            this.paymentMenu = new System.Windows.Forms.Button();
            this.logoutMennu = new System.Windows.Forms.Button();
            this.historyMennu = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.durInp)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(724, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 36);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tanggal Pemesanan";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(723, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 36);
            this.label3.TabIndex = 5;
            this.label3.Text = "Jam mulai";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(723, 401);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 36);
            this.label4.TabIndex = 6;
            this.label4.Text = "Durasi";
            // 
            // datePicker
            // 
            this.datePicker.Font = new System.Drawing.Font("Poppins", 10F);
            this.datePicker.Location = new System.Drawing.Point(1017, 241);
            this.datePicker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.datePicker.Name = "datePicker";
            this.datePicker.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.datePicker.Size = new System.Drawing.Size(662, 37);
            this.datePicker.TabIndex = 7;
            // 
            // studioComboBox
            // 
            this.studioComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.studioComboBox.Font = new System.Drawing.Font("Poppins", 10F);
            this.studioComboBox.FormattingEnabled = true;
            this.studioComboBox.ItemHeight = 36;
            this.studioComboBox.Location = new System.Drawing.Point(1017, 487);
            this.studioComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.studioComboBox.Name = "studioComboBox";
            this.studioComboBox.Size = new System.Drawing.Size(606, 44);
            this.studioComboBox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(724, 490);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 36);
            this.label5.TabIndex = 11;
            this.label5.Text = "Pilih Studio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(729, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 36);
            this.label6.TabIndex = 12;
            this.label6.Text = "Nama Band";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // nameInp
            // 
            this.nameInp.Font = new System.Drawing.Font("Poppins", 10F);
            this.nameInp.Location = new System.Drawing.Point(1017, 161);
            this.nameInp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nameInp.Name = "nameInp";
            this.nameInp.Size = new System.Drawing.Size(662, 37);
            this.nameInp.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poppins Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(722, 571);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(256, 36);
            this.label7.TabIndex = 14;
            this.label7.Text = "Alat Musik Tambahan";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // submitBtn
            // 
            this.submitBtn.Font = new System.Drawing.Font("Poppins Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitBtn.Location = new System.Drawing.Point(735, 917);
            this.submitBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(229, 62);
            this.submitBtn.TabIndex = 16;
            this.submitBtn.Text = "Buat Booking";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // resBtn
            // 
            this.resBtn.Font = new System.Drawing.Font("Poppins Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resBtn.Location = new System.Drawing.Point(1017, 917);
            this.resBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.resBtn.Name = "resBtn";
            this.resBtn.Size = new System.Drawing.Size(131, 62);
            this.resBtn.TabIndex = 17;
            this.resBtn.Text = "Reset";
            this.resBtn.UseVisualStyleBackColor = true;
            this.resBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Poppins Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1222, 569);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(253, 36);
            this.label8.TabIndex = 21;
            this.label8.Text = "Peralatan Pendukung";
            // 
            // instrumentCheckedListBox
            // 
            this.instrumentCheckedListBox.Font = new System.Drawing.Font("Poppins", 10F);
            this.instrumentCheckedListBox.FormattingEnabled = true;
            this.instrumentCheckedListBox.Location = new System.Drawing.Point(728, 617);
            this.instrumentCheckedListBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.instrumentCheckedListBox.Name = "instrumentCheckedListBox";
            this.instrumentCheckedListBox.Size = new System.Drawing.Size(394, 242);
            this.instrumentCheckedListBox.TabIndex = 26;
            this.instrumentCheckedListBox.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // extraCheckedListBox
            // 
            this.extraCheckedListBox.Font = new System.Drawing.Font("Poppins", 10F);
            this.extraCheckedListBox.FormattingEnabled = true;
            this.extraCheckedListBox.Location = new System.Drawing.Point(1228, 617);
            this.extraCheckedListBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.extraCheckedListBox.Name = "extraCheckedListBox";
            this.extraCheckedListBox.Size = new System.Drawing.Size(394, 242);
            this.extraCheckedListBox.TabIndex = 27;
            // 
            // durInp
            // 
            this.durInp.Font = new System.Drawing.Font("Poppins", 10F);
            this.durInp.Location = new System.Drawing.Point(1017, 399);
            this.durInp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.durInp.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.durInp.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.durInp.Name = "durInp";
            this.durInp.Size = new System.Drawing.Size(132, 37);
            this.durInp.TabIndex = 28;
            this.durInp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.durInp.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // timePicker
            // 
            this.timePicker.Font = new System.Drawing.Font("Poppins", 10F);
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePicker.Location = new System.Drawing.Point(1017, 317);
            this.timePicker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.timePicker.Name = "timePicker";
            this.timePicker.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.timePicker.Size = new System.Drawing.Size(662, 37);
            this.timePicker.TabIndex = 29;
            this.timePicker.Value = new System.DateTime(2025, 5, 21, 0, 0, 0, 0);
            // 
            // logoutMenu
            // 
            this.logoutMenu.BackColor = System.Drawing.Color.Black;
            this.logoutMenu.Font = new System.Drawing.Font("Poppins", 13F);
            this.logoutMenu.ForeColor = System.Drawing.Color.White;
            this.logoutMenu.Location = new System.Drawing.Point(36, 974);
            this.logoutMenu.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.logoutMenu.Name = "logoutMenu";
            this.logoutMenu.Size = new System.Drawing.Size(323, 112);
            this.logoutMenu.TabIndex = 5;
            this.logoutMenu.Text = "Logout";
            this.logoutMenu.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Black;
            this.button6.Font = new System.Drawing.Font("Poppins", 13F);
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(36, 974);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(323, 112);
            this.button6.TabIndex = 5;
            this.button6.Text = "Logout";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // settingMenu
            // 
            this.settingMenu.BackColor = System.Drawing.Color.Black;
            this.settingMenu.Font = new System.Drawing.Font("Poppins", 13F);
            this.settingMenu.ForeColor = System.Drawing.Color.White;
            this.settingMenu.Location = new System.Drawing.Point(36, 308);
            this.settingMenu.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.settingMenu.Name = "settingMenu";
            this.settingMenu.Size = new System.Drawing.Size(0, 0);
            this.settingMenu.TabIndex = 1;
            this.settingMenu.Text = "Pengaturan studio";
            this.settingMenu.UseVisualStyleBackColor = false;
            // 
            // instrumentMenu
            // 
            this.instrumentMenu.BackColor = System.Drawing.Color.Black;
            this.instrumentMenu.Font = new System.Drawing.Font("Poppins", 13F);
            this.instrumentMenu.ForeColor = System.Drawing.Color.White;
            this.instrumentMenu.Location = new System.Drawing.Point(36, 809);
            this.instrumentMenu.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.instrumentMenu.Name = "instrumentMenu";
            this.instrumentMenu.Size = new System.Drawing.Size(323, 112);
            this.instrumentMenu.TabIndex = 4;
            this.instrumentMenu.Text = "Kelola Alat musik";
            this.instrumentMenu.UseVisualStyleBackColor = false;
            // 
            // reportMenu
            // 
            this.reportMenu.BackColor = System.Drawing.Color.Black;
            this.reportMenu.Font = new System.Drawing.Font("Poppins", 13F);
            this.reportMenu.ForeColor = System.Drawing.Color.White;
            this.reportMenu.Location = new System.Drawing.Point(36, 479);
            this.reportMenu.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.reportMenu.Name = "reportMenu";
            this.reportMenu.Size = new System.Drawing.Size(0, 0);
            this.reportMenu.TabIndex = 3;
            this.reportMenu.Text = "Laporan";
            this.reportMenu.UseVisualStyleBackColor = false;
            // 
            // historyMenu
            // 
            this.historyMenu.BackColor = System.Drawing.Color.Black;
            this.historyMenu.Font = new System.Drawing.Font("Poppins", 13F);
            this.historyMenu.ForeColor = System.Drawing.Color.White;
            this.historyMenu.Location = new System.Drawing.Point(36, 643);
            this.historyMenu.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.historyMenu.Name = "historyMenu";
            this.historyMenu.Size = new System.Drawing.Size(0, 0);
            this.historyMenu.TabIndex = 2;
            this.historyMenu.Text = "Riwayat pesanan";
            this.historyMenu.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Black;
            this.button9.Font = new System.Drawing.Font("Poppins", 13F);
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(36, 809);
            this.button9.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(323, 112);
            this.button9.TabIndex = 4;
            this.button9.Text = "Kelola Alat musik";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Black;
            this.button10.Font = new System.Drawing.Font("Poppins", 13F);
            this.button10.ForeColor = System.Drawing.Color.White;
            this.button10.Location = new System.Drawing.Point(36, 643);
            this.button10.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(0, 0);
            this.button10.TabIndex = 2;
            this.button10.Text = "Riwayat pesanan";
            this.button10.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.panel1.Controls.Add(this.logoutMenu);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.settingMenu);
            this.panel1.Controls.Add(this.instrumentMenu);
            this.panel1.Controls.Add(this.reportMenu);
            this.panel1.Controls.Add(this.historyMenu);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.button10);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 0);
            this.panel1.TabIndex = 38;
            this.panel1.TabStop = true;
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
            this.panel2.TabIndex = 39;
            this.panel2.TabStop = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(1155, 399);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 36);
            this.label1.TabIndex = 40;
            this.label1.Text = "Jam";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Poppins Medium", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(545, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(441, 99);
            this.label9.TabIndex = 42;
            this.label9.Text = "Form Booking";
            // 
            // FormBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.timePicker);
            this.Controls.Add(this.durInp);
            this.Controls.Add(this.extraCheckedListBox);
            this.Controls.Add(this.instrumentCheckedListBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.resBtn);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nameInp);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.studioComboBox);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Poppins", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormBooking";
            this.Text = " ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormPemesanan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.durInp)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.ComboBox studioComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nameInp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Button resBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckedListBox instrumentCheckedListBox;
        private System.Windows.Forms.CheckedListBox extraCheckedListBox;
        private System.Windows.Forms.NumericUpDown durInp;
        private System.Windows.Forms.DateTimePicker timePicker;
        private System.Windows.Forms.Button logoutMenu;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button settingMenu;
        private System.Windows.Forms.Button instrumentMenu;
        private System.Windows.Forms.Button reportMenu;
        private System.Windows.Forms.Button historyMenu;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button newBookMenu;
        private System.Windows.Forms.Button paymentMenu;
        private System.Windows.Forms.Button logoutMennu;
        private System.Windows.Forms.Button historyMennu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
    }
}

