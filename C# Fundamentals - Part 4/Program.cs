using System.Security.Cryptography.X509Certificates;

namespace C__Fundamentals___Part_4
{
    internal class Program
    {
        // Task 1: Personalized Welcome Function
        static void PrintWelcome(string user)
        {
            Console.WriteLine($"Hello, {user}");
        }


        // Task 2: Square Number Function
        static int Square(int x)
        {
            return x * x;
        }


        // Task 3: Celsius to Fahrenheit Function
        static double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }
        static void Main(string[] args)
        {
            // Task 1: Personalized Welcome Function
            Console.Write("Enter your name: ");
            string userName = Console.ReadLine();
            PrintWelcome(userName);


            // Task 2: Square Number Function
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine($"The square of {number} is {Square(number)}");

            // Task 3: Celsius to Fahrenheit Function
            Console.Write("Enter temperature in Celsius: ");
            double celsius = double.Parse(Console.ReadLine());

            Console.WriteLine($"{celsius}°C is equal to {CelsiusToFahrenheit(celsius)}°F");
        }
    }
}
