using System;
//running two methods using delegate
//declaring delegate

public delegate void MyDelegate();

namespace ConsoleApplication1
{
    class Program1
    {

        int num;
        //initilize value using constructor
        public Program1()
        {
            Console.Write("Enter a number : ");
            num = int.Parse(Console.ReadLine());

        } 
        //method to find number is divisible by 2
        public void DivisibleTwo()
        {

            if (num % 2 == 0)
            {
                Console.WriteLine(num + " is Divisible by 2");
            }
            else
            {
                Console.WriteLine(num + " is Not divisible by 2");
            }
        }
        //method to find number is divisible by 3
        public void DivisibleThree()
        {

            if (num % 3 == 0)
            {
                Console.WriteLine(num + " is Divisible by 3");
            }
            else
            {
                Console.WriteLine(num + "is Not divisible by 3");
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                Program1 pobj = new Program1();
                //instances for delegate
                MyDelegate dobj = new MyDelegate(pobj.DivisibleTwo);
                //binding delegate
                dobj += pobj.DivisibleThree;
                //invoking delegate
                dobj.Invoke();
            }
        }
    }
}