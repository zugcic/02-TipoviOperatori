using System;


namespace CSharp.TipoviOperatori
{
    class Program
    {
        static void Main(string[] args)
        {
            //Zadatak1
            int a=new int();
            Console.WriteLine(a); //Ispis-> 0
            Console.ReadKey();

            //Zadatak2
            int b = new int();//Kompajler ne dozvoljava dodjeljivanje vrijednosti u konstruktoru
            b = 1;
           
            //Zadatak3 
            //String s=new String();
            //Prevoditelj ne dozvoljava inicijalizaciju varijeble tipa string putem defaultnog konstruktora

            //Zadatak 4
            string g;
            String s1="Vsite";//Dodjeljivanje vrijednosti u varijablu s
            Console.WriteLine();
            Console.ReadKey();
            
            
            


        


        }
    }
}
