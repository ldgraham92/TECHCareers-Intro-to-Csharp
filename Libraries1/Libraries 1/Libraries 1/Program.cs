using System;

public class Program
{
	public static ConsoleKey keyPressed;
	public static void Main()
	{

		Console.WriteLine("Simple String to Uppercase");
		//Greet the User
		string upperString;
		Console.Write("\n\n");
		Console.Write("Enter the sentence you wish to convert to UPPERCASE\n");
		Console.Write("---------------------------------");
		Console.Write("\n\n");
		// User Input
		upperString = (Console.ReadLine().Trim());
		{
			//Output the number 
			Console.Write("{0}", upperString.ToUpper());
			while (keyPressed != ConsoleKey.Enter)
			{
				Console.WriteLine("\nPress the Enter key to end this program...");
				keyPressed = Console.ReadKey().Key;
			}
		}
	}
}
// The console output style code was borrowed from https://dotnetfiddle.net/dU73F1 . Most code was changed as this assigment was slightly different, however credit is being given to the author.