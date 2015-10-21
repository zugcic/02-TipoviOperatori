using System;

namespace CSharp.TipoviOperatori
{
    class Osoba { }

    class Student : Osoba { }

    class Program
    {
        static void Main(string[] args)
        {
            Osoba janko = new Student();
            
            // ovo je istina:
            bool daLiJeStudent = janko is Student;
            Console.WriteLine("Janko je Student? {0}", daLiJeStudent);
            
            // i ovo je istina:
            bool daLiJeOsoba = janko is Osoba;
            Console.WriteLine("Janko je Osoba? {0}", daLiJeOsoba);


            Osoba a = new Osoba();
            // ovo je istina:
            bool daLiJeAOsoba = a is Osoba;
            Console.WriteLine("A je Osoba? {0}", daLiJeAOsoba);

            // ovo nije istina:
            bool daLiJeAStudent = a is Student;
            Console.WriteLine("A je Student? {0}", daLiJeAStudent);

            Console.ReadKey();
        }
    }
}
