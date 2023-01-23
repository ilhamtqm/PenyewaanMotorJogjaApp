using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PenyewaanMotorJogjaApp.Model.Entity;
using PenyewaanMotorJogjaApp.Model.Context;
using System.Data.SQLite;

namespace PenyewaanMotorJogjaApp.Model.Repository
{
    public class HargaRepository
    {
        // deklarsi objek connection
        private SQLiteConnection _conn;

        // constructor
        public HargaRepository(DbContext context)
        {
            // inisialisasi objek connection
            _conn = context.Conn;
        }
        public int Create(Harga hrg)
        {
            int result = 0;

            // deklarasi perintah SQL
            string sql = @"insert into Harga(id_harga, harga_pinjam, nomor_polisi, id_customer)
                           values (@id_harga, @harga_pinjam, @nomor_polisi, @id_customer)";

            // membuat objek command menggunakan blok using
            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@id_harga", hrg.IdHarga);
                cmd.Parameters.AddWithValue("@harga_pinjam", hrg.HargaPinjam);
                cmd.Parameters.AddWithValue("@nomor_polisi", hrg.NomorPolisi);
                cmd.Parameters.AddWithValue("@id_customer", hrg.IdCustomer);

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
        public int Update(string idtransaksi, Harga hrg)
        {
            int result = 0;

            // deklarasi perintah SQL
            string sql = @"update Harga set harga_pinjam = @harga_pinjam, nomor_polisi = @nomor_polisi, id_customer = @id_customer where id_harga = @id_harga";

            // membuat objek command menggunakan blok using
            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya

                cmd.Parameters.AddWithValue("@harga_pinjam", hrg.HargaPinjam);
                cmd.Parameters.AddWithValue("@nomor_polisi", hrg.NomorPolisi);
                cmd.Parameters.AddWithValue("@id_customer", hrg.IdCustomer);
                cmd.Parameters.AddWithValue("@id_harga", hrg.IdHarga);
                cmd.Parameters.AddWithValue("@id_harga", idtransaksi);


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
        public int Delete(Harga hrg)
        {
            int result = 0;

            // deklarasi perintah SQL
            string sql = @"delete from Harga
                           where id_harga = @id_harga";

            // membuat objek command menggunakan blok using
            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@id_harga", hrg.IdHarga);

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
