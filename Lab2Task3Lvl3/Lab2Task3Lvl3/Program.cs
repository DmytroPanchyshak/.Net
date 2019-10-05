/**
 * Lab.2
 * #3 Задания на максимальную оценку "отлично"
 * Дано натуральное число.
 * Определить, является ли сумма его максимальной и минимальной цифр кратной числу 'а'
 */


using System;

namespace Lab2Task3Lvl3
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean a = function(256, 8);
            Boolean b = function(4096, 8);
            
        }

        public static Boolean function(int naturalNumber, int a)
        {
            int N = naturalNumber;
            int minDigit, maxDigit;
            minDigit = maxDigit = (naturalNumber % 10);

            while(naturalNumber > 0)
            {
                int curDigit = (naturalNumber % 10);

                if (curDigit > maxDigit)
                {
                    maxDigit = curDigit;
                }
                if(curDigit < minDigit)
                {
                    minDigit = curDigit;
                }
                naturalNumber /= 10;
            }

            int sum = minDigit + maxDigit;
            if(sum % a == 0)
            {
                
                Console.WriteLine("Sum of min and max numbers of " + N + " is: " + sum + " -- > MULTIPLE for " + a+";");
                return true;
            } else
                Console.WriteLine("Sum of min and max numbers of " + N + " is: " + sum + " -- > NOT MULTIPLE for " + a + ";");


            return false;
        }
    }
}
