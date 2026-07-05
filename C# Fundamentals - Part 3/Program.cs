namespace C__Fundamentals___Part_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1: Absolute Difference
            Console.Write("Enter first number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter secound number: ");
            int num2 = int.Parse(Console.ReadLine());

            int subtractResult = num1 - num2;
            Console.WriteLine(Math.Abs(subtractResult));

            // Task 2:  Power & Root Explorer
            Console.Write("Enetr a number: ");
            int num3 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Power of {num3} is: {Math.Pow(num3, 2)}");
            Console.WriteLine($"Square root of {num3} is: {Math.Sqrt(num3)}");

            // Task 3: Name Formatter
            Console.Write("Enter your full name: ");
            string fullName = Console.ReadLine();

            Console.WriteLine($"Name in uppercase: {fullName.ToUpper()}");
            Console.WriteLine($"Name in lowercase: {fullName.ToLower()}");
            Console.WriteLine($"Characters it contains: {fullName.Length}");

            // Task 4: Subscription End Date
            Console.Write("Enter the number of days of a free taial: ");
            int freeTailDays = int.Parse(Console.ReadLine());

            DateTime currntDate = DateTime.Today;
            DateTime subscriptionDateEnd = currntDate.AddDays(freeTailDays);

            Console.WriteLine($"Your subsciption will end on: {subscriptionDateEnd.ToString("yyyy-MM-dd")}");

            // Task 5: Grade Rounding System
            Console.Write("Enter your grade: ");
            double grade = double.Parse(Console.ReadLine());

            double rounderedGrade = Math.Round(grade);

            Console.WriteLine($"Rounded Grade: {rounderedGrade}");
            if (rounderedGrade >= 60)
            {
                Console.WriteLine("Pass");
            }
            else
            {
                Console.WriteLine("Fail");
            }

            // Task 6:  Password Strength Checker
            Console.Write("Enter your password: ");
            string password = Console.ReadLine();
            password = password.ToLower();

            if (password.Length >= 8 && !password.Contains("password"))
            {
                Console.WriteLine("Strong Password");
            }
            else
            {
                Console.WriteLine("Weak Password");
                if (password.Length < 8)
                {
                    Console.WriteLine("Password should be at least 8 characters long.");
                }
                else
                {
                    Console.WriteLine("Password should not be 'password'.");
                }
            }

            // Task 7: Clean Name Comparator
            Console.Write("Enter first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter secound name: ");
            string secoundName = Console.ReadLine();

            string firstNameCleaned = firstName.Trim().ToLower();
            string secoundNameCleaned = secoundName.Trim().ToLower();

            if (firstNameCleaned == secoundNameCleaned)
            {
                Console.WriteLine("Match");
            }
            else
            {
                Console.WriteLine("No Match");
            }

            // Task 8: Membership Expiry Checker
            try
            {
                Console.Write("Enter membership start date (yyyy-mm-dd): ");
                DateTime startDate = DateTime.Parse(Console.ReadLine());
                Console.Write("Enter number of valid membership days: ");
                int validDays = int.Parse(Console.ReadLine());

                DateTime expiryDate = startDate.AddDays(validDays);

                if (DateTime.Today > expiryDate)
                {
                    Console.WriteLine("Expired");
                    Console.WriteLine($"Membership expires on: {expiryDate.ToString("yyyy-MM-dd")}");
                }
                else
                {
                    Console.WriteLine("Active");
                    Console.WriteLine($"Membership expir on: {expiryDate.ToString("yyyy-MM-dd")}");
                }
            }
            catch
            {
                Console.WriteLine("Invalid date format");
            }
        }
    }
}
