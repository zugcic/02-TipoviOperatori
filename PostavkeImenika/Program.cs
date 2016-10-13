
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;      //ako su namesapceovi zasivljeni znači da nisu u upotrebi

namespace Vsite.Csharp      //namespace se navodi po konvenciji tako da se navede- imefirme.imemodula.ime projekta
{
    class Program
    {
        static void Main(string[] args)
        {
            MojaKlasa1 mk1=new MojaKlasa1();
            MojaKlasa2 mk2 = new MojaKlasa2();
            Console.WriteLine("Bok");
        }
    }
}
