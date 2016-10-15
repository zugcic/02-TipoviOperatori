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
            string student_oib = student.DajSvojOib();
            int student_položi_ispit = student.PoložiIspit("C#");

            Osoba osobaS = student;
            // dodati sve moguće pozive metoda za osobaS
            string osobaS_oib = osobaS.DajSvojOib(); 

            Student sos = (Student)osobaS;
            // dodati sve moguće pozive metoda za sos
            string sos_oib=sos.DajSvojOib();
            int sos_položi_ispit=sos.PoložiIspit("C#");

            Osoba osobaR = new Radnik();
            // dodati sve moguće pozive metoda za osobaR
            string osobaR_oib = osobaR.DajSvojOib();

            Student sor =(Student) osobaR;
            // dodati sve moguće pozive metoda za sor
            string sor_oib = sor.DajSvojOib();
            int sor_položi_ispit = sor.PoložiIspit("C#");

        }
    }
}
