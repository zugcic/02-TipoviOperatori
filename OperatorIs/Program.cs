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
            Osoba osoba = new Osoba();

            Console.WriteLine(janko is Student); //janko is Student=True
            Console.WriteLine(janko is Osoba); //janko is Osoba=True
            Console.WriteLine(osoba is Osoba); //osoba is Osoba= True
            Console.WriteLine(osoba is Student);//osoba is Student=False

            Console.ReadKey();
        }
    }
}
