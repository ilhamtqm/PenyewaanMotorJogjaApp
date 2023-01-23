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
using PenyewaanMotorJogjaApp.Model.Repository;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PenyewaanMotorJogjaApp.View
{
    public partial class FrmTransaksiBaru : Form
    {
        
        // deklarasi objek collection untuk menampung objek Motor
        private List<Motor> listOfMotor = new List<Motor>();
       
        // deklarasi objek controller
        private TransaksiController controller = new TransaksiController();
        private MotorController controllermotor = new MotorController();
        private CustomerController controllercsustomer = new CustomerController();
        private HargaController controllerharga = new HargaController();
        // deklarasi field untuk menyimpan status entry data (input baru atau update)
        private bool isNewData = true;
        private string idTrkSelect;
        
        // deklarasi field untuk meyimpan objek mahasiswa
        private Transaksi trk;
       
        //constructor default
        public FrmTransaksiBaru()
        {
            
            InitializeComponent();
            InisialisasiListViewMotor();
            cmbGender.SelectedIndex = 0;
            cmbStatusTransaksi.SelectedIndex = 0;
            LoadDataMotor();
            textPetugas.Text = User.TampungNama;
        }

        // constructor untuk inisialisasi data ketika mengedit data
        public FrmTransaksiBaru(string title, Transaksi obj, TransaksiController
        controller)
         : this()
        {
            txtIDCustomer.ReadOnly = true; //disable textbox
            
            // ganti text/judul form
            this.Text = title;
            this.controller = controller;
            isNewData = false; // set status edit data
            trk = obj; // set objek trk yang akan diedit
                       // untuk edit data, tampilkan data lama
            idTrkSelect = trk.Idtransaksi;
            if (isNewData)
            {
                trk = new Transaksi();
                trk.Customer = new Customer();
                trk.Harga = new Harga();
                //hrg = new Harga();
            }
            // set nilai property objek tansaksi ke textbox dan lainnya
            txtIDCustomer.Text = trk.Idtransaksi;
            txtPilihMotor.Text = trk.NoPolisi;
            dtmTglPinjam.Value = Convert.ToDateTime(trk.TglPinjam);
            dtmTglKembali.Value = Convert.ToDateTime(trk.TglKembali);
            int genderselected;
            if (trk.Customer.GenderCustomer == "Laki-Laki")
            {
                genderselected = 0;
            }
            else {
                genderselected = 1;
            }
            cmbGender.SelectedIndex = genderselected;

            int statusselected;
            if(trk.StatusTransaksi == "Dipinjam")
            {
                statusselected = 0;
            }
            else
            {
                statusselected = 1;
            }
            cmbStatusTransaksi.SelectedIndex = statusselected;

            txtLamaPinjam.Text = trk.LamaPinjam;
            txtNama.Text = trk.Customer.NamaCustomer;
            txtNoNIK.Text = trk.Customer.NoIdentitas;
            txtAlamat.Text = trk.Customer.AlamatCustomer;
            txtNoHP.Text = trk.Customer.NoHandphone;
            txtMasukanHarga.Text = trk.Harga.HargaPinjam;
            txtPilihMotor.Text = trk.Harga.NomorPolisi;
            textPetugas.Text = trk.IdPetugas;
          
        }

        private void InisialisasiListViewMotor()
        {
            lvwMotor.View = System.Windows.Forms.View.Details;
            lvwMotor.FullRowSelect = true;
            lvwMotor.GridLines = true;

            lvwMotor.Columns.Add("No.", 30, HorizontalAlignment.Center);
            lvwMotor.Columns.Add("No. Polisi", 100, HorizontalAlignment.Center);
            lvwMotor.Columns.Add("Merk", 80, HorizontalAlignment.Center);
            lvwMotor.Columns.Add("Warna", 80, HorizontalAlignment.Center);
            lvwMotor.Columns.Add("Tahun Produksi", 80, HorizontalAlignment.Center);
            lvwMotor.Columns.Add("Harga", 80, HorizontalAlignment.Center);
            lvwMotor.Columns.Add("Status", 80, HorizontalAlignment.Center);
        }
       
        private void LoadDataMotor()
        {
            // kosongkan listview
            lvwMotor.Items.Clear();
            // panggil method ReadAll dan tampung datanya ke dalam collection
            listOfMotor = controllermotor.ReadAllMotor();
            foreach (var mtr in listOfMotor)
            {
                var noUrut = lvwMotor.Items.Count + 1;
                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(mtr.NoPolisi);
                item.SubItems.Add(mtr.MerekMotor);
                item.SubItems.Add(mtr.WarnaMotor);
                item.SubItems.Add(mtr.ThnProduksi);
                item.SubItems.Add(mtr.Harga);
                item.SubItems.Add(mtr.Status);
                //tampilkan data mtr ke listview
                lvwMotor.Items.Add(item);
            }
        }
        
     

        private void btnPinjam_Click(object sender, EventArgs e)
        {
            listOfMotor = controllermotor.ReadAllMotor();

            // jika data baru, inisialisasi objek mahasiswa
            if (isNewData)
            {
                trk = new Transaksi();
                trk.Customer = new Customer();
                trk.Harga = new Harga();
               //hrg = new Harga();
            }
            // set nilai property objek mahasiswa yg diambil dari TextBox
            trk.Idtransaksi = txtIDCustomer.Text;
            trk.NoPolisi = txtPilihMotor.Text;
            trk.IdHarga = txtIDCustomer.Text;

            trk.Customer.IdCustomer= txtIDCustomer.Text;
;
            trk.Harga.IdHarga= txtIDCustomer.Text;

            trk.TglPinjam = dtmTglPinjam.Value.ToString("yyyy-MM-dd");
            trk.TglKembali = dtmTglKembali.Value.ToString("yyyy-MM-dd");

            trk.LamaPinjam = txtLamaPinjam.Text;
            trk.Customer.IdCustomer = txtIDCustomer.Text;
            trk.Customer.NamaCustomer = txtNama.Text;
  
            trk.Customer.GenderCustomer = cmbGender.Items[cmbGender.SelectedIndex].ToString();
            trk.Customer.NoIdentitas = txtNoNIK.Text;
            trk.Customer.AlamatCustomer = txtAlamat.Text;
            trk.Customer.NoHandphone = txtNoHP.Text;
      
            trk.Harga.IdHarga = txtIDCustomer.Text;
            trk.Harga.HargaPinjam = txtMasukanHarga.Text;
            trk.Harga.NomorPolisi = txtPilihMotor.Text;
            trk.Harga.IdCustomer = txtIDCustomer.Text;

            trk.IdPetugas = textPetugas.Text;
            trk.StatusTransaksi = cmbStatusTransaksi.Items[cmbStatusTransaksi.SelectedIndex].ToString();

            //Ubah data motor jika status transaksi Dipinjam maka akan membuat status motor "Kosong" jika lainnya maka status motor "Tersedia"
            if(trk.StatusTransaksi == "Dipinjam")
            {
                var motor = new Motor
                {
                    NoPolisi = txtPilihMotor.Text
                };
                controllermotor.UpdateStatusMotor(motor);
            }
            else
            {
                var motor = new Motor
                {
                    NoPolisi = txtPilihMotor.Text
                };
                controllermotor.UpdateStatusMotorTersedia(motor);
            }


            int result = 0;

            if (isNewData) // tambah data baru, panggil method Create
            {
                // panggil operasi CRUD
                result = controllercsustomer.Create(trk.Customer);
                result = controller.Create(trk);
                result = controllerharga.Create(trk.Harga);

                

                txtIDCustomer.Clear();
                txtNama.Clear();
                txtNoNIK.Clear();
                txtAlamat.Clear();
                txtNoHP.Clear();
                txtLamaPinjam.Clear();
                txtPilihMotor.Clear();
                txtMasukanHarga.Clear();
                cmbStatusTransaksi.SelectedIndex= 0;
                cmbGender.SelectedIndex= 0;

                txtIDCustomer.Focus();

              
            }
            else // edit data, panggil method Update
            {
                // panggil operasi CRUD
                result = controller.Update(idTrkSelect, trk);
                if (result > 0)
                {
                    //idTrkSelect = "";
                    result = controller.Update(idTrkSelect, trk); // panggil event OnUpdate
                }
            }
        }

        private void btnSelesai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInputMotor_Click(object sender, EventArgs e)
        {
            string NoPol = txtPilihMotor.Text;
            List<Motor> foundCustomers = controllermotor.CariMotor(NoPol);
            
            if (foundCustomers.Count > 0)
            {
                foreach (var item in foundCustomers)
                {
                    float hari;
                    float hargamotor;
                    hari = Convert.ToInt32(txtLamaPinjam.Text);
                    hargamotor = Convert.ToInt32(item.Harga);
                    float hasil = hari * hargamotor;
                    txtMasukanHarga.Text = hasil.ToString("N0");
                }
            }
            else
            {
                MessageBox.Show("Tidak ditemukan plat nomer " + NoPol, "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtNoNIK_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAlamat_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
