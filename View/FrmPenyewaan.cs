using PenyewaanMotorJogjaApp.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PenyewaanMotorJogjaApp.Controller;
using PenyewaanMotorJogjaApp.Model.Entity;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms.VisualStyles;

namespace PenyewaanMotorJogjaApp
{
    public partial class FrmPenyewaan : Form
    {
        private List<Transaksi> listOfTransaksi = new List<Transaksi>();
        private TransaksiController controllertransaksi = new TransaksiController();
        public FrmPenyewaan()
        {
            InitializeComponent();
            InisialiasasiLaporanView();
            txtUserSkrg.Text = User.TampungNama;
        }
        private void InisialiasasiLaporanView()
        {
            lvwLaporan.View = System.Windows.Forms.View.Details;
            lvwLaporan.FullRowSelect = true;
            lvwLaporan.GridLines = true;
            lvwLaporan.Columns.Add("No.", 50, HorizontalAlignment.Left);
            lvwLaporan.Columns.Add("Id Transaksi", 120, HorizontalAlignment.Center);
            lvwLaporan.Columns.Add("Nama Customer", 200, HorizontalAlignment.Left);
            lvwLaporan.Columns.Add("No Handphone", 170, HorizontalAlignment.Left);
            lvwLaporan.Columns.Add("No Identitas", 170, HorizontalAlignment.Left);
            lvwLaporan.Columns.Add("Alamat Customer", 200, HorizontalAlignment.Left);
            lvwLaporan.Columns.Add("Plat Nomor", 150, HorizontalAlignment.Left);
            lvwLaporan.Columns.Add("Total Harga", 120, HorizontalAlignment.Right);
            lvwLaporan.Columns.Add("Tgl Pinjam", 180, HorizontalAlignment.Left);
            lvwLaporan.Columns.Add("Tgl Kembali", 180, HorizontalAlignment.Left);
            lvwLaporan.Columns.Add("Boking", 100, HorizontalAlignment.Left);
            lvwLaporan.Columns.Add("Status", 100, HorizontalAlignment.Left);
            lvwLaporan.Columns.Add("Petugas", 150, HorizontalAlignment.Left);

        }
        public void LoadDataLaporan()
        {
            // kosongkan listview
            lvwLaporan.Items.Clear();
            // panggil method ReadAll dan tampung datanya ke dalam collection

            // ekstrak objek mhs dari collection
            foreach (var trk in listOfTransaksi)
            {
                var noUrut = lvwLaporan.Items.Count + 1;
                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(trk.Idtransaksi);
                item.SubItems.Add(trk.Customer.NamaCustomer);
                item.SubItems.Add(trk.Customer.NoHandphone);
                item.SubItems.Add(trk.Customer.NoIdentitas);
                item.SubItems.Add(trk.Customer.AlamatCustomer);
                item.SubItems.Add(trk.Harga.NomorPolisi);
                item.SubItems.Add(trk.Harga.HargaPinjam);
                item.SubItems.Add(trk.TglPinjam);
                item.SubItems.Add(trk.TglKembali);
                item.SubItems.Add(trk.LamaPinjam + "    -hari");
                item.SubItems.Add(trk.StatusTransaksi);
                item.SubItems.Add(trk.IdPetugas);
                lvwLaporan.Items.Add(item);
            }
        }
        public void pencarianlaporan()
        {
            gpbLaporan.Visible = true;
            lvwLaporan.Visible = true;

            if (this.rdbPlatNomer.Checked)
            {
                listOfTransaksi = controllertransaksi.CariMotor(txtBerdasarPlatNomer.Text);
                LoadDataLaporan();
            }
            else if (this.rdbNama.Checked)
            {
                listOfTransaksi = controllertransaksi.CariNama(txtBerdasarNama.Text);
                LoadDataLaporan();
            }
            else if (this.rdbStatusTransaksi.Checked)
            {
                listOfTransaksi = controllertransaksi.CariStatus(txtBerdasarStatusTransaksi.Text);
                LoadDataLaporan();
            }
            else
            {
                listOfTransaksi = controllertransaksi.ReadAllLporan();
                LoadDataLaporan();
            }
        }
        private void transaksiBaruToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gpbLaporan.Visible = false;
            lvwLaporan.Visible = false;

            FrmTransaksiBaru frmTrb = new FrmTransaksiBaru();
            frmTrb.ShowDialog();
        }

        private void lihatTransaksiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gpbLaporan.Visible = false;
            lvwLaporan.Visible = false;

            FrmTransaksi frmTrs = new FrmTransaksi();
            frmTrs.ShowDialog();
        }

        private void tambahStokMotorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gpbLaporan.Visible = false;
            lvwLaporan.Visible = false;

            FrmMotor frmMotor = new FrmMotor();
            frmMotor.Show();
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void laporanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gpbLaporan.Visible = true;
            lvwLaporan.Visible = true;
        }

        private void motorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gpbLaporan.Visible = false;
            lvwLaporan.Visible = false;
        }

        private void transaksiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gpbLaporan.Visible = false;
            lvwLaporan.Visible = false;
        }

        private void btnCariLaporan_Click(object sender, EventArgs e)
        {
            gpbLaporan.Visible = false;
            lvwLaporan.Visible = false;

            pencarianlaporan();
            LoadDataLaporan();
        }
    }
}
