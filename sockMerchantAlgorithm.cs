using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionOfCSharp
{
    class sockMerchantAlgorithm
    {
        static void Main(string[] args)
        {

            //SOCK MERCHANT ALGORITHM
            //PASSED 8 CASE
            int[] ar = { 1, 1, 3, 1, 2, 1, 3, 3, 3, 3 };
            int counter = 0;

            for (int i = 0; i < ar.Length; i++)
            {
                if (ar[i] == -1)
                {
                    continue;
                }

                for (int j = i + 1; j < ar.Length; j++)
                {
                    if (ar[j] == -1)
                    {
                        continue;
                    }

                    if (ar[i] == ar[j])
                    {
                        ar[i] = -1;
                        ar[j] = -1;
                        counter++;
                        break;
                    }
                }
            }
            Console.WriteLine(counter);

            Console.ReadLine();

        }
    }
}
