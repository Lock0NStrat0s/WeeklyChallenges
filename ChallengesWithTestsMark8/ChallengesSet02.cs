using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            return vals.Count() % 2 == 0;
        }

        public bool IsNumberEven(int number)
        {
            return number % 2 == 0;
        }

        public bool IsNumberOdd(int num)
        {
            return num % 2 != 0;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers?.Any() != true) return 0;
            return numbers.Min() + numbers.Max();
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            return str1.Length < str2.Length ? str1.Length : str2.Length;
        }

        public int Sum(int[] numbers)
        {
            if (numbers == null) return 0;
            return numbers.Select(x => x).Sum();
        }

        public int SumEvens(int[] numbers)
        {
            if (numbers == null) return 0;
            return numbers.Where(x => x % 2 == 0).Sum();
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null) return false;
            return numbers.Select(x => x).Sum() % 2 != 0;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            long count = 0;
            for (long i = 0; i < number; i++)
            {
                if (i % 2 == 1)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
