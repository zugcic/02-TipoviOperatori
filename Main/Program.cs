using System;

namespace CSharp.TipoviOperatori
{
    class Program
    {
        static void Main(string[] args)    //unutar klase program smije biti samo jedna static main() metoda
        {
            Console.WriteLine("Krećem iz Program.Main(string[] args)");
        }

        static void Main2()
        {
            Console.WriteLine("Krećem iz Program.Main()");
        }

        public static void main()
        {
            Console.WriteLine("main()");
        }
    }
}
