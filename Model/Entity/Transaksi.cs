using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PenyewaanMotorJogjaApp.Model.Entity
{
    public class Transaksi
    {
        public string Idtransaksi { get; set; }
        public string NoPolisi { get; set; }
        public string IdPetugas { get; set; }
        public string IdHarga { get; set; }
        public string TglPinjam { get; set; }
        public string TglKembali { get; set; }
        public string TglTerima { get; set; }
        public string WaktuPinjam { get; set; }
        public string WaktuKembali { get; set; }
        public string WaktuTerima { get; set; }
        public string LamaPinjam { get; set; }
        public string StatusTransaksi { get; set; }
        public Customer Customer { get; set; }
        public Harga Harga { get; set; }

    }
}
