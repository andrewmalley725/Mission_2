//this was written using .NET 5.0

using System;

namespace Mission_2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the dice throwing simulator!");
            Console.Write("\nHow many dice rolls would you like to simulate? ");

            string numRolls = Console.ReadLine();
            int rolls = Convert.ToInt32(numRolls);

            Throw th = new Throw(rolls); //create instance of throw class

            Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
            Console.WriteLine("Total number of rolls = " + numRolls + ".\n");

            th.Play(); //call Play method from throw class

            Console.WriteLine("\nThank you for using the dice throwing simulator. \tGoodbye!");
        }
    }
}

