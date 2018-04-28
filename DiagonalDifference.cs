using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
    class Class2
    {
        private static int[] sumArray1, sumArray2;
        private static int sum1, sum2, result1, counter;

        /*
        * Complete the diagonalDifference function below.
        */

        static int diagonalDifference(int[][] a,int n)
        {
            /*
             * Write your code here.
             */
            sumArray1 = new int[n];
            sumArray2 = new int[n];

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a.Length; j++)
                {
                    if (i == j)
                    {
                        sumArray1[i] = a[i][j];
                    }
                }
            }

            for (int i = a.Length - 1; i >= 0; i--)
            {
                for (int j = counter; j < a.Length;)
                {
                    sumArray2[i] = a[i][j];
                    counter++;
                    break;
                }
                
            }

            //2,0 1,1 0,2 / 2 1 0 / 0 1 2
            //2,0 1,0 0,0


            for (int i = 0; i < sumArray1.Length; i++)
            {
                sum1 += sumArray1[i];
                sum2 += sumArray2[i];
            }

            result1 = sum1 - sum2;

            return Math.Abs(result1);
        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[][] a = new int[n][];

            for (int aRowItr = 0; aRowItr < n; aRowItr++)
            {
                a[aRowItr] = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp));
            }

            int result = diagonalDifference(a,n);

            Console.WriteLine(result);
            Console.ReadLine();
        }

    }
}
