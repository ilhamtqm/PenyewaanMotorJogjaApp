using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PenyewaanMotorJogjaApp.Model.Entity;
using PenyewaanMotorJogjaApp.Model.Repository;
using PenyewaanMotorJogjaApp.Model.Context;

namespace PenyewaanMotorJogjaApp.Controller
{
    public class TransaksiController
    {
        // deklarasi objek Repository untuk menjalankan operasi CRUD
        private TransaksiRepository _repository;
        private CustomerRepository _repositorycustomer;
        private HargaRepository _repositoryharga;

        //Method untuk membuat collection
        public List<Transaksi> ReadByNoPol(string NoPol)
        {
            // membuat objek collection
            List<Transaksi> list = new List<Transaksi>();

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new TransaksiRepository(context);

                // panggil method ReadByNoPol yang ada di dalam class repository
                list = _repository.ReadByNoPol(NoPol);
            }

            return list;
        }

        public int Create(Transaksi trk)
        {
            int result = 0;

            // cek Idtransaksi yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(trk.Customer.IdCustomer))
            {
                MessageBox.Show("ID harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // cek lama pinjam yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(trk.LamaPinjam))
            {
                MessageBox.Show("Lama pinjam harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // cek No Polisi yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(trk.NoPolisi))
            {
                MessageBox.Show("Nomer polisi harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek class repository
                _repository = new TransaksiRepository(context);

                // panggil method Create class repository untuk menambahkan data
                result = _repository.Create(trk);
            }


            return result;
        }

        //Method untuk Update data Transaksi
        public int Update(string idtransaksi, Transaksi trk)
        {
            int result = 0;

            // cek Idtransaksi yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(trk.Idtransaksi))
            {
                MessageBox.Show("ID transaksi harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // cek NamaCustomer yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(trk.Customer.NamaCustomer))
            {
                MessageBox.Show("Nama harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // cek NoIdentitas yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(trk.Customer.NoIdentitas))
            {
                MessageBox.Show("No Identitas harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            // cek NoHandphone yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(trk.Customer.NoHandphone))
            {
                MessageBox.Show("No Handphone harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            // cek LamaPinjam yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(trk.LamaPinjam))
            {
                MessageBox.Show("Lama pinjam harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            // cek LamaPinjam yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(trk.NoPolisi))
            {
                MessageBox.Show("Lama pinjam harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            // cek Harga yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(trk.Harga.HargaPinjam))
            {
                MessageBox.Show("Harga harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new TransaksiRepository(context);
                _repositorycustomer = new CustomerRepository(context);
                _repositoryharga= new HargaRepository(context);
                // panggil method Update class repository untuk mengupdate data
                result += _repository.Update(idtransaksi, trk);
                result += _repositorycustomer.Update(idtransaksi, trk.Customer);
                result += _repositoryharga.Update(idtransaksi, trk.Harga);
            }

            if (result > 0)
            {
                MessageBox.Show("Data Transaksi berhasil diupdate !", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data mahasiswa gagal diupdate !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }

        public int Delete(Transaksi trk)
        {
            int result = 0;

            // cek nilai npm yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(trk.Idtransaksi))
            {
                MessageBox.Show("Id transaksi harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new TransaksiRepository(context);
                _repositorycustomer = new CustomerRepository(context);
                _repositoryharga = new HargaRepository(context);
                // panggil method Delete class repository untuk menghapus data
                result += _repositorycustomer.Delete(trk.Customer);
                result += _repositoryharga.Delete(trk.Harga);
                result += _repository.Delete(trk);
            }

            if (result > 0)
            {
                MessageBox.Show("Data transaksi berhasil dihapus !", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data transaksi gagal dihapus !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }

        //Method untuk membuat collection
        public List<Transaksi> ReadAll()
        {
            // membuat objek collection
            List<Transaksi> list = new List<Transaksi>();

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new TransaksiRepository(context);

                // panggil method ReadAll yang ada di dalam class repository
                list = _repository.ReadAll();
            }

            return list;
        }
        //Method untuk membuat collection
        public List<Transaksi> CariMotor(string nopolisi)
        {
            // membuat objek collection
            List<Transaksi> list = new List<Transaksi>();

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new TransaksiRepository(context);

                // panggil method CariPlat yang ada di dalam class repository
                list = _repository.CariPlat(nopolisi);
            }
            return list;
        }
        //Method untuk membuat collection
        public List<Transaksi> CariNama(string namacus)
        {
            // membuat objek collection
            List<Transaksi> list = new List<Transaksi>();

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new TransaksiRepository(context);

                // panggil method CariNama yang ada di dalam class repository
                list = _repository.CariNama(namacus);
            }
            return list;
        }
        //Method untuk membuat collection
        public List<Transaksi> CariStatus(string namacus)
        {
            // membuat objek collection
            List<Transaksi> list = new List<Transaksi>();

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new TransaksiRepository(context);

                // panggil method GetAll yang ada di dalam class repository
                list = _repository.CariStatus(namacus);
            }
            return list;
        }
        //Method untuk membuat collection
        public List<Transaksi> ReadAllLporan()
        {
            // membuat objek collection
            List<Transaksi> list = new List<Transaksi>();

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new TransaksiRepository(context);

                // panggil method ReadAllLaporan yang ada di dalam class repository
                list = _repository.ReadAllLaporan();
            }

            return list;
        }

    }

}
