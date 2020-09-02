using System;

public class Program
{
	public static ConsoleKey keyPressed;
	public static void Main()
	{

		Console.WriteLine("Even Bill Distributor");
		//Greet the User
		int totalMeals;
		double totalDollars;
		Console.Write("\n\n");
		Console.Write("Enter the total bill amount:\n");
		// User Input
		totalDollars = double.Parse(Console.ReadLine().Trim());
		Console.Write("Enter the total amount of meals ordered:\n");
		// User Input
		totalMeals = int.Parse(Console.ReadLine().Trim());
        Console.Write("---------------------------------");
		Console.Write("\n\n");

		{
            //Output the number 
            Console.Write("Your total bill amount was: {0}. The total amount of meals was {1}. Distributed evenly each persons total is: {2} \n", totalDollars, totalMeals, totalDollars / totalMeals);
            while (keyPressed != ConsoleKey.Enter)
			{
				Console.WriteLine("\nPress the Enter key to end this program...");
				keyPressed = Console.ReadKey().Key;
			}
		}
	}
}
// The console output style code was borrowed from https://dotnetfiddle.net/dU73F1 . Most code was changed as this assigment was slightly different, however credit is being given to the author.