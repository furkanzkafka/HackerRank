using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
    class Class5
    {

        private static string[] time;
        private static int hour;

        /*
         * Complete the timeConversion function below.
         */
        static void timeConversion(string s)
        {
            /*
             * Write your code here.
             */
            if (s.Contains("PM"))
            {
                s = s.Substring(0, 8);

                time = s.Split(':');

                hour = Convert.ToInt32(time[0]);

                if (hour != 12)
                {
                    hour += 12;
                }

                time[0] = hour.ToString();


                Console.WriteLine(time[0] + ":" + time[1] + ":" + time[2]);

            }
            else if (s.Contains("AM"))
            {
                s = s.Substring(0, 8);

                time = s.Split(':');

                hour = Convert.ToInt32(time[0]);

                if (hour == 12)
                {
                    time[0] = "00";
                }

                Console.WriteLine(time[0] + ":" + time[1] + ":" + time[2]);

            }
            Console.ReadLine();
        }

        static void Main(string[] args)
        {

            string s = Console.ReadLine();

            timeConversion(s);

        }
    }
}
