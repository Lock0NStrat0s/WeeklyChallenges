using System;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            return numbers.Select(x => x % 2 != 0 ? -x : x).Sum();
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            return new string[] { str1, str2, str3, str4 }.Min(x => x.Length);
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            return new int[] { number1, number2, number3, number4 }.Min();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            int[] sides = { sideLength1, sideLength2, sideLength3 };

            return sides.All(x => x > 0) && sides.OrderBy(x => x).Take(2).Sum() > sides.Max();
        }

        public bool IsStringANumber(string input)
        {
            return !string.IsNullOrEmpty(input) && input.Count(x => char.IsLetter(x)) == 0 && (input.Count(x => char.IsPunctuation(x) && x != '-' && x != '.') == 0 || input.All(x => char.IsDigit(x)));
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            return objs.Count(x => x == null) > objs.Length / 2;
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0) return 0;

            var count = numbers.Where(x => x % 2 == 0);

            return count.Any() ? count.Average() : 0;
        }

        public int Factorial(int number)
        {
            // base case
            if (number == 0 || number == 1) return 1;
            if (number < 0) throw new ArgumentOutOfRangeException();

            // recursive case
            return Factorial(number - 1) * number;
        }
    }
}
