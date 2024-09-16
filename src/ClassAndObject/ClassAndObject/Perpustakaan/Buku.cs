using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObject.Perpustakaan
{
    public class Buku
    {
        public string Judul;
        public string Penulis;
        public int TahunTerbit;
        public Buku(string Jud, string Pen, int Tah)
        {
            Judul = Jud;
            Penulis = Pen;
            TahunTerbit = Tah;

        }
        public void TampilkanInfo()
        {
            Console.WriteLine($"Judul: {this.Judul}, Penulis: {this.Penulis}, Tahun Terbit: {this.TahunTerbit}");
        }
    }
}
