using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp.TipoviOperatori
{
    class Program
    {
        static void Main(string[] args)
        {
            // ugrađeni tipovi se mogu inicijalizirati samo operatorom
            // pridruživanja (=) ili podrazumijevanim konstruktorom!
            int i0 = new int();
            int i1 = new int(1);
            int i2 = 2;

            string s0 = new string();
            string s1 = new string("string 1");
            string s2 = new string(new char[]{'s', 't', 'r', 'i', 'n', 'g', ' ', '2'});
            string s3 = "string 3";
        }
    }
}
