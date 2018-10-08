using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool validChoice = false;
            int userChoice = -1;
            while (userChoice != 0)
            {
                Console.WriteLine("What operation do you wish to perform?");
                Console.WriteLine("0. Quit.");
                Console.WriteLine("1. Add.");
                Console.WriteLine("2. Subtract.");
                Console.WriteLine("3. Multiply.");
                Console.WriteLine("4. Divide.");
                while (!validChoice || !(userChoice > -1 && userChoice < 5 ))
                {
                    validChoice = int.TryParse(Console.ReadLine(), out userChoice);
                    if (!validChoice)
                        Console.WriteLine("You did not enter a valid selection. Try again.");
                }
                if (userChoice == 0)
                    Console.WriteLine("Thanks for playing.");
                else if (userChoice == 1)
                {
                    Console.WriteLine("Pick your first number to add.");
                    int x = int.Parse(Console.ReadLine());
                    Console.WriteLine("Pick your second number to add.");
                    int y = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Your solution: {Add(x, y)}");
                }
                else if (userChoice == 2)
                {
                    Console.WriteLine("Pick your first number to subtract.");
                    int x = int.Parse(Console.ReadLine());
                    Console.WriteLine("Pick your second number to subtract.");
                    int y = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Your solution: {Subtract(x, y)}");
                }
                else if (userChoice == 3)
                {
                    Console.WriteLine("Pick your first number to multiply.");
                    int x = int.Parse(Console.ReadLine());
                    Console.WriteLine("Pick your second number to multiply.");
                    int y = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Your solution: {Multiply(x, y)}");
                }
                else if (userChoice == 4)
                {
                    Console.WriteLine("Pick your first number to divide.");
                    int x = int.Parse(Console.ReadLine());
                    Console.WriteLine("Pick your second number to divide.");
                    int y = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Your solution: {Divide(x, y)}");
                }
                else
                    Console.WriteLine("How did you get here?");
                validChoice = false;
            }
        }

        static int Add(int x, int y) => x + y;

        static int Subtract(int x, int y) => x - y;

        static int Multiply(int x, int y) => x * y;

        static double Divide(int x, int y) => (double)x / y;
    }
}
