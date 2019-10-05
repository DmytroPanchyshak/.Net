using System;
/*
 * Дана двумерная квадратная матрица.
 * Получить массив b1 …bn , где bi - это сумма элементов,
 * расположенных за первым отрицательным элементом в i-той строке
 * (если все элементы строки неотрицательны, то принять bi=100).
 */

namespace Lab4Task3Lvl_MAX
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] m = 
            {
                { 1,-2,3,4,5},
                { 1,-2,-3,4,5},
                { -1,-2,-3,-4,-5},
                { -1,2,3,4,5},
                { 1,2,3,4,5}
            };

            int row = m.GetUpperBound(0) + 1;
            int columns = m.Length / row;

            int[] result = new int[row];

            for(int i=0; i < row; i++)
            {

                bool negativeElement = false;
                int sum = 0;

                for(int j=0; j < columns; j++)
                {

                    if (negativeElement)
                        sum += m[i, j];
                    else if (m[i, j] < 0)
                        negativeElement = true;
                
                }

                if (!negativeElement)
                    sum = 100;
                result[i] = sum;

            }


            for (int i = 0; i < result.Length; i++)
                Console.WriteLine("row:" + i + " bi: " + result[i]);


















        }
    }
}
