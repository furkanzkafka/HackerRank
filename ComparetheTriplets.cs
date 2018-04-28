using System;

namespace TestConsole
{
    class Solution
    {

        private static int alice, bob;
        /*
     * Complete the solve function below.
     */
        static void solve(int a0, int a1, int a2, int b0, int b1, int b2)
        {
            if (a0 < b0)
                bob += 1;
            if (a0 > b0)
                alice += 1;
            if (a1 < b1)
                bob += 1;
            if (a1 > b1)
                alice += 1;
            if (a2 < b2)
                bob += 1;
            if (a2 > b2)
                alice += 1;
            
            Console.WriteLine(alice + " " + bob);
            Console.ReadLine();

        }

        static void Main(string[] args)
        {
            
         
            string[] a0A1A2 = Console.ReadLine().Split(' ');

            int a0 = Convert.ToInt32(a0A1A2[0]);

            int a1 = Convert.ToInt32(a0A1A2[1]);

            int a2 = Convert.ToInt32(a0A1A2[2]);

            string[] b0B1B2 = Console.ReadLine().Split(' ');

            int b0 = Convert.ToInt32(b0B1B2[0]);

            int b1 = Convert.ToInt32(b0B1B2[1]);

            int b2 = Convert.ToInt32(b0B1B2[2]);

            solve(a0, a1, a2, b0, b1, b2);

            
        }

    }
}
