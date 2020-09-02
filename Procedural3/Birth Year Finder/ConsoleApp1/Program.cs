using System;

public class Program
{
	public static ConsoleKey keyPressed;
	public static void Main()
	{

		Console.WriteLine("Simple Birth Year Finder");
		//Greet the User
		int userAge;
		int currentYear = DateTime.Now.Year;
		Console.Write("\n\n");
		Console.Write("Enter your Age\n");
		Console.Write("---------------------------------");
		Console.Write("\n\n");
		// User Input
		userAge = int.Parse(Console.ReadLine().Trim());

		{
			//Output the number 
			Console.Write("Your current age is: {0}. Your birth year is {1}. \n", userAge, currentYear - userAge);
			while (keyPressed != ConsoleKey.Enter)
			{
				Console.WriteLine("\nPress the Enter key to end this program...");
				keyPressed = Console.ReadKey().Key;
			}
		}
	}
}
// The console output style code was borrowed from https://dotnetfiddle.net/dU73F1 . Most code was changed as this assigment was slightly different, however credit is being given to the author.