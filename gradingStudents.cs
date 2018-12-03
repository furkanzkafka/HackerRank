using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionOfCSharp
{
    class gradingStudents
    {

        static void Main(string[] args)
        {
  
            int[] grades = { 73, 67, 38, 33};
            int[] points = { 45, 50, 55, 60, 65, 70, 75, 80, 85, 90, 95, 100 };

            for (int i = 0; i < grades.Length; i++)
            {
                if ((grades[i] + 2) < 40)
                {
                    continue;
                }

                for (int j = 0; j < points.Length; j++)
                {
                    if ((points[j] - grades[i]) < 3 && (points[j] - grades[i]) > 0)
                    {
                        grades[i] = points[j];
                    }
                }
            }

            for (int i = 0; i < grades.Length; i++)
            {
                Console.WriteLine(grades[i]);
            }

            Console.ReadLine();
        }



    }
}
