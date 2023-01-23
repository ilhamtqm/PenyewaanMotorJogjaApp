using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PenyewaanMotorJogjaApp.Model.Entity;
using PenyewaanMotorJogjaApp.Model.Context;

namespace PenyewaanMotorJogjaApp.Model.Repository
{
    public class MotorRepository
    {
        // deklarsi objek connection
        private SQLiteConnection _conn;

        // constructor
        public MotorRepository(DbContext context)
        {
            // inisialisasi objek connection
            _conn = context.Conn;
        }
        public int UpdateStatusMotor(Motor motor)
        {
            int result = 0;
            string sql = @"update Motor
                           set status = 'Kosong'
                           where no_polisi = @nopolisi";
            // membuat objek command menggunakan blok using
            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@nopolisi", motor.NoPolisi);
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
        public int UpdateStatusMotorTersedia(Motor motor)
        {
            int result = 0;
            string sql = @"update Motor
                           set status = 'Tersedia'
                           where no_polisi = @nopolisi";
            // membuat objek command menggunakan blok using
            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@nopolisi", motor.NoPolisi);
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
        public int Create(Motor motor)
        {
            int result = 0;

            // deklarasi perintah SQL
            string sql = @"INSERT INTO Motor(no_polisi,merek_motor,warna_motor,no_mesin,harga,thn_produksi,status) 
                        VALUES(@no_polisi,@merek_motor,@warna_motor,@no_mesin,@no_rangka,@thn_produksi,@status)";
            // membuat objek command menggunakan blok using
            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@no_polisi", motor.NoPolisi);
                cmd.Parameters.AddWithValue("@merek_motor", motor.MerekMotor);
                cmd.Parameters.AddWithValue("@warna_motor", motor.WarnaMotor);
                cmd.Parameters.AddWithValue("@no_mesin", motor.NoMesin);
                cmd.Parameters.AddWithValue("@no_rangka", motor.Harga);
                cmd.Parameters.AddWithValue("@thn_produksi", motor.ThnProduksi);
                cmd.Parameters.AddWithValue("@status", motor.Status);
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
        public int Update(Motor motor)
        {
            string sql = @"UPDATE Motor
                          SET 
                          merek_motor = @merek_motor,
                          warna_motor = @warna_motor,
                          no_mesin = @no_mesin,
                          harga = @no_rangka,
                          thn_produksi = @thn_produksi,
                          status = @status
                          WHERE
                          no_polisi = @no_polisi";
            // membuat objek command menggunakan blok using
            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@no_polisi", motor.NoPolisi);
                cmd.Parameters.AddWithValue("@merek_motor", motor.MerekMotor);
                cmd.Parameters.AddWithValue("@warna_motor", motor.WarnaMotor);
                cmd.Parameters.AddWithValue("@no_mesin", motor.NoMesin);
                cmd.Parameters.AddWithValue("@no_rangka", motor.Harga);
                cmd.Parameters.AddWithValue("@thn_produksi", motor.ThnProduksi);
                cmd.Parameters.AddWithValue("@status", motor.Status);
                return cmd.ExecuteNonQuery();
            }
        }
        public int Delete(Motor motor)
        {
            int result = 0;

            // deklarasi perintah SQL
            string sql = @"delete from Motor where no_polisi=@no_polisi";

            // membuat objek command menggunakan blok using
            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@no_polisi", motor.NoPolisi);

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

        public List<Motor> ReadAll()
        {
            // membuat objek collection untuk menampung objek mahasiswa
            List<Motor> list = new List<Motor>();

            try
            {
                // deklarasi perintah SQL
                string sql = @"select no_polisi, merek_motor, warna_motor, no_mesin, harga, thn_produksi, status 
                               from Motor 
                               order by merek_motor";

                // membuat objek command menggunakan blok using
                using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
                {
                    // membuat objek dtr (data reader) untuk menampung result set (hasil perintah SELECT)
                    using (SQLiteDataReader dtr = cmd.ExecuteReader())
                    {
                        // panggil method Read untuk mendapatkan baris dari result set
                        while (dtr.Read())
                        {
                            // proses konversi dari row result set ke object
                            Motor mtr = new Motor();
                            mtr.NoPolisi = dtr["no_polisi"].ToString();
                            mtr.MerekMotor = dtr["merek_motor"].ToString();
                            mtr.WarnaMotor = dtr["warna_motor"].ToString();
                            mtr.NoMesin = dtr["no_mesin"].ToString();
                            mtr.Harga = dtr["harga"].ToString();
                            mtr.ThnProduksi = dtr["thn_produksi"].ToString();
                            mtr.Status = dtr["status"].ToString();

                            // tambahkan objek mtr ke dalam collection
                            list.Add(mtr);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadAll error: {0}", ex.Message);
            }

            return list;
        }
        public List<Motor> CariPlat(string nopolisi)
        {

            var result = new List<Motor>();
            string sql = @"SELECT * FROM Motor WHERE no_polisi=@no_polisi";
            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@no_polisi", nopolisi);
                using (SQLiteDataReader dtr = cmd.ExecuteReader())
                {
                    while (dtr.Read())
                    {
                        var plat = new Motor();
                        plat.NoPolisi = dtr["no_polisi"].ToString();
                        plat.MerekMotor = dtr["merek_motor"].ToString();
                        plat.WarnaMotor = dtr["warna_motor"].ToString();
                        plat.NoMesin = dtr["no_mesin"].ToString();
                        plat.Harga = dtr["Harga"].ToString();
                        plat.ThnProduksi = dtr["thn_produksi"].ToString();
                        plat.Status = dtr["status"].ToString();
                        result.Add(plat);
                    }
                }
            }
            return result;
        }
    }
}
