using System;

namespace LoopTasks
{
    public static class LoopTasks
    {
        /// <summary>
        /// Task 1
        /// </summary>
        public static int SumOfOddDigits(int n)
        {
           int sum = 0;
            while (n > 0)
            {
                int digit = n % 10;
                if (digit % 2 == 1)
                {
                    sum+=digit;
                }
                n/= 10;
            }
            return sum;
            throw new NotImplementedException();
        }

        /// <summary>
        /// Task 2
        /// </summary>
        public static int NumberOfUnitsInBinaryRecord(int n)
        {
           int number = 0;
            while (n > 0)
            {
                number += n % 2;
                n = n / 2;  
            }
            return number;

            throw new NotImplementedException();
        }

        /// <summary>
        /// Task 3 
        /// </summary>
        public static int SumOfFirstNFibonacciNumbers(int n)
        {
            {
                int result = 0;
                int F0 = 0;
                int F1 = 1;
                int next;
                for (int step = 0; step < n; step++)
                {
                    result = result + F0;
                    next = F0 + F1;
                    F0 = F1;
                    F1 = next;
                }

                return result;
                throw new NotImplementedException();
            }

            throw new NotImplementedException();
        }
    }
}