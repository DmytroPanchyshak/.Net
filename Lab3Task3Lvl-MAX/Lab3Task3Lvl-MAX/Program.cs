using System;

/**
 * Задания на максимальную оценку "отлично"
 * Найти количество элементов массива, встречающихся в нем один раз.
 */

namespace Lab3Task3Lvl_MAX
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = { 9, 8, 7, 6, 0, 0, 7, 8 };

            int count = 0, unique = 0;

            for(int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j]) count++;
                }
                if (count == 1) 
                    ++unique;
                count = 0;
            }
            Console.WriteLine("Unique elements in array: " + unique);          

        }
    }
}
