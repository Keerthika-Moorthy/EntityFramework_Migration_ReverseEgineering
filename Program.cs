using NinjaApp.Data;
using NinjaApp.Domain;
using System.Linq;
using System;

namespace NinjaAppConsole
{
   internal class Program
    {
        private static NinjasContext context = new NinjasContext();
       private static void Main(string[] args)
        {
            context.Database.EnsureCreated();
            GetNinjas("Before Add:");
            AddNinjas();
            GetNinjas("After Add:");

            Console.WriteLine("Press any Key...");
            Console.ReadKey();

        }
        private static void AddNinjas()
        {
            var Ninja = new Ninja { Name = "SELVA" };
            context.Ninjas.Add(Ninja);
            context.SaveChanges();


        }
        private static void GetNinjas(string text)
        {
            var Ninjas = context.Ninjas.ToList();
            Console.WriteLine($"{text}: Ninjas Count is {Ninjas.Count}");
            foreach(var ninja in Ninjas)
            {
                Console.WriteLine(ninja.Name);
            }
        }

    }
}
