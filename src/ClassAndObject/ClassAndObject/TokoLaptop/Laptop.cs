using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObject.TokoLaptop
{
    public class Laptop
    {
        public string Merk;
        public string Prosesor;
        public int Ram;
        public int Penyimpanan;
        public Laptop(string Mer, string Pro, int Ra,int Pen)
        {
            Merk = Mer;
            Prosesor = Pro;
            Ram = Ra;
            Penyimpanan = Pen;
        }
        public void TampilkanSpesifikasi()
        {
            Console.WriteLine($"Merk: {this.Merk}, Prosesor: {this.Prosesor}, RAM: {this.Ram} GB, Penyimpanan: {this.Penyimpanan} GB");
        }
    }
}
