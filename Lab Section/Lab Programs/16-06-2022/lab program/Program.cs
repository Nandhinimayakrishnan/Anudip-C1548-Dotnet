using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr1 = { { 1, 2, 3 }, { 4, 5, 6 } };
            int[,] arr2 = { { 2, 3, 4 }, { 5, 6, 7 } };
            int[,] arr3 = new int[2, 3];
            for(int i=0;i<2;i++)
            {
             for(int j=0;j<3;j++)
             {
              arr3[i,j]=arr1[i,j]+arr2[i,j];
             }
            }
             Console.WriteLine("Addition of two arrays");
             for (int i = 0; i < 2; i++)
             {
                 for (int j = 0; j < 3; j++)
                 {
                     Console.Write(arr3[i, j] + "\t");
                 }
                 Console.WriteLine();
             }
             
              
              
        }
    }
}
