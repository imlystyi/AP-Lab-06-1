/* Lab_06_1_Iterative.cs
 * Якубовський Владислав
 * Лабораторна робота № 6.1 
 * Пошук елементів одновимірного масиву ітераційним та рекурсивним способом (ітераційний спосіб).
 * Варіант 24 */
using System;

namespace AP_Lab_06_1_Iterative
{
    public class Lab_06_1_Iterative
    {
        readonly static Random random = new Random();

        public static int CountElements(int[] array)
        {
            int count = 0;

            for (int ii = 0; ii < array.Length; ii++)
                if (array[ii] < 0 || array[ii] % 5 != 0) count++;

            return count;
        }

        public static int SummarizeElements(int[] array)
        {
            int sum = 0;

            for (int ii = 0; ii < array.Length; ii++)
                if (array[ii] < 0 || array[ii] % 5 != 0) sum += array[ii];

            return sum;
        }

        public static int[] ModifyArray(int[] array)
        {
            for (int ii = 0; ii < array.Length; ii++)
                if (array[ii] < 0 || array[ii] % 5 != 0) array[ii] = 0;

            return array;
        }

        static int[] GenerateArray(int size)
        {
            int[] generatedArray = new int[size];

            for (int ii = 0; ii < size; ii++)
                generatedArray[ii] = random.Next(-20, 38);

            return generatedArray;
        }

        static void DisplayArray(int[] array)
        {
            for (int ii = 0; ii < array.Length; ii++)
                Console.Write(((ii == 0) ? "{ " : "") + $"{array[ii]}" + ((ii < array.Length - 1) ? ", " : "") + ((ii == array.Length - 1) ? " }\n" : ""));
        }

        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.Default;

            const int SIZE = 22;

            int[] t = GenerateArray(SIZE);

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
