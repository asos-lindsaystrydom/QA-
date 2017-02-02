using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What day is it today?");
            string dayoftheweek = Console.ReadLine();


            
                switch (dayoftheweek.ToUpper())  //makes input case insensitive
                        
                {
                    case "FRIDAY":
                        Console.WriteLine("FRIYAY"); 
                        break;
                    case "SATURDAY":
                    case "SUNDAY":
                       Console.WriteLine("IT'S THE FREAKING WEEKEND");
                        break;
                    default:
                        Console.WriteLine("LAME");
                        break;
        }

            Console.ReadKey();
        }
    }
}
