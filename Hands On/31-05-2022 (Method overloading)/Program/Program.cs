using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication21
{
    interface i1
    {
        void get();
    }
    interface i2
    {
        void print();
    }
    class person
    {
        public void show()
        {
            Console.WriteLine("Just to show message");
        }
    }
    class sample : person, i1, i2
    {
        int a;
        public void get()
        {
            a = 20;
        }
        public void print()
        {
            Console.WriteLine(a);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            sample obj = new sample();
            obj.show();
            obj.get();
            obj.print();
        }
    }
}
