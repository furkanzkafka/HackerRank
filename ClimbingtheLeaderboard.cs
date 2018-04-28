using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
    class Class6
    {
        static void Main(String[] args)
        {
            // Performans rework

            Console.ReadLine();
            var scores_temp = Console.ReadLine().Split(' ');
            var playerScoresWithRepeats = Array.ConvertAll(scores_temp, long.Parse);
            var playerScores = new long[playerScoresWithRepeats.Length];
            playerScores[0] = playerScoresWithRepeats[0];
            int k = 0;
            for (int j = 1; j < playerScoresWithRepeats.Length; j++)
            {
                if (playerScoresWithRepeats[j] < playerScores[k])
                {
                    playerScores[++k] = playerScoresWithRepeats[j];
                }
            }

            var totalLevelsToPlay = int.Parse(Console.ReadLine());
            var alice_temp = Console.ReadLine().Split(' ');
            var aliceScores = Array.ConvertAll(alice_temp, long.Parse);


            var currentRoundRank = 0;
            var aliceScoreIndex = 0;
            var nextAliceScore = aliceScores[aliceScoreIndex];

            if (nextAliceScore < playerScores[playerScores.Length - 1])
            {
                currentRoundRank = playerScores.Length + 1;
            }
            else
            {
                for (int i = 0; i < playerScores.Length; i++)
                {
                    if (nextAliceScore >= playerScores[i])
                    {
                        currentRoundRank++;
                        break;
                    }
                    currentRoundRank++;
                }
            }
            totalLevelsToPlay--;
            Console.WriteLine(currentRoundRank);



            while (totalLevelsToPlay > 0)
            {
                nextAliceScore = aliceScores[++aliceScoreIndex];
                var temp = currentRoundRank - 2;

                while (temp > -1)
                {
                    var nextHigherRankedPlayerScore = playerScores[temp--];
                    if (nextAliceScore >= nextHigherRankedPlayerScore)
                    {
                        currentRoundRank--;
                        continue;
                    }
                    else
                        break;
                }
                Console.WriteLine(currentRoundRank);
                totalLevelsToPlay--;
            }

        }


        /*** Dusuk Performans***/
        //   private static long carry, counter;
        //   private static long[] aliceRanks;

        //   /*
        //* Complete the climbingLeaderboard function below.
        //*/
        //   static long[] climbingLeaderboard(long[] scores, long[] alice, long aliceCount)
        //   {
        //       counter = 1;
        //       aliceRanks = new long[aliceCount];
        //       /*
        //        * Write your code here.
        //        */
        //       for (int i = 0; i < alice.Length; i++)
        //       {
        //           for (int j = 0; j < scores.Length; j++)
        //           {
        //               if (scores[j] != carry && scores[j] > alice[i])
        //               {
        //                   counter++;
        //               }
        //               carry = scores[j];
        //           }

        //           aliceRanks[i] = counter;
        //           counter = 1;
        //           carry = 0;
        //       }

        //       return aliceRanks;
        //   }

        //   static void Main()
        //   {

        //       long scoresCount = Convert.ToInt32(Console.ReadLine());

        //       long[] scores = Array.ConvertAll(Console.ReadLine().Split(' '), scoresTemp => Convert.ToInt64(scoresTemp));
        //       long aliceCount = Convert.ToInt32(Console.ReadLine());

        //       long[] alice = Array.ConvertAll(Console.ReadLine().Split(' '), aliceTemp => Convert.ToInt64(aliceTemp));
        //       long[] result = climbingLeaderboard(scores, alice, aliceCount);

        //       Console.WriteLine(string.Join("\n", result));
        //       Console.ReadLine();
        //   }
    }
}
