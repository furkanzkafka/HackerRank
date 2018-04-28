using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
    class Program
    {
        private static long sum, arrayLength,min,max;

        /*
      * Complete the miniMaxSum function below.
      */
        static void miniMaxSum(int[] arr)
        {
            /*
             * Write your code here.
             */


        arrayLength = arr.Length;
        long[] sumArray = new long[arrayLength];

            for (int j = 0; j < arrayLength; j++)
            {
                sum -= arr[j];

                for (int i = 0; i < arr.Length; i++)
                {
                    sum += arr[i];
                }

                sumArray[j] = sum;
                sum = 0;
            }
            min = sumArray[0];
            max = sumArray[0];

            for (int i = 0; i < arrayLength; i++)
            {
                if (min > sumArray[i])
                {
                    min = sumArray[i];
                }
                if (max < sumArray[i])
                {
                    max = sumArray[i];
                }
            }

            Console.WriteLine(min + " " + max);


        }

        static void Main(string[] args)
        {
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            miniMaxSum(arr);

            Console.ReadLine();
        }
    }
}
