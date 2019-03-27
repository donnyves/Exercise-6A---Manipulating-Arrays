using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversingArrays
{
    class Reverse
    {
        public static void ReverseArr(int[] array)
        {         
            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(array[i]);
            }        
        }       
        static void Main(string[] args)
        {
            int[] arrayA = { 0, 2, 4, 6, 8, 10 };        
            Console.WriteLine("Array A in reverse is:  ");
            ReverseArr(arrayA);
            Console.WriteLine();

            int[] arrayB = { 1, 3, 5, 7, 9 };
            Console.WriteLine("Array B in reverse is:  ");
            ReverseArr(arrayB);
            Console.WriteLine();

            int[] arrayC = { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };
            Console.WriteLine("Array C in reverse is:  ");
            ReverseArr(arrayC);
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}

