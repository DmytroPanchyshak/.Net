using System;
using System.Collections.Generic;
/*
* 5 МЕТОДЫ
* Задания на максимальную оценку «отлично»
* #3
* Написать метод, входным параметром которого является строка.
* Метод должен вернуть количество слов в строке,
* у которых первый и последний символ совпадают 
* (слова – группы символов, разделенные пробелами, или пробелом и началом (концом) строки).
*/
namespace Lab5Task3LvlMax
{
    class Program
    {
        static void Main(string[] args)
        {

            string example  = "  ===  mop fff   h7h  one \n  RR \0  kazak ";
            //string example1  = "  ===  mad,,,\0 bad. dad  \n  mop pop bob, haaabrr R&R";

            int i = getAmountOfWordsWithSameFirstAndLastElement(example);
            Console.WriteLine("Amount of words with same first and last symbol: " + i);

        }

        public static int getAmountOfWordsWithSameFirstAndLastElement(string line)
        {

            string[] words = line.Split(new char[] { ' ', ',', '!', '?', '.', '\0', '\n' },
                StringSplitOptions.RemoveEmptyEntries);

            /*for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine(words[i]);
            }*/

            int result = 0;

            for (int j = 0; j < words.Length; j++)
            {
                if (words[j][0] == words[j][words[j].Length - 1])
                {
                    result++;
                }
            }

            return result;
        }


    }
}
