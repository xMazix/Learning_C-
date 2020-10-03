using System;
using System.Dynamic;

namespace Cviko
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ahoj, jak se jmenuješ ?");
            string name = Console.ReadLine();
            Console.WriteLine("A jaký tedy jsi, " + name + " ?");
            string property = Console.ReadLine();
            Console.WriteLine(name + " je " + property);
            Console.ReadLine();
        }
    }
}
