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


        // Tasl 4: Fixed Menu Display Function
        static void DisplayMenu()
        {
            Console.WriteLine("1) Start");
            Console.WriteLine("2) Help");
            Console.WriteLine("3) Exit");
        }


        // Task 5: Even or Odd Function
        static bool IsEven(int number)
        {
            return number % 2 == 0;
        }


        // Task 6: Rectangle Area & Perimeter Functions
        static double CalculateArea(double length, double width)
        {
            return length * width;
        }
        static double CalculatePerimeter(double length, double width)
        {
            return 2 * (length + width);
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

            // Tasl 4: Fixed Menu Display Function
            DisplayMenu();

            // Task 5: Even or Odd Function
            Console.Write("Enter a number: ");
            int number1 = int.Parse(Console.ReadLine());

            if (IsEven(number1))
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }

            // Task 6: Rectangle Area & Perimeter Functions
            Console.Write("Enter length of the rectangle: ");
            double length = double.Parse(Console.ReadLine());
            Console.Write("Enter width of the rectangle: ");
            double width = double.Parse(Console.ReadLine());

            Console.WriteLine($"Area: {CalculateArea(length, width)}");
            Console.WriteLine($"Perimeter {CalculatePerimeter(length, width)}");
        }
    }
}
