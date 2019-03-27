using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingArrays
{
    class Sort
    {
        public static void ArraySort(int[] input)
        {
            
            for (int i = 0; i < input.Length ; i++)
            {
                for (int j = 0; j < input.Length - 1; j++)
                {
                    if (input[j] > input [j + 1])
                    {
                        int temp = input[j];
                        input[j] = input[j + 1];
                        input[j + 1] = temp;
                    }
                }
                
            }
            foreach (int i in input)
            {
                Console.WriteLine(i);
            }
        }
        static void Main(string[] args)
        {
            int[] arrayC = { 9,9,9,9,9,8,8,8,8,8,3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };

            Console.WriteLine(" 9,9,9,9,9,8,8,8,8,8,3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 sorted in order is: ");
            Console.WriteLine( );
            ArraySort(arrayC);
            Console.ReadLine();

        }
    }
}
