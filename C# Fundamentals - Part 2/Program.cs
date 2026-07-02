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
        }
    }
}
