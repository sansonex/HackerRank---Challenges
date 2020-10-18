using HackerRank.Challenges;
using System;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace HackerRank
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var challengeType = typeof(Challenge);

            var types = Assembly.GetAssembly(challengeType).GetTypes().Where(TheType => TheType.IsClass && !TheType.IsAbstract && TheType.IsSubclassOf(challengeType)).ToArray();
            Console.WriteLine("Available Challenges");

            for (int i = 1; i <= types.Length; i++)
            {
                Console.WriteLine($"{i} - {types[i - 1].Name}");
            }

            int selected = -1;
            do
            {
                Console.WriteLine("Choose a Challenge to Run");
                var parsed = int.TryParse(Console.ReadLine(), out int result);
                if (parsed)
                    selected = result;

            } while (selected == -1 || !IsBetween(0, types.Length - 1, selected - 1));


            if (types[selected - 1].IsClass)
            {
                Console.WriteLine($"--------------Start Running {types[selected - 1].Name}-----------------------");
                Console.WriteLine(Environment.NewLine);

                var challenge = (Challenge)Activator.CreateInstance(types[selected - 1]);

                await challenge.Run();
                
                Console.WriteLine(Environment.NewLine);
                Console.WriteLine($"--------------Finishe {types[selected - 1].Name}-----------------------");
            }
        }

        public static bool IsBetween(int start, int end, int value)
        {
            return (value >= start && value <= end);
        }
    }
}
