using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PenyewaanMotorJogjaApp.Model.Entity;
using PenyewaanMotorJogjaApp.Model.Context;
using static System.Data.Entity.Infrastructure.Design.Executor;

namespace PenyewaanMotorJogjaApp.Model.Repository
{
    public class TransaksiRepository
    {
        // deklarsi objek connection
        private SQLiteConnection _conn;

        // constructor
        public TransaksiRepository(DbContext context)
        {
            // inisialisasi objek connection
            _conn = context.Conn;
        }
        public int Create(Transaksi trk)
        {
            int result = 0;

            // deklarasi perintah SQL
            string sql = @"insert into Transaksi(id_transaksi,no_polisi, id_customer,id_petugas, id_harga, tgl_pinjam,tgl_kembali,lama_pinjam,status_transaksi)
                           values (@id_transaksi,@no_polisi, @id_customer,@id_petugas,@id_harga, @tgl_pinjam,@tgl_kembali,@lama_pinjam,@status)";

            // membuat objek command menggunakan blok using
            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@id_transaksi", trk.Idtransaksi);
                cmd.Parameters.AddWithValue("@no_polisi", trk.NoPolisi);
                cmd.Parameters.AddWithValue("@id_customer", trk.Customer.IdCustomer);
                cmd.Parameters.AddWithValue("@id_petugas", trk.IdPetugas);
                cmd.Parameters.AddWithValue("@id_harga", trk.IdHarga);
                cmd.Parameters.AddWithValue("@tgl_pinjam", trk.TglPinjam);
                cmd.Parameters.AddWithValue("@tgl_kembali", trk.TglKembali);
                cmd.Parameters.AddWithValue("@lama_pinjam", trk.LamaPinjam);
                cmd.Parameters.AddWithValue("@status", trk.StatusTransaksi);



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
        public int Update(string idtransaksi, Transaksi trk)
        {
            int result = 0;

            // deklarasi perintah SQL
            string sql = @"update Transaksi set no_polisi = @no_polisi, id_customer = @id_customer, id_harga = @id_harga, tgl_pinjam = @tgl_pinjam, tgl_kembali = @tgl_kembali, lama_pinjam = @lama_pinjam, status_transaksi = @status where id_transaksi = @id_transaksi";
            // membuat objek command menggunakan blok using
            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                
                cmd.Parameters.AddWithValue("@no_polisi", trk.NoPolisi);
                cmd.Parameters.AddWithValue("@id_customer", trk.Customer.IdCustomer);
                cmd.Parameters.AddWithValue("@id_harga", trk.IdHarga);
                cmd.Parameters.AddWithValue("@tgl_pinjam", trk.TglPinjam);
                cmd.Parameters.AddWithValue("@tgl_kembali", trk.TglKembali);
                cmd.Parameters.AddWithValue("@lama_pinjam", trk.LamaPinjam);
                cmd.Parameters.AddWithValue("@status", trk.StatusTransaksi);
                cmd.Parameters.AddWithValue("@id_transaksi", trk.Idtransaksi);
                cmd.Parameters.AddWithValue("@id_transaksi", idtransaksi);

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
        public int Delete(Transaksi trk)
        {
            int result = 0;

            // deklarasi perintah SQL
            string sql = @"delete from Transaksi
                           where id_transaksi = @id_transaksi";

            // membuat objek command menggunakan blok using
            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@id_transaksi", trk.Idtransaksi);

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
        public List<Transaksi> ReadAll()
        {
            // membuat objek collection untuk menampung objek mahasiswa
            List<Transaksi> list = new List<Transaksi>();

            try
            {
                // deklarasi perintah SQL
                string sql = @"select T.id_transaksi, T.id_harga, T.tgl_pinjam, T.tgl_kembali, T.lama_pinjam, T.id_petugas, T.status_transaksi,
                                C.id_customer, C.nama_customer, C.gender_customer, C.no_identitas, C.alamat_customer,  C.no_handphone,
                                H.id_harga,H.harga_pinjam, H.nomor_polisi
                                from Transaksi T
                                inner join Customer C ON T.id_customer = C.id_customer
                                join Harga H on H.id_customer=C.id_customer";

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
                            Transaksi trk = new Transaksi();
                            trk.Idtransaksi = dtr["id_transaksi"].ToString();
                            trk.TglPinjam = dtr["tgl_pinjam"].ToString();
                            trk.TglKembali = dtr["tgl_kembali"].ToString();
                            trk.LamaPinjam = dtr["lama_pinjam"].ToString();
                            trk.IdPetugas = dtr["id_petugas"].ToString();
                            trk.StatusTransaksi = dtr["status_transaksi"].ToString();
                            trk.Customer = new Customer()
                            {
                                IdCustomer = dtr["id_customer"].ToString(),
                                NamaCustomer = dtr["nama_customer"].ToString(),
                                GenderCustomer = dtr["gender_customer"].ToString(),
                                NoIdentitas = dtr["no_identitas"].ToString(),
                                AlamatCustomer = dtr["alamat_customer"].ToString(),
                                NoHandphone = dtr["no_handphone"].ToString(),
                            };
                            trk.Harga = new Harga()
                            {

                                IdHarga = dtr["id_harga"].ToString(),
                                HargaPinjam= dtr["harga_pinjam"].ToString(),
                                NomorPolisi = dtr["nomor_polisi"].ToString(),
                                IdCustomer = dtr["id_customer"].ToString(),
                            };

                            // tambahkan objek mahasiswa ke dalam collection
                            list.Add(trk);
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
        public List<Transaksi> ReadByNoPol(string NoPol)
        {
            // membuat objek collection untuk menampung objek mahasiswa
            List<Transaksi> list = new List<Transaksi>();

            try
            {
                // deklarasi perintah SQL
                string sql = @"select T.id_transaksi, T.id_harga, T.tgl_pinjam, T.tgl_kembali, T.lama_pinjam, T.id_petugas, T.status_transaksi,
                                C.id_customer, C.nama_customer, C.gender_customer, C.no_identitas, C.alamat_customer,  C.no_handphone,
                                H.id_harga,H.harga_pinjam, H.nomor_polisi
                                from Transaksi T
                                inner join Customer C ON T.id_customer = C.id_customer
                                join Harga H on H.id_customer=C.id_customer where H.nomor_polisi like @NoPol";

                // membuat objek command menggunakan blok using
                using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
                {
                    // mendaftarkan parameter dan mengeset nilainya
                    cmd.Parameters.AddWithValue("@NoPol", string.Format("%{0}%", NoPol));

                    // membuat objek dtr (data reader) untuk menampung result set (hasil perintah SELECT)
                    using (SQLiteDataReader dtr = cmd.ExecuteReader())
                    {
                        // panggil method Read untuk mendapatkan baris dari result set
                        while (dtr.Read())
                        {
                            // proses konversi dari row result set ke object
                            Transaksi trk = new Transaksi();
                            trk.Idtransaksi = dtr["id_transaksi"].ToString();
                            trk.TglPinjam = dtr["tgl_pinjam"].ToString();
                            trk.TglKembali = dtr["tgl_kembali"].ToString();
                            trk.LamaPinjam = dtr["lama_pinjam"].ToString();
                            trk.IdPetugas = dtr["id_petugas"].ToString();
                            trk.StatusTransaksi = dtr["status_transaksi"].ToString();
                            trk.Customer = new Customer()
                            {
                                IdCustomer = dtr["id_customer"].ToString(),
                                NamaCustomer = dtr["nama_customer"].ToString(),
                                GenderCustomer = dtr["gender_customer"].ToString(),
                                NoIdentitas = dtr["no_identitas"].ToString(),
                                AlamatCustomer = dtr["alamat_customer"].ToString(),
                                NoHandphone = dtr["no_handphone"].ToString(),
                            };
                            trk.Harga = new Harga()
                            {

                                IdHarga = dtr["id_harga"].ToString(),
                                HargaPinjam = dtr["harga_pinjam"].ToString(),
                                NomorPolisi = dtr["nomor_polisi"].ToString(),
                                IdCustomer = dtr["id_customer"].ToString(),
                            };

                            // tambahkan objek mahasiswa ke dalam collection
                            list.Add(trk);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadByNama error: {0}", ex.Message);
            }

            return list;
        }
        public List<Transaksi> CariPlat(string nopolisi)
        {

            List<Transaksi> result = new List<Transaksi>();
            string sql = @"SELECT T.id_transaksi, T.id_harga, T.tgl_pinjam, T.tgl_kembali, T.lama_pinjam, T.id_petugas, T.status_transaksi,
                         C.id_customer, C.nama_customer, C.gender_customer, C.no_identitas, C.alamat_customer, C.no_handphone, H.harga_pinjam, H.nomor_polisi
                         FROM Transaksi T
                         INNER JOIN Customer C ON T.id_customer = C.id_customer
                         INNER JOIN Harga H ON H.id_customer = C.id_customer
                         WHERE H.nomor_polisi = @no_polisi";
            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@no_polisi", nopolisi);
                using (SQLiteDataReader dtr = cmd.ExecuteReader())
                {
                    while (dtr.Read())
                    {
                        Transaksi trk = new Transaksi();
                        trk.Idtransaksi = dtr["id_transaksi"].ToString();
                        trk.TglPinjam = dtr["tgl_pinjam"].ToString();
                        trk.TglKembali = dtr["tgl_kembali"].ToString();
                        trk.LamaPinjam = dtr["lama_pinjam"].ToString();
                        trk.IdPetugas = dtr["id_petugas"].ToString();
                        trk.StatusTransaksi = dtr["status_transaksi"].ToString();
                        trk.Customer = new Customer()
                        {
                            IdCustomer = dtr["id_customer"].ToString(),
                            NamaCustomer = dtr["nama_customer"].ToString(),
                            GenderCustomer = dtr["gender_customer"].ToString(),
                            NoIdentitas = dtr["no_identitas"].ToString(),
                            AlamatCustomer = dtr["alamat_customer"].ToString(),
                            NoHandphone = dtr["no_handphone"].ToString(),
                        };
                        trk.Harga = new Harga()
                        {

                            IdHarga = dtr["id_harga"].ToString(),
                            HargaPinjam = dtr["harga_pinjam"].ToString(),
                            NomorPolisi = dtr["nomor_polisi"].ToString(),
                            IdCustomer = dtr["id_customer"].ToString(),
                        };
                        result.Add(trk);
                    }
                }
            }
            return result;
        }
        public List<Transaksi> CariNama(string cus)
        {

            List<Transaksi> result = new List<Transaksi>();
            string sql = @"SELECT T.id_transaksi, T.id_harga, T.tgl_pinjam, T.tgl_kembali, T.lama_pinjam, T.id_petugas, T.status_transaksi,
                         C.id_customer, C.nama_customer, C.gender_customer, C.no_identitas, C.alamat_customer, C.no_handphone, H.harga_pinjam, H.nomor_polisi
                         FROM Transaksi T
                         INNER JOIN Customer C ON T.id_customer = C.id_customer
                         INNER JOIN Harga H ON H.id_customer = C.id_customer
                         WHERE C.nama_customer = @nama_customer";
            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@nama_customer", cus);
                using (SQLiteDataReader dtr = cmd.ExecuteReader())
                {
                    while (dtr.Read())
                    {
                        Transaksi trk = new Transaksi();
                        trk.Idtransaksi = dtr["id_transaksi"].ToString();
                        trk.TglPinjam = dtr["tgl_pinjam"].ToString();
                        trk.TglKembali = dtr["tgl_kembali"].ToString();
                        trk.LamaPinjam = dtr["lama_pinjam"].ToString();
                        trk.IdPetugas = dtr["id_petugas"].ToString();
                        trk.StatusTransaksi = dtr["status_transaksi"].ToString();
                        trk.Customer = new Customer()
                        {
                            IdCustomer = dtr["id_customer"].ToString(),
                            NamaCustomer = dtr["nama_customer"].ToString(),
                            GenderCustomer = dtr["gender_customer"].ToString(),
                            NoIdentitas = dtr["no_identitas"].ToString(),
                            AlamatCustomer = dtr["alamat_customer"].ToString(),
                            NoHandphone = dtr["no_handphone"].ToString(),
                        };
                        trk.Harga = new Harga()
                        {

                            IdHarga = dtr["id_harga"].ToString(),
                            HargaPinjam = dtr["harga_pinjam"].ToString(),
                            NomorPolisi = dtr["nomor_polisi"].ToString(),
                            IdCustomer = dtr["id_customer"].ToString(),
                        };
                        result.Add(trk);
                    }
                }
            }
            return result;
        }
        public List<Transaksi> CariStatus(string cus)
        {

            List<Transaksi> result = new List<Transaksi>();
            string sql = @"SELECT T.id_transaksi, T.id_harga, T.tgl_pinjam, T.tgl_kembali, T.lama_pinjam, T.id_petugas, T.status_transaksi,
                         C.id_customer, C.nama_customer, C.gender_customer, C.no_identitas, C.alamat_customer, C.no_handphone, H.harga_pinjam, H.nomor_polisi
                         FROM Transaksi T
                         INNER JOIN Customer C ON T.id_customer = C.id_customer
                         INNER JOIN Harga H ON H.id_customer = C.id_customer
                         WHERE T.status_transaksi = @status_transaksi";
            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@status_transaksi", cus);
                using (SQLiteDataReader dtr = cmd.ExecuteReader())
                {
                    while (dtr.Read())
                    {
                        Transaksi trk = new Transaksi();
                        trk.Idtransaksi = dtr["id_transaksi"].ToString();
                        trk.TglPinjam = dtr["tgl_pinjam"].ToString();
                        trk.TglKembali = dtr["tgl_kembali"].ToString();
                        trk.LamaPinjam = dtr["lama_pinjam"].ToString();
                        trk.IdPetugas = dtr["id_petugas"].ToString();
                        trk.StatusTransaksi = dtr["status_transaksi"].ToString();
                        trk.Customer = new Customer()
                        {
                            IdCustomer = dtr["id_customer"].ToString(),
                            NamaCustomer = dtr["nama_customer"].ToString(),
                            GenderCustomer = dtr["gender_customer"].ToString(),
                            NoIdentitas = dtr["no_identitas"].ToString(),
                            AlamatCustomer = dtr["alamat_customer"].ToString(),
                            NoHandphone = dtr["no_handphone"].ToString(),
                        };
                        trk.Harga = new Harga()
                        {

                            IdHarga = dtr["id_harga"].ToString(),
                            HargaPinjam = dtr["harga_pinjam"].ToString(),
                            NomorPolisi = dtr["nomor_polisi"].ToString(),
                            IdCustomer = dtr["id_customer"].ToString(),
                        };
                        result.Add(trk);
                    }
                }
            }
            return result;
        }
        public List<Transaksi> ReadAllLaporan()
        {
            // membuat objek collection untuk menampung objek mahasiswa
            List<Transaksi> list = new List<Transaksi>();

            try
            {
                // deklarasi perintah SQL
                string sql = @"SELECT T.id_transaksi, T.id_harga, T.tgl_pinjam, T.tgl_kembali, T.lama_pinjam, T.id_petugas, T.status_transaksi,
                                       C.id_customer, C.nama_customer, C.gender_customer, C.no_identitas, C.alamat_customer,  C.no_handphone,
                                       H.id_harga,H.harga_pinjam, H.nomor_polisi
                                FROM Transaksi T 
                                INNER JOIN Customer C ON T.id_customer = C.id_customer
                                JOIN Harga H on H.id_customer=C.id_customer 
                                ORDER by T.tgl_pinjam";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
                {
                    // membuat objek dtr (data reader) untuk menampung result set (hasil perintah SELECT)
                    using (SQLiteDataReader dtr = cmd.ExecuteReader())
                    {
                        // panggil method Read untuk mendapatkan baris dari result set
                        while (dtr.Read())
                        {
                            // proses konversi dari row result set ke object
                            Transaksi trk = new Transaksi();
                            trk.Idtransaksi = dtr["id_transaksi"].ToString();
                            trk.TglPinjam = dtr["tgl_pinjam"].ToString();
                            trk.TglKembali = dtr["tgl_kembali"].ToString();
                            trk.LamaPinjam = dtr["lama_pinjam"].ToString();
                            trk.IdPetugas = dtr["id_petugas"].ToString();
                            trk.StatusTransaksi = dtr["status_transaksi"].ToString();
                            trk.Customer = new Customer()
                            {
                                IdCustomer = dtr["id_customer"].ToString(),
                                NamaCustomer = dtr["nama_customer"].ToString(),
                                GenderCustomer = dtr["gender_customer"].ToString(),
                                NoIdentitas = dtr["no_identitas"].ToString(),
                                AlamatCustomer = dtr["alamat_customer"].ToString(),
                                NoHandphone = dtr["no_handphone"].ToString(),
                            };
                            trk.Harga = new Harga()
                            {

                                IdHarga = dtr["id_harga"].ToString(),
                                HargaPinjam = dtr["harga_pinjam"].ToString(),
                                NomorPolisi = dtr["nomor_polisi"].ToString(),
                                IdCustomer = dtr["id_customer"].ToString(),
                            };
                            list.Add(trk);
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
    }
}
