using System;

namespace Lab1Task3
{
    /**
    * Даны два натуральных числа a и n,
    * вычислить вложенные радикалы 'a'  'n' слагаемых.
    */
    class Program
	{
		static void Main(string[] args)
		{
            
            double a = calculateNestedRadicals(256,128);
            double b = calculateNestedRadicals(25, 0);
           
            Console.WriteLine("a: " + a);
            Console.WriteLine("b: " + b);

        }

        public static double calculateNestedRadicals(double i, double j)
        {          

            double answer = 0;

            double sqrtI = Math.Sqrt(i);
            double tempSqrt = 0;

            if (j == 0)
            {
                answer = 0;
            }
            else if (j == 1)
            {
                answer = Math.Sqrt(i);
            } 
            else if (j == 2)
            {
                tempSqrt = Math.Sqrt(i + sqrtI);
                answer = tempSqrt;
            }
            else if (j >= 3)
            {
                tempSqrt = Math.Sqrt(i + sqrtI);
                for (; j>2; j--)
                {
                    answer = Math.Sqrt(i + tempSqrt);
                    tempSqrt = answer;
                }
            }
            
            return answer;
        }
    }
}
