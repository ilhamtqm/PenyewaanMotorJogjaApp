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
    public class HargaController
    {
        // deklarasi objek Repository untuk menjalankan operasi CRUD
        private HargaRepository _repositoryharga;

        //Method untuk memasukan data Customer
        public int Create(Harga hrg)
        {
            int result = 0;

            // cek Idtransaksi yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(hrg.HargaPinjam))
            {
                MessageBox.Show("Harga harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek class repository
                _repositoryharga = new HargaRepository(context);

                // panggil method Create class repository untuk menambahkan data
                result = _repositoryharga.Create(hrg);
            }

            return result;
        }
    }
}
