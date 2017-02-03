using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA_Plus_Plus
{
    class Program
    {
        public static void Main(string[] args)
        {
            bool waitingForValidDate = true;
            int yearOfBirth = 0;
            int currentYear = DateTime.Now.Year;

            while (waitingForValidDate)
            {
                Console.WriteLine("What year were you born in?");
                string yearOfBirthValue = Console.ReadLine();


                bool isValid = int.TryParse(yearOfBirthValue, out yearOfBirth);
                if (!isValid)
                {
                     
                    Console.WriteLine("Please input a NUMBER!");
                    continue;
                }

                if (yearOfBirth <= currentYear)
                {
                    waitingForValidDate = false;
                    continue;
                }
                
                
          
            Console.WriteLine("The date you have entered is in the future - please re-enter a valid year");
          
            }
            Console.WriteLine("Your age is " + (currentYear - yearOfBirth));

            Console.ReadKey();

        }

    }
}
