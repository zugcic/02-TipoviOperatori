
namespace CSharp.TipoviOperatori
{
    class Osoba
    {
        public string DajOib()
        {
            return "0123456789";
        }
    }

    class Student : Osoba
    {
        public int PoložiIspit(string predmet)
        {
            return 3;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Osoba osoba = new Osoba();
            Osoba osobaStudent = new Student();

            /*Zadatak1 - Dodajte u metodu Program.Main pozive svih mogućih metoda nad
                         instancama objekata osoba i osobaStudent.*/
            string oib_osoba = osoba.DajOib();
            string oib_osobaStudent = osobaStudent.DajOib();

            /*Zadatak2 - Deklarirajte objekt tipa Student i pokušajte ga instancirati 
                         pozivom konstruktora tipa Osoba. Provjerite što prevoditelj 
		                 javlja.*/
            //Student s = new Osoba(); 	Cannot implicitly convert type 
            //                       'CSharp.TipoviOperatori.Osoba' to 'CSharp.TipoviOperatori.Student'. 
            //                        An explicit conversion exists (are you missing a cast?)	
            //                        PridruzivanjeBazniIzvedeni	
            //                      E:\Vsite\C#\Predavanja\02-TipoviOperatori\PridruzivanjeBazniIzvedeni\Program.cs	35	Active




        }
    }
}
