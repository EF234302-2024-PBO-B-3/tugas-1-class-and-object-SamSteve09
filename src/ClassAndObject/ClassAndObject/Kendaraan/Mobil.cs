using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObject.Kendaraan
{

    public class Mobil
    {
        public string Merk;
        public string Model;
        public int TahunProduksi;
        public Mobil(string Mer, string Mod, int Tah)
        {
            Merk = Mer;
            Model = Mod;
            TahunProduksi = Tah;
        }
        public void TampilkanSpesifikasi()
        {
            Console.WriteLine($"Merk: {this.Merk}, Model: {this.Model}, Tahun Produksi: {this.TahunProduksi}");
        }
    }

}
