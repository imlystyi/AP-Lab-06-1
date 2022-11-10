/* Lab_06_1_Recursive.cs
 * Якубовський Владислав
 * Лабораторна робота № 6.1 
 * Пошук елементів одновимірного масиву ітераційним та рекурсивним способом (рекурсивний спосіб).
 * Варіант 24 */
using System;

namespace AP_Lab_06_1_Recursive
{
    public class Lab_06_1_Recursive
    {
        readonly static Random random = new Random();

        public static int CountElements(int[] array, int ii = 0, int count = 0)
        {
            if (ii < array.Length)
            {
                if (array[ii] < 0 || array[ii] % 5 != 0)
                    count++;

                return CountElements(array, ++ii, count);
            }

            else return count;
        }

        public static int SummarizeElements(int[] array, int ii = 0, int sum = 0)
        {
            if (ii < array.Length)
            {
                if (array[ii] < 0 || array[ii] % 5 != 0)
                    sum += array[ii];                

                return SummarizeElements(array, ++ii, sum);
            }                

            else return sum;
        }

        public static int[] ModifyArray(int[] array, int ii = 0)
        {
            if (ii < array.Length)
            {
                if (array[ii] < 0 || array[ii] % 5 != 0)
                    array[ii] = 0;

                return ModifyArray(array, ++ii);
            }

            return array;
        }

        static void GenerateArray(ref int[] array, int ii = 0)
        {
            if (ii < array.Length)
            {
                array[ii] = random.Next(-20, 38);

                GenerateArray(ref array, ++ii);
            }
        }

        static void DisplayArray(int[] array, int ii = 0)
        {
            if (ii < array.Length)
            {
                Console.Write(((ii == 0) ? "{ " : "") + $"{array[ii]}" + ((ii < array.Length - 1) ? ", " : "") + ((ii == array.Length - 1) ? " }\n" : ""));

                DisplayArray(array, ++ii);
            }
        }

        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.Default;

            const int SIZE = 22;

            int[] t = new int[SIZE];

            GenerateArray(ref t);

            int count = CountElements(t),
                sum = SummarizeElements(t);

            Console.Write("Згенерований масив: "); DisplayArray(t);

            Console.WriteLine($"К-сть відповідних елементів:\t{count}\n" +
                $"Сума відповідних елементів:\t{sum}");

            Console.Write("Модифікований масив: "); DisplayArray(ModifyArray(t));

            Console.ReadLine();
        }
    }
}
