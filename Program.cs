using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCustomer
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek customer
        static List<Customer> daftarCustomer = new List<Customer>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";
            bool keluar = true;
            while (keluar)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..4]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahCustomer();
                        break;

                    case 2:
                        HapusCustomer();
                        break;

                    case 3:
                        TampilCustomer();
                        break;

                    case 4:  keluar=false;
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();
            // TODO: tuliskan logika Anda di sini ...
            Console.WriteLine("Pilih Menu Aplikasi : \n\n" +
                "1. Tambah Customer\n" +
                "2. Hapus Customer\n" +
                "3. Tampilkan Customer\n" +
                "4. Keluar");
        }

        static void TambahCustomer()
        {
            Console.Clear();

            // TODO: tuliskan logika Anda di sini ...
            Customer cst = new Customer();
            Console.WriteLine("Tambah Data Customer\n");
            Console.Write("Kode Customer : ");
            cst.Kode = Console.ReadLine();
            Console.Write("Nama Customer : ");
            cst.Nama = Console.ReadLine();
            Console.Write("Total Piutang : ");
            cst.Bon = Convert.ToInt32(Console.ReadLine());
            daftarCustomer.Add(cst);
            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusCustomer()
        {
            Console.Clear();

            // TODO: tuliskan logika Anda di sini ...
            Console.WriteLine("Hapus Data Customer : \n\n");
            Console.Write("Kode Customer : ");
            string cari = Console.ReadLine();
            int i = 0;
            foreach(Customer cst in daftarCustomer)
            {
                if(cst.Kode == cari)
                {
                    break;
                }
                i++;
            }
            daftarCustomer.RemoveAt(i);

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilCustomer()
        {
            Console.Clear();

            // TODO: tuliskan logika Anda di sini ...
            Console.WriteLine("Data Customer\n");
            int i = 1;
            foreach (Customer cst in daftarCustomer)
            {
                Console.WriteLine("{0}. {1}, {2}, {3}",i,cst.Kode,cst.Nama,cst.Bon);
                i++;
            }

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
