using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zavrsnoPonavljanjeZad3
{
    class Program
    {
        static void Main(string[] args)
        {
            int broj;
            Console.Write("Upisi broj koji zelis podijeliti: ");
            broj = Convert.ToInt32(Console.ReadLine());
            if( broj % 4 == 0 && broj % 6 != 0)
            {
                Console.WriteLine("Broje je dijeljiv s 4");
            }
            if (broj % 6 == 0 && broj % 4 != 0)
            {
                Console.WriteLine("Broje je dijeljiv s 6");
            }
            if (broj % 6 == 0 && broj % 4 == 0)
            {
                Console.WriteLine("Broje je dijeljiv s 6 i 4");
            }
            if (broj % 6 != 0 && broj % 4 != 0)
            {
                Console.WriteLine("Broje nije dijeljiv s 6 i 4");
            }
            Console.ReadKey();
        }
    }
}
