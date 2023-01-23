using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PenyewaanMotorJogjaApp.Model.Entity;
using PenyewaanMotorJogjaApp.Model.Repository;
using PenyewaanMotorJogjaApp.Model.Context;
using System.Windows.Forms;

namespace PenyewaanMotorJogjaApp.Controller
{
    public class MotorController
    {
        // deklarasi objek Repository untuk menjalankan operasi CRUD
        private MotorRepository _repositorymotor;

        //Method untuk Update status motor menjadi "Kosong"
        public int UpdateStatusMotor(Motor motor)
        {
            int result = 0;
            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek class repository
                _repositorymotor = new MotorRepository(context);
                // panggil method UpdateStatusMotor class repository untuk menambahkan data
                result = _repositorymotor.UpdateStatusMotor(motor);
            }
            return result;

        }

        //Method untuk Update status motor menjadi "Tersedia"
        public int UpdateStatusMotorTersedia(Motor motor)
        {
            int result = 0;
            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek class repository
                _repositorymotor = new MotorRepository(context);
                // panggil method UpdateStatusMotorTersedia class repository untuk menambahkan data
                result = _repositorymotor.UpdateStatusMotorTersedia(motor);
            }
            return result;

        }

        //Method untuk memasukan data motor
        public int Create(Motor motor)
        {
            int result = 0;

            // cek NoPolisi yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(motor.NoPolisi))
            {
                MessageBox.Show("Nomer Polisi harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            // cek MerekMotor yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(motor.MerekMotor))
            {
                MessageBox.Show("Merk motor harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            // cek WarnaMotor  yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(motor.WarnaMotor))
            {
                MessageBox.Show("Warna motor harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            // cek NoMesin  yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(motor.NoMesin))
            {
                MessageBox.Show("Nomor mesin harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            // cek Harga  yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(motor.Harga))
            {
                MessageBox.Show("Harga harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            // cek ThnProduksi  yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(motor.ThnProduksi))
            {
                MessageBox.Show("Tahun produksi harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            // cek Status  yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(motor.Status))
            {
                MessageBox.Show("Status motor diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek class repository
                _repositorymotor = new MotorRepository(context);
                // panggil method Create class repository untuk menambahkan data
                result = _repositorymotor.Create(motor);
            }
            return result;

        }

        //Method untuk Update data motor
        public int Update(Motor motor)
        {
            int result = 0;
            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek class repository
                _repositorymotor = new MotorRepository(context);
                // panggil method Update class repository untuk menambahkan data
                result = _repositorymotor.Update(motor);
            }
            return result;

        }

        //Method untuk Delete data motor
        public int Delete(Motor motor)
        {
            int result = 0;
            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek class repository
                _repositorymotor = new MotorRepository(context);
                // panggil method Delete class repository untuk menambahkan data
                result = _repositorymotor.Delete(motor);
            }
            return result;

        }

        //Method untuk membuat collection
        public List<Motor> ReadAllMotor()
        {
            // membuat objek collection
            List<Motor> list = new List<Motor>();

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repositorymotor = new MotorRepository(context);

                // panggil method ReadAll yang ada di dalam class repository
                list = _repositorymotor.ReadAll();
            }
            return list;
        }

        //Method untuk membuat collection
        public List<Motor> CariMotor(string nopolisi)
        {
            // membuat objek collection
            List<Motor> list = new List<Motor>();

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repositorymotor = new MotorRepository(context);

                // panggil method GetAll yang ada di dalam class repository
                list = _repositorymotor.CariPlat(nopolisi);
            }
            return list;
        }
    }
}
