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
        }
    }
}
