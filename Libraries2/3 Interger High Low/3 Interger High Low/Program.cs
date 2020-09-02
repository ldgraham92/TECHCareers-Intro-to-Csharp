using System;

public class Program
{
    public static ConsoleKey keyPressed;

    public static void Main()
    {

        Console.WriteLine("3 Interger High Low");
        //Greet the User
        int userInt;
        Console.Write("\n\n");
        Console.Write("Enter the 3 digit number you wish to compare\n");
        Console.Write("---------------------------------");
        Console.Write("\n\n");
        // User Input
        userInt = Convert.ToInt32(Console.ReadLine().Trim());
        //Read the numbers passed in to the console
        string userIntString = userInt.ToString();
        var intArray = userIntString.ToCharArray(); // Convert the String in to an array for comparing

        // I understand below can be done MUCH easier with a loop, however as loops were not taught by this portion of the practice problems, I wanted to avoid using them if possible
        var userIntLow = Math.Min(int.Parse(intArray[0].ToString()), int.Parse(intArray[1].ToString()));
        userIntLow = Math.Min(userIntLow, int.Parse(intArray[2].ToString()));
        var userIntHigh = Math.Max(int.Parse(intArray[0].ToString()), int.Parse(intArray[1].ToString()));
        userIntHigh = Math.Max(userIntHigh, int.Parse(intArray[2].ToString()));

        {

            //Output the number 
            Console.Write("The Highest number is {0}, the Lowest number is {1}", userIntHigh, userIntLow);
            while (keyPressed != ConsoleKey.Enter)
            {
                Console.WriteLine("\nPress the Enter key to end this program...");
                keyPressed = Console.ReadKey().Key;
            }
        }
    }
}
// Array tips given to me by a friend who is in the industry, not found online.