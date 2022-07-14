using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Write a program to find the factorial of a number 

namespace ConsoleApplication19
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, number, fact;
            Console.WriteLine(" Enter The Number: ");
            number = Int32.Parse(Console.ReadLine());
            fact = number;
            for (i = number - 1; i >= 1; i--)
            {
                fact = fact * i;
            }
            Console.WriteLine("Factorial Of Given Number Is : "+fact);
            

        }
    }
}
