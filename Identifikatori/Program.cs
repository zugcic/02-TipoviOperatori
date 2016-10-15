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
            String s="Dobar dan";   //Zadatak1 -> nije dozovoljeno koristiti ključnu riječ"string" za ime varijable
            int get=3;    //Zadatak2
            int Main=1;   //Zadatak3
            int četrdesetšest=8;//Zadatak 4
            int \u0161etrdesetšest=8;//Zadatak 5 -> Kompajler prihvaća ime - šetrdesetšest
            int бројШест = 9;//Zadatak 6   ->Kompajler prihvaća ime 

            /*Testovi*/
            Console.WriteLine(get);
            Console.WriteLine(Main);
            Console.WriteLine(s);
            Console.WriteLine(četrdesetšest);
            Console.WriteLine(šetrdesetšest);
            Console.WriteLine(šetrdesetšest);
            Console.WriteLine(бројШест);

        }
    }
}
