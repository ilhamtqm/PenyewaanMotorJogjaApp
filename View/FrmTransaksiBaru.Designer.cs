namespace PenyewaanMotorJogjaApp.View
{
    partial class FrmTransaksiBaru
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
            this.lblIDCustomer = new System.Windows.Forms.Label();
            this.txtIDCustomer = new System.Windows.Forms.TextBox();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.lblNama = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblNoNIK = new System.Windows.Forms.Label();
            this.txtNoNIK = new System.Windows.Forms.TextBox();
            this.btnPinjam = new System.Windows.Forms.Button();
            this.btnSelesai = new System.Windows.Forms.Button();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.lblAlamat = new System.Windows.Forms.Label();
            this.lblNoHP = new System.Windows.Forms.Label();
            this.txtNoHP = new System.Windows.Forms.TextBox();
            this.lblTglPinjam = new System.Windows.Forms.Label();
            this.dtmTglPinjam = new System.Windows.Forms.DateTimePicker();
            this.lblLamaPinjam = new System.Windows.Forms.Label();
            this.txtLamaPinjam = new System.Windows.Forms.TextBox();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.lvwMotor = new System.Windows.Forms.ListView();
            this.lblOpsiMotor = new System.Windows.Forms.Label();
            this.txtPilihMotor = new System.Windows.Forms.TextBox();
            this.dtmTglKembali = new System.Windows.Forms.DateTimePicker();
            this.lblTglKembali = new System.Windows.Forms.Label();
            this.lblPilihanMotor = new System.Windows.Forms.Label();
            this.lblMasukanHarga = new System.Windows.Forms.Label();
            this.txtMasukanHarga = new System.Windows.Forms.TextBox();
            this.textPetugas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbStatusTransaksi = new System.Windows.Forms.ComboBox();
            this.lblStatusTransaksi = new System.Windows.Forms.Label();
            this.btnInputMotor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIDCustomer
            // 
            this.lblIDCustomer.AutoSize = true;
            this.lblIDCustomer.Location = new System.Drawing.Point(23, 96);
            this.lblIDCustomer.Name = "lblIDCustomer";
            this.lblIDCustomer.Size = new System.Drawing.Size(80, 16);
            this.lblIDCustomer.TabIndex = 0;
            this.lblIDCustomer.Text = "ID Customer";
            // 
            // txtIDCustomer
            // 
            this.txtIDCustomer.Location = new System.Drawing.Point(129, 96);
            this.txtIDCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIDCustomer.Name = "txtIDCustomer";
            this.txtIDCustomer.Size = new System.Drawing.Size(345, 22);
            this.txtIDCustomer.TabIndex = 1;
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(129, 134);
            this.txtNama.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(345, 22);
            this.txtNama.TabIndex = 2;
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Location = new System.Drawing.Point(23, 138);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(44, 16);
            this.lblNama.TabIndex = 3;
            this.lblNama.Text = "Nama";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(23, 183);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(52, 16);
            this.lblGender.TabIndex = 5;
            this.lblGender.Text = "Gender";
            // 
            // lblNoNIK
            // 
            this.lblNoNIK.AutoSize = true;
            this.lblNoNIK.Location = new System.Drawing.Point(23, 224);
            this.lblNoNIK.Name = "lblNoNIK";
            this.lblNoNIK.Size = new System.Drawing.Size(52, 16);
            this.lblNoNIK.TabIndex = 6;
            this.lblNoNIK.Text = "No. NIK";
            // 
            // txtNoNIK
            // 
            this.txtNoNIK.Location = new System.Drawing.Point(129, 219);
            this.txtNoNIK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNoNIK.Name = "txtNoNIK";
            this.txtNoNIK.Size = new System.Drawing.Size(345, 22);
            this.txtNoNIK.TabIndex = 7;
            this.txtNoNIK.TextChanged += new System.EventHandler(this.txtNoNIK_TextChanged);
            // 
            // btnPinjam
            // 
            this.btnPinjam.BackColor = System.Drawing.Color.Lime;
            this.btnPinjam.Location = new System.Drawing.Point(1140, 475);
            this.btnPinjam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPinjam.Name = "btnPinjam";
            this.btnPinjam.Size = new System.Drawing.Size(75, 23);
            this.btnPinjam.TabIndex = 8;
            this.btnPinjam.Text = "Pinjam!";
            this.btnPinjam.UseVisualStyleBackColor = false;
            this.btnPinjam.Click += new System.EventHandler(this.btnPinjam_Click);
            // 
            // btnSelesai
            // 
            this.btnSelesai.Location = new System.Drawing.Point(1007, 475);
            this.btnSelesai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSelesai.Name = "btnSelesai";
            this.btnSelesai.Size = new System.Drawing.Size(75, 23);
            this.btnSelesai.TabIndex = 9;
            this.btnSelesai.Text = "Selesai";
            this.btnSelesai.UseVisualStyleBackColor = true;
            this.btnSelesai.Click += new System.EventHandler(this.btnSelesai_Click);
            // 
            // txtAlamat
            // 
            this.txtAlamat.Location = new System.Drawing.Point(129, 266);
            this.txtAlamat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(345, 22);
            this.txtAlamat.TabIndex = 10;
            this.txtAlamat.TextChanged += new System.EventHandler(this.txtAlamat_TextChanged);
            // 
            // lblAlamat
            // 
            this.lblAlamat.AutoSize = true;
            this.lblAlamat.Location = new System.Drawing.Point(23, 270);
            this.lblAlamat.Name = "lblAlamat";
            this.lblAlamat.Size = new System.Drawing.Size(49, 16);
            this.lblAlamat.TabIndex = 11;
            this.lblAlamat.Text = "Alamat";
            // 
            // lblNoHP
            // 
            this.lblNoHP.AutoSize = true;
            this.lblNoHP.Location = new System.Drawing.Point(23, 314);
            this.lblNoHP.Name = "lblNoHP";
            this.lblNoHP.Size = new System.Drawing.Size(44, 16);
            this.lblNoHP.TabIndex = 12;
            this.lblNoHP.Text = "NoHP";
            // 
            // txtNoHP
            // 
            this.txtNoHP.Location = new System.Drawing.Point(129, 310);
            this.txtNoHP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNoHP.Name = "txtNoHP";
            this.txtNoHP.Size = new System.Drawing.Size(345, 22);
            this.txtNoHP.TabIndex = 13;
            // 
            // lblTglPinjam
            // 
            this.lblTglPinjam.AutoSize = true;
            this.lblTglPinjam.Location = new System.Drawing.Point(23, 350);
            this.lblTglPinjam.Name = "lblTglPinjam";
            this.lblTglPinjam.Size = new System.Drawing.Size(71, 16);
            this.lblTglPinjam.TabIndex = 14;
            this.lblTglPinjam.Text = "Tgl Pinjam";
            // 
            // dtmTglPinjam
            // 
            this.dtmTglPinjam.Location = new System.Drawing.Point(129, 350);
            this.dtmTglPinjam.Margin = new System.Windows.Forms.Padding(4);
            this.dtmTglPinjam.Name = "dtmTglPinjam";
            this.dtmTglPinjam.Size = new System.Drawing.Size(265, 22);
            this.dtmTglPinjam.TabIndex = 15;
            // 
            // lblLamaPinjam
            // 
            this.lblLamaPinjam.AutoSize = true;
            this.lblLamaPinjam.Location = new System.Drawing.Point(23, 423);
            this.lblLamaPinjam.Name = "lblLamaPinjam";
            this.lblLamaPinjam.Size = new System.Drawing.Size(85, 16);
            this.lblLamaPinjam.TabIndex = 16;
            this.lblLamaPinjam.Text = "Lama Pinjam";
            // 
            // txtLamaPinjam
            // 
            this.txtLamaPinjam.Location = new System.Drawing.Point(129, 420);
            this.txtLamaPinjam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLamaPinjam.Name = "txtLamaPinjam";
            this.txtLamaPinjam.Size = new System.Drawing.Size(345, 22);
            this.txtLamaPinjam.TabIndex = 17;
            // 
            // cmbGender
            // 
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Laki-Laki",
            "Perempuan"});
            this.cmbGender.Location = new System.Drawing.Point(129, 176);
            this.cmbGender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(121, 24);
            this.cmbGender.TabIndex = 4;
            // 
            // lvwMotor
            // 
            this.lvwMotor.HideSelection = false;
            this.lvwMotor.Location = new System.Drawing.Point(503, 50);
            this.lvwMotor.Margin = new System.Windows.Forms.Padding(4);
            this.lvwMotor.Name = "lvwMotor";
            this.lvwMotor.Size = new System.Drawing.Size(725, 239);
            this.lvwMotor.TabIndex = 18;
            this.lvwMotor.UseCompatibleStateImageBehavior = false;
            // 
            // lblOpsiMotor
            // 
            this.lblOpsiMotor.AutoSize = true;
            this.lblOpsiMotor.Location = new System.Drawing.Point(500, 17);
            this.lblOpsiMotor.Name = "lblOpsiMotor";
            this.lblOpsiMotor.Size = new System.Drawing.Size(72, 16);
            this.lblOpsiMotor.TabIndex = 19;
            this.lblOpsiMotor.Text = "Opsi Motor";
            // 
            // txtPilihMotor
            // 
            this.txtPilihMotor.Location = new System.Drawing.Point(503, 316);
            this.txtPilihMotor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPilihMotor.Name = "txtPilihMotor";
            this.txtPilihMotor.Size = new System.Drawing.Size(345, 22);
            this.txtPilihMotor.TabIndex = 20;
            // 
            // dtmTglKembali
            // 
            this.dtmTglKembali.Location = new System.Drawing.Point(129, 383);
            this.dtmTglKembali.Margin = new System.Windows.Forms.Padding(4);
            this.dtmTglKembali.Name = "dtmTglKembali";
            this.dtmTglKembali.Size = new System.Drawing.Size(265, 22);
            this.dtmTglKembali.TabIndex = 21;
            // 
            // lblTglKembali
            // 
            this.lblTglKembali.AutoSize = true;
            this.lblTglKembali.Location = new System.Drawing.Point(23, 390);
            this.lblTglKembali.Name = "lblTglKembali";
            this.lblTglKembali.Size = new System.Drawing.Size(79, 16);
            this.lblTglKembali.TabIndex = 22;
            this.lblTglKembali.Text = "Tgl Kembali";
            // 
            // lblPilihanMotor
            // 
            this.lblPilihanMotor.AutoSize = true;
            this.lblPilihanMotor.Location = new System.Drawing.Point(499, 298);
            this.lblPilihanMotor.Name = "lblPilihanMotor";
            this.lblPilihanMotor.Size = new System.Drawing.Size(204, 16);
            this.lblPilihanMotor.TabIndex = 23;
            this.lblPilihanMotor.Text = "Masukan Pilihan Motor (NoPolisi)";
            // 
            // lblMasukanHarga
            // 
            this.lblMasukanHarga.AutoSize = true;
            this.lblMasukanHarga.Location = new System.Drawing.Point(500, 353);
            this.lblMasukanHarga.Name = "lblMasukanHarga";
            this.lblMasukanHarga.Size = new System.Drawing.Size(103, 16);
            this.lblMasukanHarga.TabIndex = 24;
            this.lblMasukanHarga.Text = "Masukan Harga";
            // 
            // txtMasukanHarga
            // 
            this.txtMasukanHarga.Location = new System.Drawing.Point(503, 372);
            this.txtMasukanHarga.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMasukanHarga.Name = "txtMasukanHarga";
            this.txtMasukanHarga.Size = new System.Drawing.Size(345, 22);
            this.txtMasukanHarga.TabIndex = 25;
            // 
            // textPetugas
            // 
            this.textPetugas.Enabled = false;
            this.textPetugas.Location = new System.Drawing.Point(129, 11);
            this.textPetugas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textPetugas.Name = "textPetugas";
            this.textPetugas.Size = new System.Drawing.Size(345, 22);
            this.textPetugas.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(27, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 18);
            this.label1.TabIndex = 27;
            this.label1.Text = "Petugas";
            // 
            // cmbStatusTransaksi
            // 
            this.cmbStatusTransaksi.FormattingEnabled = true;
            this.cmbStatusTransaksi.Items.AddRange(new object[] {
            "Dipinjam",
            "Selesai"});
            this.cmbStatusTransaksi.Location = new System.Drawing.Point(503, 422);
            this.cmbStatusTransaksi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbStatusTransaksi.Name = "cmbStatusTransaksi";
            this.cmbStatusTransaksi.Size = new System.Drawing.Size(213, 24);
            this.cmbStatusTransaksi.TabIndex = 28;
            // 
            // lblStatusTransaksi
            // 
            this.lblStatusTransaksi.AutoSize = true;
            this.lblStatusTransaksi.Location = new System.Drawing.Point(500, 404);
            this.lblStatusTransaksi.Name = "lblStatusTransaksi";
            this.lblStatusTransaksi.Size = new System.Drawing.Size(107, 16);
            this.lblStatusTransaksi.TabIndex = 29;
            this.lblStatusTransaksi.Text = "Status Transaksi";
            // 
            // btnInputMotor
            // 
            this.btnInputMotor.Location = new System.Drawing.Point(856, 314);
            this.btnInputMotor.Margin = new System.Windows.Forms.Padding(4);
            this.btnInputMotor.Name = "btnInputMotor";
            this.btnInputMotor.Size = new System.Drawing.Size(100, 28);
            this.btnInputMotor.TabIndex = 30;
            this.btnInputMotor.Text = "Input";
            this.btnInputMotor.UseVisualStyleBackColor = true;
            this.btnInputMotor.Click += new System.EventHandler(this.btnInputMotor_Click);
            // 
            // FrmTransaksiBaru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 521);
            this.Controls.Add(this.btnInputMotor);
            this.Controls.Add(this.lblStatusTransaksi);
            this.Controls.Add(this.cmbStatusTransaksi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textPetugas);
            this.Controls.Add(this.txtMasukanHarga);
            this.Controls.Add(this.lblMasukanHarga);
            this.Controls.Add(this.lblPilihanMotor);
            this.Controls.Add(this.lblTglKembali);
            this.Controls.Add(this.dtmTglKembali);
            this.Controls.Add(this.txtPilihMotor);
            this.Controls.Add(this.lblOpsiMotor);
            this.Controls.Add(this.lvwMotor);
            this.Controls.Add(this.txtLamaPinjam);
            this.Controls.Add(this.lblLamaPinjam);
            this.Controls.Add(this.dtmTglPinjam);
            this.Controls.Add(this.lblTglPinjam);
            this.Controls.Add(this.txtNoHP);
            this.Controls.Add(this.lblNoHP);
            this.Controls.Add(this.lblAlamat);
            this.Controls.Add(this.txtAlamat);
            this.Controls.Add(this.btnSelesai);
            this.Controls.Add(this.btnPinjam);
            this.Controls.Add(this.txtNoNIK);
            this.Controls.Add(this.lblNoNIK);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.lblNama);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.txtIDCustomer);
            this.Controls.Add(this.lblIDCustomer);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmTransaksiBaru";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Transaksi Baru";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIDCustomer;
        private System.Windows.Forms.TextBox txtIDCustomer;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblNoNIK;
        private System.Windows.Forms.TextBox txtNoNIK;
        private System.Windows.Forms.Button btnPinjam;
        private System.Windows.Forms.Button btnSelesai;
        private System.Windows.Forms.TextBox txtAlamat;
        private System.Windows.Forms.Label lblAlamat;
        private System.Windows.Forms.Label lblNoHP;
        private System.Windows.Forms.TextBox txtNoHP;
        private System.Windows.Forms.Label lblTglPinjam;
        private System.Windows.Forms.DateTimePicker dtmTglPinjam;
        private System.Windows.Forms.Label lblLamaPinjam;
        private System.Windows.Forms.TextBox txtLamaPinjam;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.ListView lvwMotor;
        private System.Windows.Forms.Label lblOpsiMotor;
        private System.Windows.Forms.TextBox txtPilihMotor;
        private System.Windows.Forms.DateTimePicker dtmTglKembali;
        private System.Windows.Forms.Label lblTglKembali;
        private System.Windows.Forms.Label lblPilihanMotor;
        private System.Windows.Forms.Label lblMasukanHarga;
        private System.Windows.Forms.TextBox txtMasukanHarga;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textPetugas;
        private System.Windows.Forms.ComboBox cmbStatusTransaksi;
        private System.Windows.Forms.Label lblStatusTransaksi;
        private System.Windows.Forms.Button btnInputMotor;
    }
}