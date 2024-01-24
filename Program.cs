using Mission_2;

internal class Program

{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Welcome to the dice throwing simulator!");
        System.Console.Write("How many dice rolls would you like to simulate?");
        int rolls = int.Parse(System.Console.ReadLine());

        RollingDice rd = new RollingDice();
        int[] results = rd.RollDice(rolls);

        System.Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
        System.Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
        System.Console.WriteLine($"Total number of rolls = {rolls}.");

        for (int i = 2; i <= 12; i++)
        {
            System.Console.Write($"{i}: ");
            printGraph(results[i - 2], rolls);
        }

        System.Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
    }

    static void printGraph(int count, int totalRolls)
    {
        int percentage = (count * 100) / totalRolls;
        for (int i = 0; i < percentage; i++)
        {
            System.Console.Write("*");
        }
        System.Console.WriteLine();
    }
}

