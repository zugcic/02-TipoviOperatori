using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pretvorba
{
    class Osoba
    {
        public string DajSvojOib()
        {
            return "1234567890";
        }
    }

    class Student : Osoba
    {
        public int PoložiIspit(string predmet)
        {
            return 5;
        }
    }

    class Radnik : Osoba
    {
        public bool Napravi(string proizvod)
        {
            return false;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            // dodati sve moguće pozive metoda za student


            Osoba osobaS = student;
            // dodati sve moguće pozive metoda za osobaS


            Student sos = osobaS;
            // dodati sve moguće pozive metoda za sos


            Osoba osobaR = new Radnik();
            // dodati sve moguće pozive metoda za osobaR


            Student sor = osobaR;
            // dodati sve moguće pozive metoda za sor


        }
    }
}
