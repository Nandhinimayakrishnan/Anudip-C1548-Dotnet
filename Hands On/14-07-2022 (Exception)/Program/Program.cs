using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication18
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,b,c;
            int d;
            int[] arr = { 1, 2, 3, 4, 5 };
            int e;
            try
            {
            Console.WriteLine("Enter value for a: ");
            a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter value for b: ");
            b = Int32.Parse(Console.ReadLine());
            c = a / b;
            Console.WriteLine("Result is : "+c);
            Console.WriteLine("Enter a integer value: ");
            d = Int32.Parse(Console.ReadLine());
            e = arr[6];
            Console.WriteLine(" Value of e is: "+e);
           }
           catch(DivideByZeroException obj)
          {
           Console.WriteLine( obj.Message);
          }
          catch(FormatException)
          {
           Console.WriteLine("Enter only integer values");
          }
          catch( IndexOutOfRangeException obj)
          {
           Console.WriteLine(obj.Message);
          }
          finally
          {
           Console.WriteLine(" THE PROGRAM IS END ");
          }

        }
    }
}
