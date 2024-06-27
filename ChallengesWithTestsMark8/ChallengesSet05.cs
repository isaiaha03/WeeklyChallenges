using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            do { startNumber++; }
            while (startNumber % n != 0);
            return startNumber;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            foreach (Business bus in businesses)
            {
                if (bus.TotalRevenue == 0)
                {
                    bus.Name = "CLOSED";
                }    
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0) return false;
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i - 1] > numbers[i])
                {
                    return false;
                }
            }
            return true;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            int sum = 0;
            if (numbers == null || numbers.Length == 0) return 0;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                        sum += numbers[i + 1];
                }
            }
            return sum;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if (words == null || words.Length == 0) return "";

            string result = "";
            bool isLastWord = true;

            foreach (var word in words)
            {
                if (word != null)
                {
                    string trimmedWord = word.Trim();
                    if(!string.IsNullOrEmpty(trimmedWord))
                    {
                        if (!isLastWord)
                        {
                            result += " ";
                        }
                        else
                        {
                            isLastWord = false;
                        }
                        result += trimmedWord;
                    }
                }
            }

            if(!string.IsNullOrEmpty (result))
            {
                result += ".";
            }
            return result;
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            if (elements == null || elements.Count == 0) return Array.Empty<double>();

            List<double> result = new List<double>();
            for (int i = 3; i < elements.Count; i += 4)
            {
                result.Add(elements[i]);
            }
            return result.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            if (nums == null || nums.Length == 0) return false;
            
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == targetNumber) return true;
                }
            }
            return false;
        }
    }
}
