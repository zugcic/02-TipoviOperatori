using System;
namespace CSharp.TipoviOperatori
{
    struct S
    {
        public int a;
        public double b;

       public S(int a,double b) {
            this.a = a;
            this.b = b; 
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            /*Zadatak1 - odati varijablu "i0" tipa var i inicijalizirati ju nekim cijelim brojem.
                         Dodati varijablu "d0" tipa var i inicijalizirati ju nekim decimalnim brojem.
		                Dodati naredbu:
		                i0 = d0;
		                te provjeriti prihvaća li prevoditelj tu naredbu.*/

            var i0=10;
            var d0=.143;
            //i0 = d0; nije dozvoljeno

            /*Zadatak2 - Dodati varijablu "i1" tipa int i inicijalizirati ju istim cijelim 
                         brojem kao varijablu i0.
		                 Dodati varijablu "d1" tipa double i inicijalizirati ju istim cijelim 
                         brojem kao varijablu d0.
		                 Prevesti kod i usporediti kod naredbi za inicijalizacije varijabli
		                 i0 i d0, odnosno i1 i d1. */

            int i1 = 10;
            double d1 = 3.14;

            /*Zadatak3 -  Deklarirati varijablu "s" tipa var i inicijalizirati ju pozivom
                          konstruktora strukture S definirane u istoj datoteci.
		                  Napisati naredbe za postavljanje vrijednosti polja a i b
		                  u toj strukturi na proizvoljne vrijednosti i provjeriti
		                  da li se kod može prevesti.*/

            var s = new S(10, 3.14);
            Console.WriteLine("a={0},b={1}", s.a, s.b);
            Console.ReadKey();

        }
    }
}
