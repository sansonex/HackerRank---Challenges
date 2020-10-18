using HackerRank.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Challenges.AppleAndOrange
{
    public class AppleAndOrangeChallenge : Challenge
    {
        public override Task Run()
        {
            int s = Convert.ToInt32(Input[0].Split(" ")[0]);

            int t = Convert.ToInt32(Input[0].Split(" ")[1]);

            int a = Convert.ToInt32(Input[1].Split(" ")[0]);

            int b = Convert.ToInt32(Input[1].Split(" ")[1]);

            int m = Convert.ToInt32(Input[2].Split(" ")[0]);

            int n = Convert.ToInt32(Input[2].Split(" ")[1]);

            int[] apples = Array.ConvertAll(Input[3].Split(" "), applesTemp => Convert.ToInt32(applesTemp))
            ;

            int[] oranges = Array.ConvertAll(Input[4].Split(" "), orangesTemp => Convert.ToInt32(orangesTemp))
            ;

            countApplesAndOranges(s, t, a, b, apples, oranges);

            return Task.CompletedTask;
        }

        void countApplesAndOranges(int homeStartPoint, int homeEndPoint, int appleTree, int orangeTree, int[] apples, int[] oranges)
        {
            var appleCount = 0;
            var orangeCount = 0;
            for (int i = 0; i < apples.Length; i++)
            {
                if ((apples[i] + appleTree).IsBetween(homeStartPoint, homeEndPoint))
                    appleCount++;
            }

            for (int i = 0; i < oranges.Length; i++)
            {
                if ((oranges[i] + orangeTree).IsBetween(homeStartPoint, homeEndPoint))
                    orangeCount++;
            }

            Console.WriteLine(appleCount);
            Console.WriteLine(orangeCount);
        }
    }

}
