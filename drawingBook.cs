using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionOfCSharp
{
    class drawingBook
    {
        static int pageCount(int n, int p)
        {
            //Passed 26 Case
            int total = n / 2;
            int right = p / 2;
            int left = total - right;
            if (right < left)
            {
                return right;
            }
            else
            {
                return left;
            }

        }

        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine());

            int p = Convert.ToInt32(Console.ReadLine());

            int result = pageCount(n, p);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
