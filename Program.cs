using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaProjectListToDO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("0. EulerNumber generating\n1. FibbonacciSequence\n2. PI generating");
            int choice = int.Parse(Console.ReadLine());
            int number;
            switch (choice)
            {
                case 0:
                    Console.WriteLine("Enter a number beetween 0 and 28 and the program generate E number up to that many decimal places.");
                    number = Convert.ToInt32(Console.ReadLine());
                    if (number < 28 && number >= 0)
                    {
                        Numbers.EulerNumberMenu(number);
                    }
                    else
                    {
                        Console.WriteLine("Invalid number");
                    }
                    break;
                case 1:
                    Console.WriteLine("Enter a number and have the program generate the Fibonacci sequence to that number.");
                    number = Convert.ToInt32(Console.ReadLine());
                    Numbers.FibbonacciSequence(number);
                    break;
                case 2:
                    Console.WriteLine("Enter a number beetween 0 and 26 and the program generate PI up to that many decimal places.");
                    number = Convert.ToInt32(Console.ReadLine());
                    if (number < 27 && number >= 0)
                    {
                        Console.WriteLine(Numbers.PI(number));
                    }
                    else
                    {
                        Console.WriteLine("Invalid number");
                    }
                    break;
            }
            Console.ReadLine();

            
        }
    
    }

}
