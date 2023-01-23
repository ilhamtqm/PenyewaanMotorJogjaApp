namespace PenyewaanMotorJogjaApp
{
    partial class FrmPenyewaan
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.transaksiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transaksiBaruToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lihatTransaksiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.motorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tambahStokMotorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laporanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnKeluar = new System.Windows.Forms.Button();
            this.txtUserSkrg = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.gpbLaporan = new System.Windows.Forms.GroupBox();
            this.btnCariLaporan = new System.Windows.Forms.Button();
            this.txtBerdasarStatusTransaksi = new System.Windows.Forms.TextBox();
            this.txtBerdasarNama = new System.Windows.Forms.TextBox();
            this.txtBerdasarPlatNomer = new System.Windows.Forms.TextBox();
            this.rdbStatusTransaksi = new System.Windows.Forms.RadioButton();
            this.rdbNama = new System.Windows.Forms.RadioButton();
            this.rdbPlatNomer = new System.Windows.Forms.RadioButton();
            this.rdbReadAll = new System.Windows.Forms.RadioButton();
            this.lvwLaporan = new System.Windows.Forms.ListView();
            this.menuStrip1.SuspendLayout();
            this.gpbLaporan.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.transaksiToolStripMenuItem,
            this.motorToolStripMenuItem,
            this.laporanToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1245, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // transaksiToolStripMenuItem
            // 
            this.transaksiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.transaksiBaruToolStripMenuItem,
            this.lihatTransaksiToolStripMenuItem});
            this.transaksiToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transaksiToolStripMenuItem.Name = "transaksiToolStripMenuItem";
            this.transaksiToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.transaksiToolStripMenuItem.Text = "Transaksi";
            this.transaksiToolStripMenuItem.Click += new System.EventHandler(this.transaksiToolStripMenuItem_Click);
            // 
            // transaksiBaruToolStripMenuItem
            // 
            this.transaksiBaruToolStripMenuItem.Name = "transaksiBaruToolStripMenuItem";
            this.transaksiBaruToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.transaksiBaruToolStripMenuItem.Text = "Transaksi Baru";
            this.transaksiBaruToolStripMenuItem.Click += new System.EventHandler(this.transaksiBaruToolStripMenuItem_Click);
            // 
            // lihatTransaksiToolStripMenuItem
            // 
            this.lihatTransaksiToolStripMenuItem.Name = "lihatTransaksiToolStripMenuItem";
            this.lihatTransaksiToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.lihatTransaksiToolStripMenuItem.Text = "Lihat Transaksi";
            this.lihatTransaksiToolStripMenuItem.Click += new System.EventHandler(this.lihatTransaksiToolStripMenuItem_Click);
            // 
            // motorToolStripMenuItem
            // 
            this.motorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tambahStokMotorToolStripMenuItem});
            this.motorToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.motorToolStripMenuItem.Name = "motorToolStripMenuItem";
            this.motorToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.motorToolStripMenuItem.Text = "Motor";
            this.motorToolStripMenuItem.Click += new System.EventHandler(this.motorToolStripMenuItem_Click);
            // 
            // tambahStokMotorToolStripMenuItem
            // 
            this.tambahStokMotorToolStripMenuItem.Name = "tambahStokMotorToolStripMenuItem";
            this.tambahStokMotorToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.tambahStokMotorToolStripMenuItem.Text = "Stok Motor";
            this.tambahStokMotorToolStripMenuItem.Click += new System.EventHandler(this.tambahStokMotorToolStripMenuItem_Click);
            // 
            // laporanToolStripMenuItem
            // 
            this.laporanToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laporanToolStripMenuItem.Name = "laporanToolStripMenuItem";
            this.laporanToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.laporanToolStripMenuItem.Text = "Laporan";
            this.laporanToolStripMenuItem.Click += new System.EventHandler(this.laporanToolStripMenuItem_Click);
            // 
            // btnKeluar
            // 
            this.btnKeluar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKeluar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKeluar.Location = new System.Drawing.Point(1124, 30);
            this.btnKeluar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKeluar.Name = "btnKeluar";
            this.btnKeluar.Size = new System.Drawing.Size(111, 31);
            this.btnKeluar.TabIndex = 1;
            this.btnKeluar.Text = "Keluar";
            this.btnKeluar.UseVisualStyleBackColor = true;
            this.btnKeluar.Click += new System.EventHandler(this.btnKeluar_Click);
            // 
            // txtUserSkrg
            // 
            this.txtUserSkrg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUserSkrg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserSkrg.Location = new System.Drawing.Point(870, 30);
            this.txtUserSkrg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUserSkrg.Name = "txtUserSkrg";
            this.txtUserSkrg.ReadOnly = true;
            this.txtUserSkrg.Size = new System.Drawing.Size(234, 26);
            this.txtUserSkrg.TabIndex = 2;
            // 
            // lblUser
            // 
            this.lblUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(807, 33);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(47, 20);
            this.lblUser.TabIndex = 3;
            this.lblUser.Text = "User:";
            // 
            // gpbLaporan
            // 
            this.gpbLaporan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gpbLaporan.AutoSize = true;
            this.gpbLaporan.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gpbLaporan.Controls.Add(this.btnCariLaporan);
            this.gpbLaporan.Controls.Add(this.txtBerdasarStatusTransaksi);
            this.gpbLaporan.Controls.Add(this.txtBerdasarNama);
            this.gpbLaporan.Controls.Add(this.txtBerdasarPlatNomer);
            this.gpbLaporan.Controls.Add(this.rdbStatusTransaksi);
            this.gpbLaporan.Controls.Add(this.rdbNama);
            this.gpbLaporan.Controls.Add(this.rdbPlatNomer);
            this.gpbLaporan.Controls.Add(this.rdbReadAll);
            this.gpbLaporan.Location = new System.Drawing.Point(11, 58);
            this.gpbLaporan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpbLaporan.Name = "gpbLaporan";
            this.gpbLaporan.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpbLaporan.Size = new System.Drawing.Size(1110, 195);
            this.gpbLaporan.TabIndex = 4;
            this.gpbLaporan.TabStop = false;
            this.gpbLaporan.Visible = false;
            // 
            // btnCariLaporan
            // 
            this.btnCariLaporan.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCariLaporan.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnCariLaporan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCariLaporan.Location = new System.Drawing.Point(666, 67);
            this.btnCariLaporan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCariLaporan.Name = "btnCariLaporan";
            this.btnCariLaporan.Size = new System.Drawing.Size(112, 99);
            this.btnCariLaporan.TabIndex = 7;
            this.btnCariLaporan.Text = "Cari";
            this.btnCariLaporan.UseVisualStyleBackColor = false;
            this.btnCariLaporan.Click += new System.EventHandler(this.btnCariLaporan_Click);
            // 
            // txtBerdasarStatusTransaksi
            // 
            this.txtBerdasarStatusTransaksi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBerdasarStatusTransaksi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBerdasarStatusTransaksi.Location = new System.Drawing.Point(366, 139);
            this.txtBerdasarStatusTransaksi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBerdasarStatusTransaksi.Name = "txtBerdasarStatusTransaksi";
            this.txtBerdasarStatusTransaksi.Size = new System.Drawing.Size(278, 26);
            this.txtBerdasarStatusTransaksi.TabIndex = 6;
            // 
            // txtBerdasarNama
            // 
            this.txtBerdasarNama.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBerdasarNama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBerdasarNama.Location = new System.Drawing.Point(366, 102);
            this.txtBerdasarNama.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBerdasarNama.Name = "txtBerdasarNama";
            this.txtBerdasarNama.Size = new System.Drawing.Size(278, 26);
            this.txtBerdasarNama.TabIndex = 5;
            // 
            // txtBerdasarPlatNomer
            // 
            this.txtBerdasarPlatNomer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBerdasarPlatNomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBerdasarPlatNomer.Location = new System.Drawing.Point(366, 66);
            this.txtBerdasarPlatNomer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBerdasarPlatNomer.Name = "txtBerdasarPlatNomer";
            this.txtBerdasarPlatNomer.Size = new System.Drawing.Size(278, 26);
            this.txtBerdasarPlatNomer.TabIndex = 4;
            // 
            // rdbStatusTransaksi
            // 
            this.rdbStatusTransaksi.AutoSize = true;
            this.rdbStatusTransaksi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbStatusTransaksi.Location = new System.Drawing.Point(10, 140);
            this.rdbStatusTransaksi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbStatusTransaksi.Name = "rdbStatusTransaksi";
            this.rdbStatusTransaksi.Padding = new System.Windows.Forms.Padding(0, 0, 22, 0);
            this.rdbStatusTransaksi.Size = new System.Drawing.Size(259, 24);
            this.rdbStatusTransaksi.TabIndex = 3;
            this.rdbStatusTransaksi.TabStop = true;
            this.rdbStatusTransaksi.Text = "Berdasarkan StatusTransaksi";
            this.rdbStatusTransaksi.UseVisualStyleBackColor = true;
            // 
            // rdbNama
            // 
            this.rdbNama.AutoSize = true;
            this.rdbNama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNama.Location = new System.Drawing.Point(10, 102);
            this.rdbNama.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbNama.Name = "rdbNama";
            this.rdbNama.Padding = new System.Windows.Forms.Padding(0, 0, 22, 0);
            this.rdbNama.Size = new System.Drawing.Size(186, 24);
            this.rdbNama.TabIndex = 2;
            this.rdbNama.TabStop = true;
            this.rdbNama.Text = "Berdasarkan Nama";
            this.rdbNama.UseVisualStyleBackColor = true;
            // 
            // rdbPlatNomer
            // 
            this.rdbPlatNomer.AutoSize = true;
            this.rdbPlatNomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPlatNomer.Location = new System.Drawing.Point(10, 66);
            this.rdbPlatNomer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbPlatNomer.Name = "rdbPlatNomer";
            this.rdbPlatNomer.Padding = new System.Windows.Forms.Padding(0, 0, 22, 0);
            this.rdbPlatNomer.Size = new System.Drawing.Size(218, 24);
            this.rdbPlatNomer.TabIndex = 1;
            this.rdbPlatNomer.TabStop = true;
            this.rdbPlatNomer.Text = "Berdasarkan PlatNomer";
            this.rdbPlatNomer.UseVisualStyleBackColor = true;
            // 
            // rdbReadAll
            // 
            this.rdbReadAll.AutoSize = true;
            this.rdbReadAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbReadAll.Location = new System.Drawing.Point(9, 29);
            this.rdbReadAll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbReadAll.Name = "rdbReadAll";
            this.rdbReadAll.Padding = new System.Windows.Forms.Padding(0, 0, 22, 0);
            this.rdbReadAll.Size = new System.Drawing.Size(109, 24);
            this.rdbReadAll.TabIndex = 0;
            this.rdbReadAll.TabStop = true;
            this.rdbReadAll.Text = "Read All";
            this.rdbReadAll.UseVisualStyleBackColor = true;
            // 
            // lvwLaporan
            // 
            this.lvwLaporan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwLaporan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwLaporan.HideSelection = false;
            this.lvwLaporan.Location = new System.Drawing.Point(11, 274);
            this.lvwLaporan.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.lvwLaporan.Name = "lvwLaporan";
            this.lvwLaporan.Size = new System.Drawing.Size(1224, 759);
            this.lvwLaporan.TabIndex = 5;
            this.lvwLaporan.UseCompatibleStateImageBehavior = false;
            this.lvwLaporan.Visible = false;
            // 
            // FrmPenyewaan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1245, 1034);
            this.Controls.Add(this.lvwLaporan);
            this.Controls.Add(this.gpbLaporan);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.txtUserSkrg);
            this.Controls.Add(this.btnKeluar);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmPenyewaan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistem Informasi Penyewaan Motor Jogja";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gpbLaporan.ResumeLayout(false);
            this.gpbLaporan.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem transaksiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transaksiBaruToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lihatTransaksiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem motorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tambahStokMotorToolStripMenuItem;
        private System.Windows.Forms.Button btnKeluar;
        private System.Windows.Forms.TextBox txtUserSkrg;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.ToolStripMenuItem laporanToolStripMenuItem;
        private System.Windows.Forms.GroupBox gpbLaporan;
        private System.Windows.Forms.RadioButton rdbReadAll;
        private System.Windows.Forms.RadioButton rdbPlatNomer;
        private System.Windows.Forms.RadioButton rdbNama;
        private System.Windows.Forms.RadioButton rdbStatusTransaksi;
        private System.Windows.Forms.TextBox txtBerdasarStatusTransaksi;
        private System.Windows.Forms.TextBox txtBerdasarNama;
        private System.Windows.Forms.TextBox txtBerdasarPlatNomer;
        private System.Windows.Forms.ListView lvwLaporan;
        private System.Windows.Forms.Button btnCariLaporan;
    }
}

