using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSPanjangLebar
{
    class CSPP
    {
        static void Main(string[] args)
        {
            int panjang;
            int lebar;

            Console.Write("Masukan panjang  : ");
            panjang = int.Parse(Console.ReadLine());
            Console.Write("Masukan lebar    : ");
            lebar = int.Parse(Console.ReadLine());

            Console.WriteLine("----------------------");
            Console.WriteLine("Luas persegi panjang     : " + panjang * lebar);
            Console.WriteLine("Keliling persegi panjang : " + 2 * (panjang + lebar));
            Console.WriteLine("----------------------");

            Console.ReadLine();
        }
    }
}
