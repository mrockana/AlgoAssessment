using System.Linq;

namespace TGS.Challenge
{
    /*
         Given a zero-based integer array of length N, the equivalence index (i) is the index where the sum of all the items to the left of the index
         are equal to the sum of all the items to the right of the index.

         Constraints: 0 <= N <= 100 000

         Example: Given the following array [1, 2, 3, 4, 5, 7, 8, 10, 12]
         Your program should output "6" because 1 + 2 + 3 + 4 + 5 + 7 = 10 + 12

         If no index exists then output -1

         There are accompanying unit tests for this exercise, ensure all tests pass & make
          sure the unit tests are correct too.
       */

    public class EquivalenceIndex
    {
        public int Find(int[] numbers)
        {
            var numbersSum = numbers.Sum(n => n);
            var halfSum = numbersSum / 2;
            var notFound = -1;

            var loopSum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                loopSum += numbers[i];
                if (numbers.Length == (i + 1))
                {
                    if (loopSum == numbers[i])
                    {
                        return i + 1;
                    }
                    continue;
                }

                if (loopSum == (halfSum - numbers[i + 1] / 2))
                {
                    return i + 1;
                }
            }

            return notFound;
        }
    }
}