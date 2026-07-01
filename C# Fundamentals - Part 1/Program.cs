namespace C__Fundamentals___Part_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1
            string name = "Hassan";
            int age = 25;
            double height = 182.0;
            bool student = true;

            Console.WriteLine("Name: " + name + ", Age: " + age + ", Height: " + height + ", Student: " + student);

            // Task 2
            Console.Write("Enter Length: ");
            float length = float.Parse(Console.ReadLine());
            Console.Write("Enter Width: ");
            float width = float.Parse(Console.ReadLine());

            float area = length * width;
            float perimeter = 2 * (length + width);

            Console.WriteLine("Area: " + area);
            Console.WriteLine("Perimeter: " + perimeter);

            // Task 3
            Console.Write("Enetr Number: ");
            int number = int.Parse(Console.ReadLine());

            if ((number % 2) == 0)
            {
                Console.WriteLine("Number is Even");
            }
            else
            {
                Console.WriteLine("Number is Odd");
            }

            // Task 4
            Console.Write("Enter your Grade: ");
            char grade = char.Parse(Console.ReadLine());

            switch (grade)
            {
                case 'A':
                    Console.WriteLine("Excellent");
                    break;
                case 'B':
                    Console.WriteLine("Very Good");
                    break;
                case 'C':
                    Console.WriteLine("Good");
                    break;
                case 'D':
                    Console.WriteLine("Pass");
                    break;
                case 'F':
                    Console.WriteLine("Fail");
                    break;
                default:
                    Console.WriteLine("Invalid Grade");
                    break;
            }
        }
    }
}
