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
        }
    }
}
