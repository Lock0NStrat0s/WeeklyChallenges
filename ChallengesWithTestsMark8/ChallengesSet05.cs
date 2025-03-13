using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            while (++startNumber % n != 0)
            {   
            }

            return startNumber;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            foreach (Business item in businesses)
            {
                item.Name = item.TotalRevenue == 0 ? "CLOSED" : item.Name;
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0) return false;
            return numbers.OrderBy(x => x).ToArray().SequenceEqual(numbers);
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0) return 0;

            //List<int> resultArr = new();
            //for (int i = 0; i < numbers.Length - 1; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        resultArr.Add(numbers[i + 1]);
            //    }
            //}

            //return resultArr.Sum();

            return Enumerable.Range(0, numbers.Length - 1)
                .Where(x => numbers[x] % 2 == 0)
                .Select(y => numbers[y + 1])
                .Sum();
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if (words == null || words.Length == 0) return "";

            //string result = "";

            //var newArr = words.Where(x => !string.IsNullOrWhiteSpace(x)).Select(y => y.Trim()).ToList();

            //newArr.ForEach(x => result += $"{x} ");

            //return result.Length > 0 ? result.Trim() + "." : "";

            var sentence = string.Join(" ", words.Where(x => !string.IsNullOrWhiteSpace(x)).Select(y => y.Trim()));

            return string.IsNullOrEmpty(sentence) ? "" : sentence + ".";
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            throw new NotImplementedException();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            throw new NotImplementedException();
        }
    }
}
