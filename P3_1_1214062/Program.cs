using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_1_1214062
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ANAK AYAM TURUN 10");

            Console.WriteLine("");

            int anak_ayam = int.Parse(Console.ReadLine());
            if (anak_ayam > 10 || anak_ayam <= 0)
            {
                Console.WriteLine("Angka Ditolak!");  
            }
            else
            {
                for (int d = anak_ayam; d > 0; d--)
                {
                    if (d == 1)
                    {
                        Console.WriteLine("Anak ayam turunlah 1, mati satu tinggallah induknya");
                    }
                    else
                    {
                        Console.WriteLine("Anak ayam turunlah " + d + " mati satu tinggallah " + (d - 1));
                    }
                }
            }
        }
    }
}
