using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObject.TokoSepeda
{
    public class Sepeda
    {
        public string Merk;
        public string Tipe;
        public double Berat;
        public Sepeda(string Mer,string Tip, double Ber) {
            Merk = Mer;
            Tipe = Tip;
            Berat = Ber;
        }
        public void TampilkanInformasi()
        {
            Console.WriteLine($"Merek: {this.Merk}, Tipe: {this.Tipe}, Berat: {this.Berat} kg");
        }
    }
}
