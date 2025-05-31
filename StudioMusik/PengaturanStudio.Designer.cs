namespace StudioMusik
{
    partial class PengaturanStudio
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nameInp = new System.Windows.Forms.TextBox();
            this.dataGridViewStudio = new System.Windows.Forms.DataGridView();
            this.addBtn = new System.Windows.Forms.Button();
            this.updBtn = new System.Windows.Forms.Button();
            this.delBtn = new System.Windows.Forms.Button();
            this.descInp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.priceInp = new System.Windows.Forms.NumericUpDown();
            this.avlCheckBox = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.idBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.resBtn = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuOperator = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.menuLogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceInp)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins Medium", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(453, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(587, 99);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pengaturan Studio";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(463, 219);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 42);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama Studio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(463, 292);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 42);
            this.label3.TabIndex = 2;
            this.label3.Text = "Harga sewa";
            // 
            // nameInp
            // 
            this.nameInp.Font = new System.Drawing.Font("Poppins", 10F);
            this.nameInp.Location = new System.Drawing.Point(689, 220);
            this.nameInp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nameInp.Name = "nameInp";
            this.nameInp.Size = new System.Drawing.Size(400, 37);
            this.nameInp.TabIndex = 4;
            // 
            // dataGridViewStudio
            // 
            this.dataGridViewStudio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudio.Location = new System.Drawing.Point(1142, 148);
            this.dataGridViewStudio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewStudio.Name = "dataGridViewStudio";
            this.dataGridViewStudio.RowHeadersWidth = 62;
            this.dataGridViewStudio.Size = new System.Drawing.Size(754, 804);
            this.dataGridViewStudio.TabIndex = 7;
            this.dataGridViewStudio.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // addBtn
            // 
            this.addBtn.Font = new System.Drawing.Font("Poppins Medium", 10F, System.Drawing.FontStyle.Bold);
            this.addBtn.Location = new System.Drawing.Point(442, 729);
            this.addBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(134, 46);
            this.addBtn.TabIndex = 8;
            this.addBtn.Text = "Tambah Studio";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // updBtn
            // 
            this.updBtn.Font = new System.Drawing.Font("Poppins Medium", 10F, System.Drawing.FontStyle.Bold);
            this.updBtn.Location = new System.Drawing.Point(793, 729);
            this.updBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.updBtn.Name = "updBtn";
            this.updBtn.Size = new System.Drawing.Size(134, 46);
            this.updBtn.TabIndex = 9;
            this.updBtn.Text = "Ubah";
            this.updBtn.UseVisualStyleBackColor = true;
            this.updBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // delBtn
            // 
            this.delBtn.Font = new System.Drawing.Font("Poppins Medium", 10F, System.Drawing.FontStyle.Bold);
            this.delBtn.Location = new System.Drawing.Point(614, 729);
            this.delBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(134, 46);
            this.delBtn.TabIndex = 10;
            this.delBtn.Text = "Hapus";
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // descInp
            // 
            this.descInp.Font = new System.Drawing.Font("Poppins", 10F);
            this.descInp.Location = new System.Drawing.Point(689, 363);
            this.descInp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.descInp.Multiline = true;
            this.descInp.Name = "descInp";
            this.descInp.Size = new System.Drawing.Size(400, 150);
            this.descInp.TabIndex = 13;
            this.descInp.TextChanged += new System.EventHandler(this.descInp_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(463, 362);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 42);
            this.label4.TabIndex = 12;
            this.label4.Text = "Deskripsi";
            // 
            // priceInp
            // 
            this.priceInp.Font = new System.Drawing.Font("Poppins", 10F);
            this.priceInp.Location = new System.Drawing.Point(689, 294);
            this.priceInp.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.priceInp.Name = "priceInp";
            this.priceInp.Size = new System.Drawing.Size(400, 37);
            this.priceInp.TabIndex = 14;
            // 
            // avlCheckBox
            // 
            this.avlCheckBox.AutoSize = true;
            this.avlCheckBox.Font = new System.Drawing.Font("Poppins", 10F);
            this.avlCheckBox.Location = new System.Drawing.Point(689, 565);
            this.avlCheckBox.Name = "avlCheckBox";
            this.avlCheckBox.Size = new System.Drawing.Size(126, 40);
            this.avlCheckBox.TabIndex = 15;
            this.avlCheckBox.Text = "Tersedia";
            this.avlCheckBox.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(463, 562);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(190, 42);
            this.label5.TabIndex = 16;
            this.label5.Text = "Status Studio";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // idBox
            // 
            this.idBox.Enabled = false;
            this.idBox.Font = new System.Drawing.Font("Poppins", 10F);
            this.idBox.Location = new System.Drawing.Point(689, 166);
            this.idBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(125, 37);
            this.idBox.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(463, 165);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 42);
            this.label6.TabIndex = 17;
            this.label6.Text = "ID";
            // 
            // resBtn
            // 
            this.resBtn.Font = new System.Drawing.Font("Poppins Medium", 10F, System.Drawing.FontStyle.Bold);
            this.resBtn.Location = new System.Drawing.Point(964, 729);
            this.resBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.resBtn.Name = "resBtn";
            this.resBtn.Size = new System.Drawing.Size(134, 46);
            this.resBtn.TabIndex = 19;
            this.resBtn.Text = "Reset";
            this.resBtn.UseVisualStyleBackColor = true;
            this.resBtn.Click += new System.EventHandler(this.button5_Click);
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
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Black;
            this.button7.Font = new System.Drawing.Font("Poppins", 13F);
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(32, 220);
            this.button7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(291, 80);
            this.button7.TabIndex = 1;
            this.button7.Text = "Pengaturan studio";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Black;
            this.button8.Font = new System.Drawing.Font("Poppins", 13F);
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(32, 342);
            this.button8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(291, 80);
            this.button8.TabIndex = 3;
            this.button8.Text = "Laporan";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(113)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.menuLogout);
            this.panel1.Controls.Add(this.menuOperator);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button11);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.button10);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(402, 1059);
            this.panel1.TabIndex = 20;
            this.panel1.TabStop = true;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // menuOperator
            // 
            this.menuOperator.BackColor = System.Drawing.Color.Black;
            this.menuOperator.Font = new System.Drawing.Font("Poppins", 13F);
            this.menuOperator.ForeColor = System.Drawing.Color.White;
            this.menuOperator.Location = new System.Drawing.Point(32, 696);
            this.menuOperator.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.menuOperator.Name = "menuOperator";
            this.menuOperator.Size = new System.Drawing.Size(291, 80);
            this.menuOperator.TabIndex = 5;
            this.menuOperator.Text = "Kelola Operator";
            this.menuOperator.UseVisualStyleBackColor = false;
            this.menuOperator.Click += new System.EventHandler(this.button12_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.Black;
            this.button11.Font = new System.Drawing.Font("Poppins", 13F);
            this.button11.ForeColor = System.Drawing.Color.White;
            this.button11.Location = new System.Drawing.Point(32, 578);
            this.button11.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(291, 80);
            this.button11.TabIndex = 4;
            this.button11.Text = "Kelola Alat musik";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Black;
            this.button4.Font = new System.Drawing.Font("Poppins", 13F);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(32, 459);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(291, 80);
            this.button4.TabIndex = 2;
            this.button4.Text = "Riwayat booking";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // menuLogout
            // 
            this.menuLogout.BackColor = System.Drawing.Color.Black;
            this.menuLogout.Font = new System.Drawing.Font("Poppins", 13F);
            this.menuLogout.ForeColor = System.Drawing.Color.White;
            this.menuLogout.Location = new System.Drawing.Point(32, 814);
            this.menuLogout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.menuLogout.Name = "menuLogout";
            this.menuLogout.Size = new System.Drawing.Size(291, 80);
            this.menuLogout.TabIndex = 6;
            this.menuLogout.Text = "Logout";
            this.menuLogout.UseVisualStyleBackColor = false;
            this.menuLogout.Click += new System.EventHandler(this.menuLogout_Click);
            // 
            // PengaturanStudio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.resBtn);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.avlCheckBox);
            this.Controls.Add(this.priceInp);
            this.Controls.Add(this.descInp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.updBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.dataGridViewStudio);
            this.Controls.Add(this.nameInp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PengaturanStudio";
            this.Text = "Form4";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PengaturanStudio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceInp)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameInp;
        private System.Windows.Forms.DataGridView dataGridViewStudio;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button updBtn;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.TextBox descInp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown priceInp;
        private System.Windows.Forms.CheckBox avlCheckBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button resBtn;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button menuOperator;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button menuLogout;
    }
}