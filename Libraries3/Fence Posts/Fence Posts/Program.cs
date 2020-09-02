using System;

public class Program
{
	public static ConsoleKey keyPressed;
	public static void Main()
	{

		Console.WriteLine("Fence Post Paint Calculator");
		int fencePosts;
		//Greet the User
		Console.Write("\n\n");
		Console.Write("Please enter the number of fence posts you plan on painting:\n");
		// User Input
		fencePosts = int.Parse(Console.ReadLine().Trim());
		int paintTotal = (fencePosts / 4);
		{
			//Output the number 
			Console.Write("To paint {0} fence posts you require {1} bucket(s) of paint. \n", fencePosts, paintTotal);
			while (keyPressed != ConsoleKey.Enter)
			{
				Console.WriteLine("\nPress the Enter key to end this program...");
				keyPressed = Console.ReadKey().Key;
			}
		}
	}
}