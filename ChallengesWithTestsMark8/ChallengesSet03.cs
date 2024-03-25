using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            foreach (bool val in vals)
            {
                if (!val)
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }

            int sumOfOdds = numbers.Where(num => num % 2 != 0).Sum();
            return sumOfOdds % 2 != 0;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            if (password == null)
            {
                throw new ArgumentNullException(nameof(password));
            }

            return password.Any(char.IsUpper) && password.Any(char.IsLower) && password.Any(char.IsDigit);
        }

        public char GetFirstLetterOfString(string val)
        {
            if (string.IsNullOrEmpty(val))
            {
                throw new ArgumentException("Inputted string cannot be null or empty", nameof(val));
            }

            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            if (string.IsNullOrEmpty(val))
            {
                throw new ArgumentException("Inputted string cannot be null or empty", nameof(val));
            }

            return val[^1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
            {
                return 0;
            }

            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            if (nums == null || nums.Length == 0)
            {
                throw new ArgumentException("Inputted array cannot be null or empty", nameof(nums));
            }

            return nums[^1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            return Enumerable.Range(1, 99).Where(x => x % 2 != 0).ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            if (words == null)
            {
                throw new ArgumentNullException(nameof(words));
            }

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] != null)
                {
                    words[i] = words[i].ToUpper();
                }
            }
        }
    }
}
