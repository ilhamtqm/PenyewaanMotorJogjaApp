namespace PenyewaanMotorJogjaApp.View
{
    partial class FrmTransaksi
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
            this.lvwTampilkanTransaksi = new System.Windows.Forms.ListView();
            this.txtCariTransaksi = new System.Windows.Forms.TextBox();
            this.btnCariTransaksi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnSelesai = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvwTampilkanTransaksi
            // 
            this.lvwTampilkanTransaksi.HideSelection = false;
            this.lvwTampilkanTransaksi.Location = new System.Drawing.Point(21, 89);
            this.lvwTampilkanTransaksi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvwTampilkanTransaksi.Name = "lvwTampilkanTransaksi";
            this.lvwTampilkanTransaksi.Size = new System.Drawing.Size(1585, 499);
            this.lvwTampilkanTransaksi.TabIndex = 0;
            this.lvwTampilkanTransaksi.UseCompatibleStateImageBehavior = false;
            // 
            // txtCariTransaksi
            // 
            this.txtCariTransaksi.Location = new System.Drawing.Point(120, 43);
            this.txtCariTransaksi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCariTransaksi.Name = "txtCariTransaksi";
            this.txtCariTransaksi.Size = new System.Drawing.Size(520, 22);
            this.txtCariTransaksi.TabIndex = 1;
            this.txtCariTransaksi.Text = "masukan nomor polisi";
            // 
            // btnCariTransaksi
            // 
            this.btnCariTransaksi.Location = new System.Drawing.Point(647, 43);
            this.btnCariTransaksi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCariTransaksi.Name = "btnCariTransaksi";
            this.btnCariTransaksi.Size = new System.Drawing.Size(75, 23);
            this.btnCariTransaksi.TabIndex = 2;
            this.btnCariTransaksi.Text = "Cari";
            this.btnCariTransaksi.UseVisualStyleBackColor = true;
            this.btnCariTransaksi.Click += new System.EventHandler(this.btnCariTransaksi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cari Transaksi";
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Aqua;
            this.btnEdit.Location = new System.Drawing.Point(580, 623);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.BackColor = System.Drawing.Color.Red;
            this.btnHapus.Location = new System.Drawing.Point(707, 623);
            this.btnHapus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(75, 23);
            this.btnHapus.TabIndex = 5;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = false;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnSelesai
            // 
            this.btnSelesai.Location = new System.Drawing.Point(832, 623);
            this.btnSelesai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSelesai.Name = "btnSelesai";
            this.btnSelesai.Size = new System.Drawing.Size(75, 23);
            this.btnSelesai.TabIndex = 6;
            this.btnSelesai.Text = "Selesai";
            this.btnSelesai.UseVisualStyleBackColor = true;
            this.btnSelesai.Click += new System.EventHandler(this.btnSelesai_Click);
            // 
            // FrmTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1619, 690);
            this.Controls.Add(this.btnSelesai);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCariTransaksi);
            this.Controls.Add(this.txtCariTransaksi);
            this.Controls.Add(this.lvwTampilkanTransaksi);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmTransaksi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Transaksi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvwTampilkanTransaksi;
        private System.Windows.Forms.TextBox txtCariTransaksi;
        private System.Windows.Forms.Button btnCariTransaksi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnSelesai;
    }
}