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
    public class CustomerController
    {
        // deklarasi objek Repository untuk menjalankan operasi CRUD
        private CustomerRepository _repositorycustomer;

        //Method untuk memasukan data Customer
        public int Create(Customer csm)
        {
            int result = 0;

            // cek IdCustomer yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(csm.IdCustomer))
            {
                MessageBox.Show("ID harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            // cek GenderCustomer yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(csm.GenderCustomer))
            {
                MessageBox.Show("Gender harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // cek NamaCustomer yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(csm.NamaCustomer))
            {
                MessageBox.Show("Nama harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // cek NIK yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(csm.NoIdentitas))
            {
                MessageBox.Show("NIK harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // cek AlamatCustomer yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(csm.AlamatCustomer))
            {
                MessageBox.Show("Alamat harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // cek NoHandphone yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(csm.NoHandphone))
            {
                MessageBox.Show("No. HP harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }


            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek class repository
                _repositorycustomer = new CustomerRepository(context);

                // panggil method Create class repository untuk menambahkan data
                result = _repositorycustomer.Create(csm);
            }

         

            return result;
        }
    }
}
