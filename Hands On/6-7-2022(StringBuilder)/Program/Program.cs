using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder S = new StringBuilder("Siva");
            Console.WriteLine(S);
            S.Append("Karthikeyan");
            Console.WriteLine("After adding text at the end" +S);
            Console.WriteLine("No of characters in a string" +S.Length);
            //string.S= S.ToString();
            //Console.WriteLine("From string builder" +S1);

        }
    }
}
