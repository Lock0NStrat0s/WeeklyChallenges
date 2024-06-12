using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if (words == null) return false;

            foreach (var item in words)
            {
                if (item == null) break;

                if (!ignoreCase)
                {
                    if (item.Contains(word)) return true;
                }
                else
                {
                    if (item.ToLower().Contains(word.ToLower())) return true;
                }
            }

            return false;
        }

        public bool IsPrimeNumber(int num)
        {
            if (num < 2) return false;

            int positiveNum = Math.Abs(num);
            for (int i = 2; i < positiveNum; i++)
            {
                if (positiveNum % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            List<char> chars = str.ToList();
            Dictionary<char, int> dictLetters = new Dictionary<char, int>();
            foreach (var item in chars)
            {
                if (!dictLetters.ContainsKey(item))
                {
                    dictLetters.Add(item, 1);
                }
                else
                {
                    dictLetters[item]++;
                }
            }

            var uniqueLetters = dictLetters.Where(x => x.Value == 1).Select(x => x.Key).ToList();

            if (chars.Count < 1) return -1;
            if (uniqueLetters.Count < 1) return -1;

            char lastUniqueLetter = uniqueLetters[^1];

            return str.LastIndexOf(lastUniqueLetter);
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            int count = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int tempCount = 1;
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        tempCount++;
                    }
                    else
                    {
                        break;
                    }
                }

                if (tempCount > count)
                {
                    count = tempCount;
                }
            }

            return count;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            if (elements == null) return new double[] { };
            if (n < 1) return new double[] { };

            List<double> nthDoubles = new();
            for (int i = n - 1; i < elements.Count; i += n)
            {
                nthDoubles.Add(elements[i]);
            }

            return nthDoubles.ToArray();
        }
    }
}
