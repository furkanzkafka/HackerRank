using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionOfCSharp
{
    class countingValleys
    {
        static void Main(string[] args)
        {
            //Counting Valleys
            //It's passed 21 case
            int n = 12, high = 0, valley = 0;
            string s = "DDUUDDUDUUUD";
            char[] sArray = s.ToCharArray();

            for (int i = 0; i < sArray.Length; i++)
            {
                if (sArray[i] == 'U')
                {
                    high++;
                }
                else
                {
                    high--;
                }

                if (high == 0 && sArray[i] == 'U')
                {
                    valley++;
                }
            }
            Console.WriteLine(valley);
        }
    }
}
