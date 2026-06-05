using System;

class Program
{
    static void Main(String[] args )
    {
        Console.Write("Enter a starting number (will be maximized at 5): ");
        int userInput = Convert.ToInt32(Console.ReadLine());

        // Ensure the user input does not exceed 5
        if (userInput > 5)
            userInput = 5;

        int counter = 0;

        do
        {
            Console.WriteLine(counter);
            counter++;
        }
        while (counter <= userInput);
    }
}