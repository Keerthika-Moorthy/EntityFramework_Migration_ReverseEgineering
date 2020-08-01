using NinjaApp1.Data;
using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            AllotmentdbContext allot = new AllotmentdbContext();

            var v = allot.CollegeCodes.Where(a => a.Distirct.ToLower() == "chennai");
            foreach( var c in v)
            {
                Console.WriteLine(c.NameOfTheCollege);
            }
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
