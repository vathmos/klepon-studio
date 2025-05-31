
namespace StudioMusik
{
    partial class FormPembayaran
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
            this.BookingDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mbankingRadio = new System.Windows.Forms.RadioButton();
            this.ewalletRadio = new System.Windows.Forms.RadioButton();
            this.tunaiRadio = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.confirmButton = new System.Windows.Forms.Button();
            this.countBtn = new System.Windows.Forms.Button();
            this.returnLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.idBox = new System.Windows.Forms.TextBox();
            this.payInp = new System.Windows.Forms.NumericUpDown();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BookingDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payInp)).BeginInit();
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
            this.newBookMenu.Click += new System.EventHandler(this.newBookMenu_Click);
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
            // 
            // BookingDataGridView
            // 
            this.BookingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BookingDataGridView.Location = new System.Drawing.Point(556, 196);
            this.BookingDataGridView.Name = "BookingDataGridView";
            this.BookingDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.BookingDataGridView.RowTemplate.Height = 28;
            this.BookingDataGridView.Size = new System.Drawing.Size(1273, 407);
            this.BookingDataGridView.TabIndex = 5;
            this.BookingDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(1236, 765);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 42);
            this.label1.TabIndex = 41;
            this.label1.Text = "Jumlah Tagihan :";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(1480, 765);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(120, 42);
            this.totalLabel.TabIndex = 42;
            this.totalLabel.Text = "Rpxxx.xxx";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(556, 663);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(298, 36);
            this.label3.TabIndex = 43;
            this.label3.Text = "Pilih Metode Pembayaran";
            // 
            // mbankingRadio
            // 
            this.mbankingRadio.AutoSize = true;
            this.mbankingRadio.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mbankingRadio.Location = new System.Drawing.Point(562, 731);
            this.mbankingRadio.Name = "mbankingRadio";
            this.mbankingRadio.Size = new System.Drawing.Size(149, 40);
            this.mbankingRadio.TabIndex = 44;
            this.mbankingRadio.TabStop = true;
            this.mbankingRadio.Text = "M-Banking";
            this.mbankingRadio.UseVisualStyleBackColor = true;
            // 
            // ewalletRadio
            // 
            this.ewalletRadio.AutoSize = true;
            this.ewalletRadio.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ewalletRadio.Location = new System.Drawing.Point(782, 729);
            this.ewalletRadio.Name = "ewalletRadio";
            this.ewalletRadio.Size = new System.Drawing.Size(124, 40);
            this.ewalletRadio.TabIndex = 45;
            this.ewalletRadio.TabStop = true;
            this.ewalletRadio.Text = "E-Wallet";
            this.ewalletRadio.UseVisualStyleBackColor = true;
            // 
            // tunaiRadio
            // 
            this.tunaiRadio.AutoSize = true;
            this.tunaiRadio.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tunaiRadio.Location = new System.Drawing.Point(991, 731);
            this.tunaiRadio.Name = "tunaiRadio";
            this.tunaiRadio.Size = new System.Drawing.Size(159, 40);
            this.tunaiRadio.TabIndex = 46;
            this.tunaiRadio.TabStop = true;
            this.tunaiRadio.Text = "Bayar Tunai";
            this.tunaiRadio.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(556, 813);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(260, 36);
            this.label4.TabIndex = 48;
            this.label4.Text = "Jumlah Yang Di Bayar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(1236, 863);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 42);
            this.label5.TabIndex = 49;
            this.label5.Text = "Kembalian :";
            // 
            // confirmButton
            // 
            this.confirmButton.Font = new System.Drawing.Font("Poppins Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmButton.Location = new System.Drawing.Point(782, 947);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(181, 50);
            this.confirmButton.TabIndex = 51;
            this.confirmButton.Text = "Konfirmasi";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // countBtn
            // 
            this.countBtn.Font = new System.Drawing.Font("Poppins Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countBtn.Location = new System.Drawing.Point(1032, 947);
            this.countBtn.Name = "countBtn";
            this.countBtn.Size = new System.Drawing.Size(143, 50);
            this.countBtn.TabIndex = 52;
            this.countBtn.Text = "Hitung";
            this.countBtn.UseVisualStyleBackColor = true;
            this.countBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // returnLabel
            // 
            this.returnLabel.AutoSize = true;
            this.returnLabel.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnLabel.Location = new System.Drawing.Point(1480, 863);
            this.returnLabel.Name = "returnLabel";
            this.returnLabel.Size = new System.Drawing.Size(120, 42);
            this.returnLabel.TabIndex = 53;
            this.returnLabel.Text = "Rpxxx.xxx";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(1236, 667);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(167, 42);
            this.label8.TabIndex = 54;
            this.label8.Text = "ID Booking :";
            // 
            // idBox
            // 
            this.idBox.Enabled = false;
            this.idBox.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idBox.Location = new System.Drawing.Point(1487, 664);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(113, 43);
            this.idBox.TabIndex = 55;
            // 
            // payInp
            // 
            this.payInp.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payInp.Location = new System.Drawing.Point(865, 813);
            this.payInp.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.payInp.Name = "payInp";
            this.payInp.Size = new System.Drawing.Size(310, 37);
            this.payInp.TabIndex = 56;
            this.payInp.ValueChanged += new System.EventHandler(this.payInp_ValueChanged);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Font = new System.Drawing.Font("Poppins Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.Location = new System.Drawing.Point(1243, 947);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(143, 50);
            this.cancelBtn.TabIndex = 57;
            this.cancelBtn.Text = "Batalkan";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins Medium", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(545, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(586, 99);
            this.label2.TabIndex = 58;
            this.label2.Text = "Form Pembayaran";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(3004, 1372);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 26);
            this.maskedTextBox1.TabIndex = 59;
            // 
            // FormPembayaran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.payInp);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.returnLabel);
            this.Controls.Add(this.countBtn);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tunaiRadio);
            this.Controls.Add(this.ewalletRadio);
            this.Controls.Add(this.mbankingRadio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BookingDataGridView);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormPembayaran";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BookingDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payInp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newBookMenu;
        private System.Windows.Forms.Button paymentMenu;
        private System.Windows.Forms.Button logoutMennu;
        private System.Windows.Forms.Button historyMennu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView BookingDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton mbankingRadio;
        private System.Windows.Forms.RadioButton ewalletRadio;
        private System.Windows.Forms.RadioButton tunaiRadio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Button countBtn;
        private System.Windows.Forms.Label returnLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.NumericUpDown payInp;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}