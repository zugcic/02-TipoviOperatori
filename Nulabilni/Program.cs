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
            double? nulabilniDuplić = Math.PI;
            Console.WriteLine(nulabilniDuplić);


            /*Zadatak1 - Dodati u Program.Main naredbu kojom se vrijednost nulabilnog
                         tipa double postavlja na null referencu te ispisati nakon toga
		                 sadržaj varijable.*/
            nulabilniDuplić = null;
            Console.WriteLine(nulabilniDuplić);

            //Zadatak2
            double običniDuplic = Math.PI;
            //običniDuplic = null; ->nije dozvoljeno

            /*Zadatak3 - Definirati nulabilnu varijablu korištenjem generičkog tipa
                         Nullable<T> te ponoviti postupke iz ZADATKA 1.*/
            Nullable<double> nulabilniDuplić1 = null;
            Console.WriteLine(nulabilniDuplić1);

            Console.ReadKey();
        }
    }
}
