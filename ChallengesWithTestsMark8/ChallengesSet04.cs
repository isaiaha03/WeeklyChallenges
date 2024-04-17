using System;
using System.Diagnostics.Metrics;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            var sum = 0;
            foreach (var number in numbers)
            {
                if (number % 2 == 0)
                {
                    sum += number;
                }
                else
                {
                    sum -= number;
                }
            }
            return sum;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            string[] strings = { str1, str2, str3, str4 };
            int shortest = strings.Min(s => s.Length);
            return shortest;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            int[] ints = { number1, number2, number3, number4 };
            int smallest = ints.Min();
            return smallest;
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            return sideLength1 + sideLength2 > sideLength3 && sideLength2 + sideLength3 > sideLength1 && sideLength1 + sideLength3 > sideLength2;
        }

        public bool IsStringANumber(string input)
        {
            if (double.TryParse(input, out var number)) return true;
            return false;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int counter = 0;
            int nulls = 0;
            foreach (object obj in objs)
            {
                if (obj == null) nulls++;
                counter++;
            }

            return counter / 2 < nulls;
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null) return 0;
            int evensTotal = 0;
            int evensCounter = 0;
            foreach (int number in numbers)
            {
                if (number != 0 && number % 2 == 0)
                {
                    evensTotal += number;
                    evensCounter++;
                }
            }
            if (evensCounter == 0) return 0;

            return (double)evensTotal/evensCounter;
        }

        public int Factorial(int number)
        {
            if (number == 0) return 1;
            if (number < 0) throw new ArgumentOutOfRangeException();

            return Factorial(number);
        }
    }
}
