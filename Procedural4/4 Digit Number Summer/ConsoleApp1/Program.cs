using System;

public class Program
{
	public static ConsoleKey keyPressed;
	public static void Main()
	{

		Console.WriteLine("4 Digit Number Summer - No String Conversion");
		int userInt;
		//Greet the User
		Console.Write("\n\n");
		Console.Write("Please enter a 4 digit number of which you want the numbers summed:\n");
		// User Input
		userInt = int.Parse(Console.ReadLine().Trim());
		Console.Write("\n\n");
		int mySum = (userInt / 1000) % 10 + (userInt / 100) % 10 + (userInt / 10) % 10 + (userInt) % 10;
		{
			//Output the number 
			Console.Write("Your chosen number was: {0}. The sum of the numbers is {1} \n", userInt, mySum);
			while (keyPressed != ConsoleKey.Enter)
			{
				Console.WriteLine("\nPress the Enter key to end this program...");
				keyPressed = Console.ReadKey().Key;
			}
		}
	}
}
// The console output style code was borrowed from https://dotnetfiddle.net/dU73F1 . Most code was changed as this assigment was slightly different, however credit is being given to the author.