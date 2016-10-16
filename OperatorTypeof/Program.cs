﻿using System;
using System.Reflection;

namespace CSharp.TipoviOperatori
{
    class Program
    {
        static void Main(string[] args)
        {
            Type t = typeof(System.DateTime);


            //foreach (MemberInfo mi in t.GetMembers())
            //{
            //    Console.WriteLine($"{mi.Name} {mi.MemberType.ToString()}");
            //}

            foreach (MethodInfo mi in t.GetMethods())
            {

                
                Console.WriteLine($"{mi.ReturnType.ToString()} {mi.Name}");
             
                foreach (var parameter in mi.GetParameters())
                {
                    Console.WriteLine($"  {parameter.ParameterType.ToString()} {parameter.Name}");
                }

                if (mi.IsPrivate)
                    Console.WriteLine("Metoda je privat");

                else
                    Console.WriteLine("Metoda je public");
                
               
            }

            Console.ReadKey();
        }
    }
}
