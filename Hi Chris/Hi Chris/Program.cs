using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hi_Chris
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("True or False - you are the best ever?");
            bool bestEver = bool.Parse(Console.ReadLine());

            Console.WriteLine("Hi " + name);
            if (bestEver == true)
            {
                Console.WriteLine("Yes, you are totally the best!");
            }
            else
            {
                Console.WriteLine("Dont lie - you are totally the best!");
            }

        }
    }
}
