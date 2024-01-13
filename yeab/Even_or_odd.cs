using System;

namespace yeab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Number");
            string input = Console.ReadLine();

            // Parse the input string to an integer
            if (int.TryParse(input, out int number))
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine(number + " is Even");
                }
                else
                {
                    Console.WriteLine(number + " is odd");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
    }
}
