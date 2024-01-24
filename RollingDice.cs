using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission_2
{
    internal class RollingDice
    {
        public int[] RollDice(int rollTotal)
        {
            int[] sums = new int[11];
            Random random = new Random();

            for (int i = 0; i < rollTotal; i++)
            {
                int roll1 = random.Next(1, 7);
                int roll2 = random.Next(1, 7);
                int sum = roll1 + roll2;
                sums[sum - 2]++; // Increment the count for this sum
            }

            return sums;
        }
    }
}
