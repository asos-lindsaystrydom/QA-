using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        { Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("True or False - you are the best QA ever?");
            bool bestEver = bool.Parse(Console.ReadLine());

            Console.WriteLine("Hi " + name);
            if (bestEver == true)
            {
                Console.WriteLine("Yes, you are totally the best QA ever!");
            }
            else
            {
                Console.WriteLine("Dont lie - you are totally the best QA ever!");
            }

            Console.ReadKey();
        }
    }
}

 