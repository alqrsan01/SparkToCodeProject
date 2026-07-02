namespace C__Fundamentals___Part_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1: Countdown Timer
            Console.Write("Enter a starting number: ");
            int number = int.Parse(Console.ReadLine());

            for (int i = number; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Liftoff!");

            // Task 2: Sum of Numbers 1 to N
            Console.Write("Enter a positive whole number N: ");
            int n = int.Parse(Console.ReadLine());

            int total = 0;
            for (int i = 1; i <= n; i++)
            {
                total += i;
            }
            Console.WriteLine("Sum from 1 to " + n + " = " + total);

            // Task 3: Multiplication Table
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(num + " x " + i + " = " + (num * i));
            }

            // Task 4 :  Password Retry
            string correctPassword = "Spark2026";
            string input = "";

            while (input != correctPassword)
            {
                Console.Write("Enetr the password: ");
                input = Console.ReadLine();

                if (input != correctPassword)
                {
                    Console.WriteLine("Incorrect password. try again.");
                }
            }
            Console.WriteLine("Access Granted");

            // Task 5: Number Guessing Game
            int secretNumber = 42;
            int guess = 0;
            int attempts = 0;

            do
            {
                Console.Write("Guess the number: ");
                guess = int.Parse(Console.ReadLine());
                attempts++;

                if (guess > secretNumber)
                {
                    Console.WriteLine("Too high");
                }
                else if (guess < secretNumber)
                {
                    Console.WriteLine("Too low");
                }
                else
                {
                    Console.WriteLine("Correct! You guessed it in " + attempts + " attempts.");
                }
            } while (guess != secretNumber);

            // Task 6: Safe Division Calculator
            try
            {
                Console.Write("Enter the first number: ");
                double a = double.Parse(Console.ReadLine());
                Console.Write("Enter the second number: ");
                double b = double.Parse(Console.ReadLine());

                if (b == 0)
                {
                    throw new DivideByZeroException();
                }

                double result = a / b;
                Console.WriteLine("Result: " + a + " / " + b + " = " + result);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: Cannot divide by zero");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Please enter valid numbers");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unexpected error: " + ex.Message);
            }

            // Task 7: Repeating Menu with Exit Option
            bool running = true;
            
            while (running)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1) Say Hello");
                Console.WriteLine("2) Show Time-of-day Greeting");
                Console.WriteLine("3) Exit");
                Console.WriteLine("Choose an option: ");

                try
                {
                    int choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Hello! Welcome to Spark to Code!");
                            break;
                        case 2:
                            Console.WriteLine("Good day! Hope you're enjoying the bootcamp.");
                            break;
                        case 3:
                            Console.WriteLine("Goodbye!");
                            running = false;
                            break;
                        default:
                            Console.WriteLine("Invalid option. Please choose 1, 2, 3");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error: Please enter a number (1, 2, 3)");
                }
            }

            // Task 8: Sum of Even Numbers Only
            Console.Write("Eneter a positive whole number N: ");
            int n1 = int.Parse(Console.ReadLine());
            int total1 = 0;
             
            for (int i = 1; i <= n1; i++)
            {
                if (i % 2 == 0)
                {
                    total1 += i;
                }
            }
            Console.WriteLine($"Sum of even numbers from 1 to {n} = {total1}");
        }
    }
}
