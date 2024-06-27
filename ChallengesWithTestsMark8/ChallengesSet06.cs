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

            foreach (var w in words)
            {
                if (ignoreCase)
                {
                    if (w != null && w.ToLower() == word.ToLower())
                    {
                        return true;
                    }
                }
                else
                {
                    if (w == word)
                    {
                        return true;
                    }
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
            int[] charCount = new int[256]; 
            int[] charIndex = new int[256];

            for (int i = 0; i < charIndex.Length; i++)
            {
                charIndex[i] = -1;
            }

            for (int i = 0; i < str.Length; i++)
            {
                char c = str[i];
                charCount[c]++;
                charIndex[c] = i;
            }

            int lastIndex = -1;
            for (int i = 0; i < charIndex.Length; i++)
            {
                if (charCount[i] == 1)
                {
                    if (charIndex[i] > lastIndex)
                    {
                        lastIndex = charIndex[i];
                    }
                }
            }
            return lastIndex;
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

            List<double> result = new List<double>();

            for (int i = n - 1; i < elements.Count; i += n)
            {
                result.Add(elements[i]);
            }

            return result.ToArray();
        }
    }
}
