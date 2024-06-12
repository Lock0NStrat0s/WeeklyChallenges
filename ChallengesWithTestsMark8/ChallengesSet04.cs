using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            return numbers.Select(x => x % 2 == 0 ? x : x * (-1)).Sum();
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            return new List<string> { str1, str2, str3, str4 }.Min(x => x.Length);
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            return new List<int> { number1, number2, number3, number4 }.Min();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            var sides = new List<int> { sideLength1, sideLength2, sideLength3 }.OrderBy(x => x);
            var shortestSide = sides.ElementAt(0);
            var middleSide = sides.ElementAt(1);
            var longestSide = sides.ElementAt(2);
            return shortestSide + middleSide > longestSide;
        }

        public bool IsStringANumber(string input)
        {
            return int.TryParse(input, out _) || double.TryParse(input, out _);
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int nullCount = objs.Count(x => x == null);
            return nullCount > objs.Length / 2;
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null) return 0;
            var evens = numbers.Where(x => x % 2 == 0);
            return evens.Count() < 1 ? 0 : evens.Average();
        }

        public int Factorial(int number)
        {
            if (number < 0) throw new ArgumentOutOfRangeException();

            while (number > 1)
            {
                return number * Factorial(number - 1);
            }

            return 1;
        }
    }
}
