using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PridruzivanjeBazniIzvedeni
{
    class Bazna
    {
        public void BaznaM() { }
    }

    class Izvedena : Bazna
    {
        public void IzvedenaM() { }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Bazna b = new Izvedena();
            b.BaznaM();

            //Izvedena i = new Bazna();
            //i.IzvedenaM();
        }
    }
}
