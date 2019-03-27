using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateArrays
{
    class Rotate
    {
        public static void Rotation( int spaces, int[] array, string shift)
        {
            if (shift == "right")
            {
                for (int i = array.Length - spaces; i < array.Length; i++)
                {
                    Console.WriteLine(array[i] + " ");
                }
                for (int i = 0; i < array.Length - spaces; i++)
                {
                    Console.WriteLine(array[i] + " ");
                }
            }
            if (shift == "left")
            {
                for (int i = spaces ; i < array.Length; i++)
                {
                    Console.WriteLine(array[i] + " ");
                }
                for (int i = 0; i < spaces ; i++)
                {
                    Console.WriteLine(array[i] + " ");
                }
            }
        }
        static void Main(string[] args)
        {
            int[] arrayA = { 0, 2, 4, 6, 8, 10 };
            int[] arrayB = { 1, 3, 5, 7, 9 };
            int[] arrayC = { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };


            Console.WriteLine("When you rotate arrayA two to the left, you get a result of: ");
            Rotation(2,arrayA,"left");
            Console.WriteLine();

            Console.WriteLine("When you rotate arrayB two to the right, you get a result of: ");
            Rotation(2, arrayB, "right");
            Console.WriteLine();

            //Console.WriteLine("When you rotate arrayA four to the left, you get a result of: ");
            //Rotation(4, arrayC, "left");
            //Console.WriteLine();

            Console.ReadLine();
        }
    }
}
