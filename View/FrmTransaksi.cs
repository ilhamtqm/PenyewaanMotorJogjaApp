using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PenyewaanMotorJogjaApp.Model.Entity;
using PenyewaanMotorJogjaApp.Controller;

namespace PenyewaanMotorJogjaApp.View
{
    public partial class FrmTransaksi : Form
    {
        //deklarasi collection untuk menampung objek transaksi
        private List<Transaksi> listOfTransaksi = new List<Transaksi>();
        //deklarasi object controller
        private TransaksiController controller;
        public FrmTransaksi()
        {
            InitializeComponent();
            controller = new TransaksiController();
            InisialiasasiTransaksiView();
            LoadDataTransaksi();
        }
        private void InisialiasasiTransaksiView()
        {
            lvwTampilkanTransaksi.View = System.Windows.Forms.View.Details;
            lvwTampilkanTransaksi.FullRowSelect = true;
            lvwTampilkanTransaksi.GridLines = true;
            lvwTampilkanTransaksi.Columns.Add("No.", 30, HorizontalAlignment.Left);
            lvwTampilkanTransaksi.Columns.Add("Id Transaksi", 80, HorizontalAlignment.Left);
            lvwTampilkanTransaksi.Columns.Add("Nama Customer", 150, HorizontalAlignment.Left);
            lvwTampilkanTransaksi.Columns.Add("Tanggal Pinjam", 120, HorizontalAlignment.Left);
            lvwTampilkanTransaksi.Columns.Add("Tanggal Kembali", 120, HorizontalAlignment.Left);
            lvwTampilkanTransaksi.Columns.Add("Lama Pinjam", 80, HorizontalAlignment.Left);
            lvwTampilkanTransaksi.Columns.Add("No Handphone", 150, HorizontalAlignment.Left);
            lvwTampilkanTransaksi.Columns.Add("No Polisi", 150, HorizontalAlignment.Left);
            lvwTampilkanTransaksi.Columns.Add("Alamat Customer", 120, HorizontalAlignment.Left);
            lvwTampilkanTransaksi.Columns.Add("Id Petugas", 80, HorizontalAlignment.Left);
            lvwTampilkanTransaksi.Columns.Add("Status Transaksi", 100, HorizontalAlignment.Left);

        }
        //tampilkan semua transaksi
        private void LoadDataTransaksi()
        {
            // kosongkan listview
            lvwTampilkanTransaksi.Items.Clear();
            // panggil method ReadAll dan tampung datanya ke dalam collection
            listOfTransaksi = controller.ReadAll();
            // ekstrak objek mhs dari collection
            foreach (var trk in listOfTransaksi)
            {
                var noUrut = lvwTampilkanTransaksi.Items.Count + 1;
                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(trk.Idtransaksi);
                item.SubItems.Add(trk.Customer.NamaCustomer);
                item.SubItems.Add(trk.TglPinjam);
                item.SubItems.Add(trk.TglKembali);
                item.SubItems.Add(trk.LamaPinjam);
                item.SubItems.Add(trk.Customer.NoHandphone);
                item.SubItems.Add(trk.Harga.NomorPolisi);
                item.SubItems.Add(trk.Customer.AlamatCustomer);
                item.SubItems.Add(trk.IdPetugas);
                item.SubItems.Add(trk.StatusTransaksi);
               
                lvwTampilkanTransaksi.Items.Add(item);
            }
        }
       

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (lvwTampilkanTransaksi.SelectedItems.Count > 0)
            {
                var konfirmasi = MessageBox.Show("Apakah data transaksi ingin dihapus ? ", "Konfirmasi",

                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (konfirmasi == DialogResult.Yes)
                {
                    // ambil objek mhs yang mau dihapus dari collection
                    Transaksi trk =
                    listOfTransaksi[lvwTampilkanTransaksi.SelectedIndices[0]];
                    // panggil operasi CRUD
                    var result = controller.Delete(trk);
                    if (result > 0) LoadDataTransaksi();

                }
            }
            else // data belum dipilih
            {
                MessageBox.Show("Data transaksi belum dipilih !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lvwTampilkanTransaksi.SelectedItems.Count > 0)
            { 
            // ambil objek mhs yang mau diedit dari collection
            Transaksi trk = listOfTransaksi[lvwTampilkanTransaksi.SelectedIndices[0]];
                //gsgarg
                // buat objek form entry data mahasiswa
                FrmTransaksiBaru frtEditTransaksi = new FrmTransaksiBaru("Edit Transaksi", trk, controller);
            
            // tampilkan form entry mahasiswa
            frtEditTransaksi.ShowDialog();
            }
            else
            {
              MessageBox.Show("Data belum dipilih", "Peringatan",
              MessageBoxButtons.OK,
              MessageBoxIcon.Exclamation);
            }
        }

        private void btnSelesai_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void btnCariTransaksi_Click(object sender, EventArgs e)
        {
            listOfTransaksi = controller.ReadByNoPol(txtCariTransaksi.Text);
            //kosongkan listView
            lvwTampilkanTransaksi.Items.Clear();
            //ekstrak objek mhs dari collection
            foreach (var trk in listOfTransaksi)
            {
                var noUrut = lvwTampilkanTransaksi.Items.Count + 1;
                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(trk.Idtransaksi);
                item.SubItems.Add(trk.Customer.NamaCustomer);
                item.SubItems.Add(trk.TglPinjam);
                item.SubItems.Add(trk.TglKembali);
                item.SubItems.Add(trk.LamaPinjam);
                item.SubItems.Add(trk.Customer.NoHandphone);
                item.SubItems.Add(trk.Customer.NoIdentitas);
                item.SubItems.Add(trk.Customer.AlamatCustomer);
                item.SubItems.Add(trk.IdPetugas);
                item.SubItems.Add(trk.StatusTransaksi);
                lvwTampilkanTransaksi.Items.Add(item);
            }

        }
    }
}
