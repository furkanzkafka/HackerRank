using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
    class Class4
    {
        /*
     * Complete the staircase function below.
     */
        static void staircase(int n)
        {
            /*
             * Write your code here.
             */

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (i <= (n - j))
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("#");
                    }
                }
                Console.Write("\n");
            }

            // 1 0,6 6
            // 2 1,5 1,6 6
            // 3 2,4 2,5 2,6


            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            staircase(n);
        }
    }
}
