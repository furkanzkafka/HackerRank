using System;


namespace TestConsole
{
    class Class1
    {
        private static long sum;
        /*
     * Complete the aVeryBigSum function below.
     */
        static long aVeryBigSum(int n, long[] ar)
        {
            /*
             * Write your code here.
             */
            for (int i = 0; i < ar.Length; i++)
            {
                 sum += ar[i];
            }
             
            return sum;
        }

        static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            long[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt64(arTemp));

            long result = aVeryBigSum(n, ar);

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
