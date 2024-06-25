using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if (words == null || word == null) return false;

            StringComparison comparisonType = ignoreCase ? StringComparison.OrdinalIgnoreCase : StringComparison.Ordinal;
            foreach (string w in words)
            {
                if (w != null && string.Equals(w, word, comparisonType))
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsPrimeNumber(int num)
        {
            if (num <= 1) return false;

            if (num == 2 || num == 3) return true;

            if (num % 2 == 0 || num % 3 == 0) return false;

            for (int i = 5; i * i <= num; i += 6)
            {
                if (num % i == 0 || num % (i + 2) == 0) return false;
            }
            return true;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            if (string.IsNullOrEmpty(str)) return -1;
            return str.IndexOf(str.Distinct().Reverse().FirstOrDefault(x => str.Count(y => y.Equals(x)) == 1));
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0) return 0;

            int maxCount = 1;
            int currentCount = 1;
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    currentCount++;
                }
                else
                {
                    if (currentCount > maxCount)
                    {
                        maxCount = currentCount;
                    }
                    currentCount = 1;
                }
            }

            if (currentCount > maxCount)
            {
                maxCount = currentCount;
            }
            return maxCount;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            if (elements == null || n <= 0) return new double[] { };

            var result = elements.Where((num, index) => (index + 1) % n == 0).ToArray();
            return result;
        }
    }
}
