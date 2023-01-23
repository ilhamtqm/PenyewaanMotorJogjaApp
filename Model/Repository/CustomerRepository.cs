using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PenyewaanMotorJogjaApp.Model.Entity;
using PenyewaanMotorJogjaApp.Model.Context;
using System.Windows.Forms;

namespace PenyewaanMotorJogjaApp.Model.Repository
{
    public class CustomerRepository
    {
        // deklarsi objek connection
        private SQLiteConnection _conn;

        // constructor
        public CustomerRepository(DbContext context)
        {
            // inisialisasi objek connection
            _conn = context.Conn;
        }
        public int Create(Customer csm)
        {
            int result = 0;

            // deklarasi perintah SQL
            string sql = @"insert into Customer(id_customer, nama_customer, gender_customer, no_identitas, alamat_customer, no_handphone)
                           values (@id_customer, @nama_customer, @gender_customer, @no_identitas, @alamat_customer, @no_handphone)";
            // membuat objek command menggunakan blok using
            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@id_customer", csm.IdCustomer);
                cmd.Parameters.AddWithValue("@nama_customer", csm.NamaCustomer);
                cmd.Parameters.AddWithValue("@gender_customer", csm.GenderCustomer);
                cmd.Parameters.AddWithValue("@no_identitas", csm.NoIdentitas);
                cmd.Parameters.AddWithValue("@alamat_customer", csm.AlamatCustomer);
                cmd.Parameters.AddWithValue("@no_handphone", csm.NoHandphone);

                try
                {
                    // jalankan perintah INSERT dan tampung hasilnya ke dalam variabel result
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Create error: {0}", ex.Message);
                }
            }

            return result;
        }
        public int Update(string idtransaksi, Customer csm)
        {
            int result = 0;

            // deklarasi perintah SQL
            string sql = @"update Customer set nama_customer = @nama_customer, gender_customer = @gender_customer, no_identitas = @no_identitas, alamat_customer = @alamat_customer, no_handphone = @no_handphone where id_customer = @id_customer";

            // membuat objek command menggunakan blok using
            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya

                cmd.Parameters.AddWithValue("@nama_customer", csm.NamaCustomer );
                cmd.Parameters.AddWithValue("@gender_customer", csm.GenderCustomer);
                cmd.Parameters.AddWithValue("@no_identitas", csm.NoIdentitas);
                cmd.Parameters.AddWithValue("@alamat_customer", csm.AlamatCustomer);
                cmd.Parameters.AddWithValue("@no_handphone", csm.NoHandphone);
                cmd.Parameters.AddWithValue("@id_customer", csm.IdCustomer);
                cmd.Parameters.AddWithValue("@id_customer", idtransaksi);


                try
                {
                    // jalankan perintah UPDATE dan tampung hasilnya ke dalam variabel result
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Update error: {0}", ex.Message);
                }
            }

            return result;
        }

        public int Delete(Customer csm)
        {
            int result = 0;

            // deklarasi perintah SQL
            string sql = @"delete from Customer
                           where id_customer = @id_customer";

            // membuat objek command menggunakan blok using
            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@id_customer", csm.IdCustomer);

                try
                {
                    // jalankan perintah DELETE dan tampung hasilnya ke dalam variabel result
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Delete error: {0}", ex.Message);
                }
            }

            return result;
        }
    }
}
