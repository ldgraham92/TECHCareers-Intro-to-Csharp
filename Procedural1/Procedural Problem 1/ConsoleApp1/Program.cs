using System;

public class Program
{
	public static ConsoleKey keyPressed;
	public static void Main()
	{

		Console.WriteLine("Simple Number Cuber");
		//Greet the User
		int userInputNumber;
		Console.Write("\n\n");
		Console.Write("Enter the Number you wish to cube:\n");
		Console.Write("---------------------------------");
		Console.Write("\n\n");
		// User Input
		userInputNumber = int.Parse(Console.ReadLine().Trim());
		{
            //Output the number 
            Console.Write("Your chosen number was: {0}. The cube of {1} is: {2} \n", userInputNumber, userInputNumber, Math.Pow(userInputNumber, 3));
			while (keyPressed != ConsoleKey.Enter)
			{
				Console.WriteLine("\nPress the Enter key to end this program...");
				keyPressed = Console.ReadKey().Key;
			}
		}
	}
}
// The console output style code was borrowed from https://dotnetfiddle.net/dU73F1 . Most code was changed as this assigment was slightly different, however credit is being given to the author.