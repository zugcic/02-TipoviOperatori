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
            double? nulabilniDuplic = 3.123;
            Console.WriteLine(nulabilniDuplic);

            nulabilniDuplic = null;
            Console.WriteLine(nulabilniDuplic);

            Nullable<int> nulabilniCijeli = null;
            Console.WriteLine(nulabilniCijeli);
            // ovo bi bacilo iznimku tipa InvalidOperationException:
            Console.WriteLine(nulabilniCijeli.Value);

            nulabilniCijeli = 5;

            if (nulabilniCijeli.HasValue)
                Console.WriteLine(nulabilniCijeli.Value);

            Console.ReadKey();
        }
    }
}
