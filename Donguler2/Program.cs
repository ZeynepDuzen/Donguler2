using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donguler2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //mod kullanimi
            //int sayi = 24 % 9;
            //Console.WriteLine(sayi);

            //mod kullanimi ornek;
            //int sayi;
            //Console.WriteLine("Lütfen bir sayi girin : ");
            //sayi = Convert.ToInt32(Console.ReadLine());

            //if (sayi % 2 == 0)
            //{
            //    Console.WriteLine("Cift sayi girdiniz");
            //}
            //else
            //{
            //    Console.WriteLine("Tek sayi girdiniz");
            //}


            //Dongulerin icerisinde karar yapilari kullanma;
            //1-20 arası 3'e tam bolunen sayilarin listesini veren kod blogu;

            int i;

            for (i = 1; i <= 20; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }


            Console.Read();
        }
    }
}
