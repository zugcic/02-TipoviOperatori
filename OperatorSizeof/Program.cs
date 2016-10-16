using System;
using System.Runtime.InteropServices;

namespace CSharp.TipoviOperatori
{
    struct MojaStruktura
    {
        decimal a;
        double b;
    }

    struct MojaSloženaStruktura
    {
        public void IspišiSe()
        {
            Console.WriteLine(this.ToString());
        }

        decimal a;
        double b;
    }

    class MojaKlasa
    {
        public void IspišiSe()
        {
            Console.WriteLine(this.ToString());
        }

        decimal a;
        double b;
    }

    class Program
    {
        static void Main(string[] args)
        {
            

            // ispisati duljinu tipa decimal
            Console.WriteLine(sizeof(decimal));
            // ispisati duljinu tipa double
            Console.WriteLine(sizeof(double));
            // ispisati duljinu tipa MojaStruktura
            Console.WriteLine(Marshal.SizeOf(typeof(MojaStruktura)));
            // ispisati duljinu tipa MojaSloženaStruktura
            Console.WriteLine(Marshal.SizeOf(typeof(MojaSloženaStruktura)));
            // ispisati duljinu tipa MojaKlasa
         //   Console.WriteLine(Marshal.SizeOf(typeof(MojaKlasa)));
            Console.ReadKey();
        }
    }
}
