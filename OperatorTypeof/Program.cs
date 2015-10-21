using System;
using System.Reflection;

namespace CSharp.TipoviOperatori
{
    class Program
    {
        static void Main(string[] args)
        {
            Type t = typeof(System.DateTime);

            MethodInfo[] mis = t.GetMethods();
            foreach (MethodInfo mi in mis)
            {
                Console.WriteLine();
                Console.WriteLine("Method name: {0}", mi.Name);
                Console.WriteLine("  Return type: {0}", mi.ReturnType);
                ParameterInfo[] pis = mi.GetParameters();
                Console.WriteLine("  Parameters:");
                foreach (ParameterInfo pi in pis)
                {
                    Console.WriteLine("    {0} {1}", pi.ParameterType, pi.Name);
                }
                if (mi.IsPublic)
                    Console.WriteLine("  Public");
                else if (mi.IsPrivate)
                    Console.WriteLine("  Private");
                else
                    Console.WriteLine("  Protected");
                Console.WriteLine("  Is static: {0}", mi.IsStatic);
                Console.WriteLine("  Is virtual: {0}", mi.IsVirtual);
            }

            Console.ReadKey();
        }
    }
}
