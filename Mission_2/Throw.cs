using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission_2
{
    public class Throw
    {
        private int NumRolls = 0;

        public Throw(int rolls)
        {
            NumRolls = rolls;
        }

        public void Play()
        {
            var rand = new Random();
            int[] totals = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }; //array stores the number of roles for each possible value 2-12
            double[] percents = new double[totals.Length]; //percents array stores the pecentage of each value
            int dice1 = 0;
            int dice2 = 0;
            int dieSum = 0; //stores the sum of the two die
            int bigSum = 0; //stores the sum of the totals array

            for (int i = 0; i < NumRolls; i++)
            {
                dice1 = rand.Next(1, 7);
                dice2 = rand.Next(1, 7);

                dieSum = dice1 + dice2;

                totals[dieSum - 2] = totals[dieSum - 2] + 1;

            }

            bigSum = totals.Sum();

            for (int i = 0; i < totals.Length; i++)
            {
                percents[i] = Math.Round(Convert.ToDouble(totals[i]) / bigSum * 100);
                int percent = (Int32)percents[i];
                IEnumerable<string> ast = Enumerable.Repeat("*", percent);
                Console.Write((i + 2).ToString() + ": ");

                foreach (string str in ast)
                {
                    Console.Write(str);
                }

                Console.Write("\n");
            }

        }
    }
}