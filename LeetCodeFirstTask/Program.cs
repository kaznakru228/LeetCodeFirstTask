using System;

namespace FirstTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int k = 1;
            int[] array = new int[7];
            Console.Write("Введите числа: ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < array.Length; i++)
            {
                int minIndex = i;
                for (int j = i; j < array.Length; j++)
                {
                    if (array[minIndex] > array[j])
                    {
                        minIndex = j;
                    }
                }
                int f = array[i];
                array[i] = array[minIndex];
                array[minIndex] = f;
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] != array[i - 1])
                {
                    array[k] = array[i];
                    k++;
                }
            }
            Console.WriteLine($"\n{k}");
        }
    }
}