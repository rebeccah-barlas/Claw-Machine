using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Claw_Machine
{
    public static class ClawMachine
    {
        public static List<Reward> AllRewards { get; set; } = new List<Reward>
        {
            new Reward("Cheap Candy", 0.5m),
            new Reward("Cheap Candy", 0.5m),
            new Reward("Cheap Candy", 0.5m),
            new Reward("Candy Bar", 1.0m),
            new Reward("Candy Bar", 1.0m),
            new Reward("Stuffed Animal", 10.0m),
        };
        public static decimal CostToPlay = 1.50m;

        public static Reward GetReward()
        {
            Random random = new Random();
            int reward = random.Next(AllRewards.Count);
            return AllRewards[reward];
        }
        public static bool MadeProfit(Reward reward)
        {
            if (reward.Value > CostToPlay)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void Play()
        {
            Reward reward = GetReward();
            Console.WriteLine($"You won: {reward.ToString()}");
            bool madeProfit = MadeProfit(reward);
            if (madeProfit == true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("You made a profit!");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You lost money. Better luck next time!");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
        }
    }
}

