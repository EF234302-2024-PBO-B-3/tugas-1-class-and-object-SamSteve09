using ClassAndObject.OperasiMatematika;
using ClassAndObject.TokoLaptop;
using ClassAndObject.TokoSepeda;
using ClassAndObject.Kendaraan;
using ClassAndObject.Perpustakaan;
namespace ClassAndObject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Buku
            Buku buku = new Buku("Harry Potter","J.K. Rowling",1997);
            buku.TampilkanInfo();

            // Kendaraan
            Mobil mobil = new Mobil("Toyota", "All New Avanza", 2024);
            mobil.TampilkanSpesifikasi();

            // Laptop
            Laptop laptop = new Laptop("ASUS", "I9", 16, 1000);
            laptop.TampilkanSpesifikasi();

            // Sepeda
            Sepeda sepeda = new Sepeda("BMX", "Street", 9.5);
            sepeda.TampilkanInformasi();

            // Kalkulator
            Kalkulator kalkulator = new Kalkulator();
            kalkulator.Tambah(2, 2);
            kalkulator.Kurang(100, 31);
            kalkulator.Kali(1024, 2);
            kalkulator.Bagi(100, 3);


        }
    }
}
