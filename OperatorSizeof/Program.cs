using System;

namespace CSharp.TipoviOperatori
{
    struct MojaStruktura
    {
        decimal a;
        double b;
        //MojaKlasa mk;
    }

    struct MojaSlozenaStruktura
    {
        public void IspisiSe()
        {
            Console.WriteLine(this.ToString());
        }

        decimal a;
        double b;
    }

    class MojaKlasa
    {
        public void IspisiSe()
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
            Console.WriteLine("Duljina tipa decimal je: {0} bajtova.", sizeof(decimal));
            Console.WriteLine("Duljina tipa double je: {0} bajtova.", sizeof(double));

            //unsafe
            {
                // za tipove koji nisu ugrađeni treba sizeof staviti u unsafe kontekst
                // u protivnom bi na sljedeću naredbu prevoditelj prijavio pogrešku:
                //Console.WriteLine("Duljina tipa MojaStruktura je: {0} bajtova.", sizeof(MojaStruktura));
            }

            DuljinaMojihStruktura();

            Console.ReadKey();
        }

        unsafe static void DuljinaMojihStruktura()
        {
            Console.WriteLine("Duljina tipa MojaStruktura je: {0} bajtova.", sizeof(MojaStruktura));
            Console.WriteLine("Duljina tipa MojaSlozenaStruktura je: {0} bajtova.", sizeof(MojaSlozenaStruktura));

            // za referentne tipove nije moguće pozivati sizeof!
            //Console.WriteLine("Duljina tipa MojaKlasa je: {0} bajtova.", sizeof(MojaKlasa));
        }
    }
}
