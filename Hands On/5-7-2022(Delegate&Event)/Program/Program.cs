using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    //Write a program Delegate&Event(Without Arguments).
    class Sample
    {
        int no;
        public delegate void mydelegate();
        public event mydelegate Myevent;
        public void Input()
        {
            for(int i=1;i<=5;i++)
            {
                Console.WriteLine("Enter integer:");
                no = Int32.Parse(Console.ReadLine());
                if (no < 0)
                    Myevent();
                else
                    Console.WriteLine("Perfect");
               
            }
            // void checknumber()
           // {
           //    Console.WriteLine("You have entered negative value:");
           // }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Sample obj = new Sample();
           // obj.Myevent += new Sample.mydelegate(obj.checknumber);
            obj.Input();
        }
    }
}
