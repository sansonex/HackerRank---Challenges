using HackerRank.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Challenges
{
    public abstract class Challenge
    {
        public string[] Input { get; set; }

        public string[] Readme { get; set; }

        public Challenge()
        {
            this.Input = FileHandler.ReadFile(this.GetType().Name.Replace(nameof(Challenge), ""), "input");
            this.Readme = FileHandler.ReadFile(this.GetType().Name.Replace(nameof(Challenge), ""), "readme");

            foreach (var line in Readme)
            {
                Console.WriteLine(line);
            }

            Console.WriteLine("Result:");
        }

        public abstract Task Run();
    }
}
