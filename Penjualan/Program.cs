using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace responsiuas4390
{
    class Program
    {
        static List<Produk> daftarProduk = new List<Produk>();
        static Produk prod = new Produk();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();

                Console.Write("\nMasukan Pilihan: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahProduk();
                        break;

                    case 2:
                        TampilProduk();
                        break;

                    case 3: 
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();

            Console.WriteLine("Pilihan Menu Aplikasi\n");
            Console.WriteLine("1. Tambah produk");
            Console.WriteLine("2. Tampilkan produk");
            Console.WriteLine("3. Keluar\n");
        }

        static void TambahProduk()
        {
            Console.Clear();
            prod = new Produk();
            Console.WriteLine("Tambah data prdoduk");
            Console.Write("Nota     : ");
            prod.Nota = Console.ReadLine();
            Console.Write("Tanggal  : ");
            prod.tanggal = Console.ReadLine();
            Console.Write("Custumer : ");
            prod.Custumer = Console.ReadLine();
            Console.Write("Jenis    : ");
            prod.Jenis = Console.ReadLine();
            daftarProduk.Add(prod);

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }



        static void TampilProduk()
        {
            Console.Clear();

            int no = 1;
            Console.WriteLine("Data Produk\n");
            foreach (Produk objProd in daftarProduk)
            {
                Console.WriteLine("{0}.{1},{2},{3}", no, objProd.Nota, objProd.tanggal, objProd.Custumer, objProd.Jenis);
                no++;
            }

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}