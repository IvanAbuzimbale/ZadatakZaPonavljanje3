using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadatakZaPonavljanje3
{
    class Program
    {
        static void Main(string[] args)
        {
            int iznos = 0;
            Console.WriteLine("Upišite neki broj: ");
            iznos = Convert.ToInt32(Console.ReadLine());
            if (iznos % 4 == 0 && iznos % 6 == 0)
            {
                Console.WriteLine("Broj je djeljiv sa 4 i 6.");
            }
            else if (iznos % 4 == 0)
            {
                Console.WriteLine("Broj je djeljiv sa 4.");
            }
            else if (iznos % 6 == 0)
            {
                Console.WriteLine("Broj je djeljiv sa 6.");
            }
            else
            {
                Console.WriteLine("Broj nije djeljiv sa 4 niti 6.");
            }
            Console.ReadKey();
        }
    }
}
