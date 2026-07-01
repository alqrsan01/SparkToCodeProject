namespace CsharpSession1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // printing Hello World
            Console.WriteLine("Hello, World!");

            /*
             Data type
            */
            Console.Write("Enter your Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your Age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Enter your Salary: ");
            double salary = double.Parse(Console.ReadLine());

            Console.WriteLine("Your name: " + name + " Age: " + age + " Salary: " + salary);

            // Operators
            Console.Write("Enter first Number: ");
            float firstNumber = float.Parse(Console.ReadLine());
            Console.Write("Enter Second Number: ");
            float secondNumber = float.Parse(Console.ReadLine());

            float additionResult = firstNumber + secondNumber;
            float subtractionResult = firstNumber - secondNumber;
            float multiplicationResult = firstNumber * secondNumber;
            float divisionResult = firstNumber / secondNumber;
            float remiderResult = firstNumber % secondNumber;
            bool comparisionResult = firstNumber == secondNumber;
            bool testResult = !(10 > 5);

            Console.WriteLine("Addition Result: " + additionResult);
            Console.WriteLine("Subtraction Result: " + subtractionResult);
            Console.WriteLine("Muliplicatio Result: " + multiplicationResult);
            Console.WriteLine("Division Result: " + divisionResult);
            Console.WriteLine("Remider Result: " + remiderResult);
            Console.WriteLine("Comparision Result: " + comparisionResult);
            Console.WriteLine("Test Result: " + testResult);


            // Conditional Statemants
            // if-else Statement
            Console.Write("Enter your mark: ");
            float mark = float.Parse(Console.ReadLine());
            
            if (mark >= 0 && mark < 50)
            {
                Console.WriteLine("You Failed");
            }
            else if (mark >= 50 && mark < 60)
            {
                Console.WriteLine("You passed with Grade: D");
            }
            else if (mark >= 70 && mark < 80)
            {
                Console.WriteLine("You passed with Grade: C");
            }
            else if (mark >= 70 && mark < 80)
            {
                Console.WriteLine("You passed with Grade: B");
            }
            else if (mark > 80)
            {
                Console.WriteLine("You passed with Grade: A");
            }
            else
            {
                Console.WriteLine("You entred Invalid Mark");
            }


            // swith-case
            Console.Write("Enter your grade: ");
            char grade = char.Parse(Console.ReadLine());

            switch (grade)
            {
                case 'A':
                    Console.WriteLine("Excellent");
                    break;
                case 'B':
                    Console.WriteLine("Good");
                    break;
                default:
                    Console.WriteLine("Invalid Grade");
                    break;
            }
        }
    }
}