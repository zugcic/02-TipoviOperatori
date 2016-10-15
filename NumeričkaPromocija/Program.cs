using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeričkaPromocija
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Zadatak1 - Definirati dvije varijable tipa int i provjeriti kojeg tipa je njihov kvocijent.
                         Dijeljitelj i dijeljenik odabrati tako da dijeljenje bude s ostatkom*/
            int a=91; 
            int b=4;
            Console.WriteLine(a/b);  //rezultat je tipa int
            

            /*Zadatak2 - Definirati jednu varijablu tipa int i jednu tipa double te ih zbrojiti
                         te provjeriti kakvog tipa je taj zbroj.*/
            int c = 3;
            double d = 8;
            Console.WriteLine(c + d);   //rezultat zbroja je tipa double
            Console.ReadKey();
        }
    }
}
