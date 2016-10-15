using System;

namespace CSharp.UgrađeniBrojčaniTipovi
{
    class Program
    {
        static void Main(string[] args)
        {
            //Zadatak1 - Ispisati najveći i najmanji broj koji se može pohraniti u tip int.
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);
            Console.ReadKey();
            
            //Zadatak2 - Deklarirati varijablu tipa int i dodijeliti joj vrijednost int.MaxValue.  Ispisati vrijednost varijable uvećane za 1
            int a=int.MaxValue;
            Console.WriteLine(++a);//ispisuje se najmanja vrijednost int.Minvalue kod prekoračenja najveće int.MaxValue

            //Zadatak3 -  Ponoviti to isto za varijablu s vrijednošću int.MinValue umanjenom za 1.
            a = int.MinValue;
            Console.WriteLine(--a);//ispisuje se najveća vrijednost int.Maxvalue kod prekoračenja najveće int.MinValue
            Console.ReadKey();

            //Zadatak4 - Ispišite granične vrijednosti za tip double
            Console.WriteLine(double.MaxValue);
            Console.WriteLine(double.MinValue);
            Console.ReadKey();

            /*Zadatak5 - Provjeriti što će se ispisati kao rezultat dijeljenja pozitivnog
                         decimalnog broja s 0 te negativnog decimalnog broja s 0. */
            Console.WriteLine(3.14 / 0);  //ispis  ∞
            Console.WriteLine(-3.14 / 0); //ispis - ∞
            Console.ReadKey();

            /*Zadatak6 -Provjeriti što će se ispisati kao rezultat kada se varijabla
                         tipa double s vrijednošću 0 podijeli s 0.*/ 
            double d = 0;
            Console.WriteLine(d / 0); //ispis NaN
            Console.ReadKey();

        }
    }
}
