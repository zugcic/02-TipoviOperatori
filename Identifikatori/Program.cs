using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp.TipoviOperatori
{
    class Program
    {
        static void Main(string[] args)
        {
            double @string = 2.5;   // string je ključna riječ, no s predmetkom @ se može koristiti kao identifikator
            Console.WriteLine(@string);

            int get = 5;            // get je kontekstna ključna riječ (tj. samo u određenim slučajevima) pa se također može upotrijebiti za identifikator
            Console.WriteLine(get);

            double Main = 2.345;    // Main je rezervirana riječ pa se može također upotrijebiti za identifikator
            Console.WriteLine(Main);
        }
    }
}
