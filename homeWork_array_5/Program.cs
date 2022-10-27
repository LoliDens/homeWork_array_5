using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork_array_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] numbers = new int[30];
            int lowerLimitRandom = 0;
            int upperLimitRandom = 5;

            int maxNumber = int.MinValue;
            int countMaxNumber = 0;
            int temporaryMaxNumber ;
            int temporaryCountMaxNumber = 1;

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(lowerLimitRandom, upperLimitRandom + 1);
            }

            for (int i = 0; i < numbers.Length; i++) 
            {
                Console.Write(numbers[i] + " ");
            }

            temporaryMaxNumber = numbers[0];

            for (int i = 1; i < numbers.Length; i++) 
            {
                if (temporaryMaxNumber == numbers[i])
                {
                    temporaryCountMaxNumber++;
                }
                else 
                {
                    temporaryMaxNumber = numbers[i];
                    temporaryCountMaxNumber = 1;
                }

                if (temporaryCountMaxNumber > countMaxNumber)
                {
                    countMaxNumber = temporaryCountMaxNumber;
                    maxNumber = temporaryMaxNumber;
                }
            }
                       
            Console.WriteLine($"\nЧисло которое повторяется больше всего раз: {maxNumber}");
            Console.WriteLine($"Кол-во повторений этого числа : {countMaxNumber}");
            Console.ReadKey();
        }
    }
}
