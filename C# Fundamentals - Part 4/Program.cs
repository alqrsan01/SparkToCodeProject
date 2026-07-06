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

        
        // Task 7: Grade Letter Function
        static string GetGradeLetter(int score)
        {
            if (score >= 90)
            {
                return "A";
            }
            else if (score >= 80)
            {
                return "B";
            }
            else if (score >= 70)
            {
                return "C";
            }
            else if (score >= 60)
            {
                return "D";
            }
            else
            {
                return "F";
            }
        }


        // Task 8: Countdown Function
        static void Countdown(int start)
        {
            for (int i = start; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
        }


        // Task 9: Overloaded Multiply Function
        static int Multiply(int a, int b, int c)
        {
            return a * b * c;
        }
        static double Multiply(double a, double b)
        {
            return a * b;
        }
        static int Multiply(int a, int b)
        {
            return a * b;
        }


        // Task 10: Overloaded Area Calculator
        static double CalculateArea1(double length)
        {
            return length * length;
        }
        static double CalculateArea1(double length, double width)
        {
            return width * length;
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

            // Task 7: Grade Letter Function
            Console.Write("Enter your score: ");
            int score = int.Parse(Console.ReadLine());

            Console.WriteLine($"Your grade is: {GetGradeLetter(score)}");

            // Task 8: Countdown Function
            Console.Write("Enter number: ");
            int number2 = int.Parse(Console.ReadLine());

            Countdown(number2);

            // Task 9: Overloaded Multiply Function
            Console.WriteLine("Multiplication of 2 integers: " + Multiply(2, 3));
            Console.WriteLine("Multiplication of 2 doubles: " + Multiply(2.5, 3.5));
            Console.WriteLine("Multiplication of 3 integers: " + Multiply(2, 3, 4));

            // Task 10: Overloaded Area Calculator
            Console.Write("Enter what shape you want (square/rectangle): ");
            string shape = Console.ReadLine().ToLower();

            switch (shape)
            {
                case "square":
                    Console.Write("Enter the side of the square: ");
                    double side = double.Parse(Console.ReadLine());

                    Console.WriteLine($"Area of square: {CalculateArea1(side)}");
                    break;
                case "rectangle":
                    Console.Write("Enter the length of rectangle: ");
                    double length1 = double.Parse(Console.ReadLine());
                    Console.Write("Enter the width of rectangle: ");
                    double width1 = double.Parse(Console.ReadLine());

                    Console.WriteLine($"Area of rectangle: {CalculateArea1(length1, width1)}");
                    break;
                default:
                    Console.WriteLine("Invalid shape");
                    break;
            }


        }
    }
}
