using System;

public class Program
{
	public static ConsoleKey keyPressed;
	public static void Main()
	{
		double triangleSideA;
		double triangleSideB;
		double triangleHypotenuse;
		double triangleRounded;

		//Greet the User
		Console.WriteLine("Simple Hypotenuse Calculator");
		Console.Write("\n\n");
		Console.Write("Please enter the length of side A of your triangle:\n");
		// User Input
		triangleSideA = double.Parse(Console.ReadLine().Trim());
		Console.Write("\n\n");
		Console.Write("Please enter the legnth of side B of your triangle:\n");
		triangleSideB = double.Parse(Console.ReadLine().Trim());

		triangleHypotenuse = Math.Sqrt((triangleSideA * triangleSideA) + (triangleSideB * triangleSideB));
		triangleRounded = Math.Round(triangleHypotenuse, 2);
		{
			//Output the number 
			Console.Write("The dimensions of your triangle are as follows: \n");
			Console.Write("Triangle Side A: {0}\n", triangleSideA);
			Console.Write("Triangle Side B: {0}\n", triangleSideB);
			Console.Write("Following Pythagorean Theorem; Asq + Bsq = Csq\n");
			Console.Write("The hypotenuse of your triangle is: {0}", triangleRounded);
			while (keyPressed != ConsoleKey.Enter)
			{
				Console.WriteLine("\nPress the Enter key to end this program...");
				keyPressed = Console.ReadKey().Key;
			}
		}
	}
}