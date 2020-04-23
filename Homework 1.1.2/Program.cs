using System;

namespace Homework_1._1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 6, 49, 29, 20, 1, 18, 49, 64, 88, 71, 59, 24, 11 };

            int result = 0;

            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] % 2 == 0)
                {
                    result = result + myArray[i];
                }
            }

            Console.WriteLine();
            Console.WriteLine("Сумма четных чисел: " + result);


        }
    }
}
