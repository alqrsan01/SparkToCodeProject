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

            // Task 9: Validated Positive Number Input
            int n2 = 0;
            bool validInput = false;

            do
            {
                Console.Write("Enter a positive whole number: ");
                try
                {
                    n2 = int.Parse(Console.ReadLine());
                    if (n2 <= 0)
                    {
                        Console.WriteLine("Error: The number must be positive (greater than zero)");
                    }
                    else
                    {
                        validInput = true;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error: That is not a valid number.");
                }
            } while (!validInput);

            int total2 = 0;
            for (int i = 1; i <= n2; i++)
            {
                total2 += i;
            }
            Console.WriteLine($"Sum from 1 to {n2} = {total2}");

            // Task 10: Simple ATM Simulation
            int correctPin = 1234;
            double balance = 100.000;
            int maxAttempts = 3;
            int attempts1 = 0;
            bool pinCorrect = false;

            while (attempts1 < maxAttempts && !pinCorrect)
            {
                Console.Write("Eneter your PIN: ");

                try
                {
                    int enteredPin = int.Parse(Console.ReadLine());
                    attempts1++;

                    if (enteredPin == correctPin)
                    {
                        pinCorrect = true;
                        Console.WriteLine("PIN accepted. Welcome!");
                    }
                    else
                    {
                        int remainig = maxAttempts - attempts1;
                        if (remainig <= 0)
                        {
                            Console.WriteLine($"Incorrect PIN {remainig} attempts remaining");
                        }
                    }
                }
                catch (FormatException)
                {
                    attempts1++;
                    int remainig = maxAttempts - attempts1;
                    Console.WriteLine("Invalid input.");
                    if (remainig > 0)
                    {
                        Console.WriteLine($"{remainig} + attempts remaining.");
                    }
                }
            }
            if (!pinCorrect)
            {
                Console.WriteLine("Card blocked. Too many incorrect attempts.");
                return;
            }
            bool sessionActive = true;

            while (sessionActive)
            {
                Console.WriteLine("ATM Menu");
                Console.WriteLine("1) Deposit");
                Console.WriteLine("2) Withdraw");
                Console.WriteLine("3) Check Balance");
                Console.WriteLine("4) Exit");
                Console.Write("Choose an option: ");

                try
                {
                    int choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.Write("Enter deposit amount (OMR): ");
                            try
                            {
                                double depositAmount = double.Parse(Console.ReadLine());
                                if (depositAmount <= 0)
                                {
                                    Console.WriteLine("Error: Deposit amount must be positive");
                                }
                                else
                                {
                                    balance += depositAmount;
                                    Console.WriteLine($"Deposit successful. New balance: {balance} OMR");
                                }
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("Error: Invalid amount entered.");
                            }
                            break;
                        case 2:
                            Console.Write("enter withdrawal amount (OMR): ");
                            try
                            {
                                double withdrawalAmount = double.Parse(Console.ReadLine());
                                if (withdrawalAmount <= 0)
                                {
                                    Console.WriteLine("Error: Withdrawal amount must be positive");
                                }
                                else if (withdrawalAmount > balance)
                                {
                                    Console.WriteLine("Error: Insufficient funds");
                                }
                                else
                                {
                                    balance -= withdrawalAmount;
                                    Console.WriteLine($"Withdrawal successful. New balance: {balance} OMR");
                                }
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("Error: Invalid amount entered");
                            }
                            break;
                        case 3:
                            Console.WriteLine($"Current balance: {balance} OMR");
                            break;
                        case 4:
                            Console.WriteLine("Thank you for using the ATM.");
                            sessionActive = false;
                            break;
                        default:
                            Console.WriteLine("Invalid option. Please choose 1, 2, 3, or 4");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error: Please enter a valid number (1, 2, 3, or 4)");
                }
            }
        }
    }
}
