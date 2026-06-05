using System;

class Program
{
    static void Main(string[] args)
    {
        double num1;
        double num2;
        string? operation;
        double result = 0;

        do
        {
            Console.Write("Enter first number: ");
        } while (!double.TryParse(Console.ReadLine(), out num1));

        do
        {
            Console.Write("Enter operation (+,-,*,/): ");
            operation = Console.ReadLine();
        } while (operation != "+" && operation != "-" && operation != "*" && operation != "/");
      
        do
        {
            Console.Write("Enter second number: ");
        } while (!double.TryParse(Console.ReadLine(), out num2));

        if (operation == "+")
        {
            result = num1 + num2;
        }
        else if (operation == "-")
        {
            result = num1 - num2;
        }
        else if (operation == "*")
        {
            result = num1 * num2;
        }
        else if (operation == "/")
        {
            if (num2 != 0)
            {
                result = num1 / num2;
            }
            else
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
                return;
            }
        }

        Console.WriteLine($"Result: {num1} {operation} {num2} = {result}");
    }
}

