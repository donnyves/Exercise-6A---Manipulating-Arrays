using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1Exercise_6A___Manipulating_Arrays
{
    class AddCountMean
    {
        private static double avg;

        public static double ArraySum(double[] array, double length)
        {
          
            double sum = 0;
            avg = 0.0;
            length = array.Length;

            for (int i = 0; i < length; i++)
            {
                sum += array[i];
            }
            avg = sum / length;     

            return avg;
        }

        static void Main(string[] args)
        {
           double[] arrayA = { 0, 2, 4, 6, 8, 10 };
            int length = 0;
            Console.WriteLine($"The average of the array A is: {ArraySum(arrayA,length)}");

            double[] arrayB = { 1, 3, 5, 7, 9};
            length = 0;
            Console.WriteLine($"The average of the array B is: {ArraySum(arrayB, length)}");

            double[] arrayC = { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };
            length = 0;
            Console.WriteLine($"The average of the array C is: {ArraySum(arrayC, length)}");


            Console.ReadLine();
        }
    }
}
