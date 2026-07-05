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
        }
    }
}
