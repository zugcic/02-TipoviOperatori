﻿using DrugiImenik;
namespace PrviImenik
{
    class Program
    {
        static void Main(string[] args)
        {
            MojaKlasa mk1 = new MojaKlasa();
            mk1.Metoda1();
            DrugiImenik.MojaKlasa mk2 = new DrugiImenik.MojaKlasa(); //Puni naziv - ime namesapcea(Imenika) i ime klase
            mk2.Metoda2();
        }
    }
}
