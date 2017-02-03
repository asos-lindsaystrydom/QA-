using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int num = 1000;
            int divisor1 = 3;
            int divisor2 = 5;
            int total = 0;

            for (int i = 0; i < num; i++)
            {
                if (i % divisor1 == 0 || i % divisor2 == 0)
                {
                    total = total + i;
                }
               
            }
             Console.WriteLine(total);
            Console.ReadLine();
        }
    }
}
