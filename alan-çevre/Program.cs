using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alan_çevre
{
    class Program
    {
        static void Main(string[] args)
        {
            int sekil=0,cevre=0,alan=0,a=0,x=0,b=0,c=0;
            Console.WriteLine("1-KARE Mİ?");
            Console.WriteLine("2-DİKDÖRTGEN Mİ?");
            sekil=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("1-ÇEVRE Mİ?");
            Console.WriteLine("2-ALAN MI?");
            x = Convert.ToInt32(Console.ReadLine());
            if (sekil == 1)
            {
                Console.WriteLine("Kenar uzunluğu?");
                a= Convert.ToInt32(Console.ReadLine());

                switch (x)
                {
                    case 1: cevre= 4*a; Console.WriteLine(cevre); break;

                    case 2: alan= a*a; Console.WriteLine(alan); break;

                }
               
            }
            else
            {
                Console.WriteLine("Kenar uzunluğu?");
                b = Convert.ToInt32(Console.ReadLine());
                c = Convert.ToInt32(Console.ReadLine());
                switch (x)
                {
                    case 1: cevre = 2 * (b + c); Console.WriteLine(cevre); break;

                    case 2: alan = b * c; Console.WriteLine(alan); break;

                }

            }
            Console.ReadKey();





        }
    }
}
