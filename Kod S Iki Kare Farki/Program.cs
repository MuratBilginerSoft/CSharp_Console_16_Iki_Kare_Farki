using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kod_S_Iki_Kare_Farki
{
    class Program
    {
        static int usal1(int x)
        {
            int carpim = 1;
            for (int i = 0; i < 2; i++)
            {
                carpim *= x;
            }

            return carpim;
        }

        static int usal2(int y)
        {
            int carpim = 1;
            for (int i = 0; i < 2; i++)
            {
                carpim *= y;
            }

            return carpim;
        }

        static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("birinci sayıyı giriniz=");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("2. sayıyı giriniz=");
            y = int.Parse(Console.ReadLine());
            Console.WriteLine(usal1(x) - usal2(y));
            Console.ReadKey();

        }


    }
}
