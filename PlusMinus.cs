using System;

namespace TestConsole
{
    class Class3
    {
        /*
        * Complete the plusMinus function below.
        */

        private static decimal positive,negative,zero;
        private static decimal positiveResult, negativeResult, zeroResult;

        private static decimal[] result;

        static void plusMinus(int[] arr, int n)
        {
            /*
             * Write your code here.
             */
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                    positive++;
                else if (arr[i] < 0)
                    negative++;
                else if (arr[i] == 0)
                    zero++;
            }

            positiveResult = positive / n;
            negativeResult = negative / n;
            zeroResult = zero / n;

            Console.WriteLine(positiveResult.ToString("n6") + "\n" + negativeResult.ToString("0.######") + "\n" + zeroResult.ToString("0.######"));
            Console.ReadLine();
        }

        static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));

            plusMinus(arr,n);
        }
    }
}
