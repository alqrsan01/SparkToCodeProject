namespace C__Fundamentals___Part_1
{
    internal class Program
    {
        static void Main(string[] args, bool checkId1)
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

            // Task  4
            Console.Write("Enter you age: ");
            int age1 = int.Parse(Console.ReadLine());
            Console.Write("Do yau have valid national ID: (yes/no)");
            string id = Console.ReadLine();

            bool checkId = false;
            if (id == "yes")
            {
                checkId = true;
            }
            else if (id == "no")
            {
                checkId = false;
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }

            if (age1 >= 18 && checkId)
            {
                Console.WriteLine("Eligible");
            }
            else
            {
                Console.WriteLine("Not Eligible");
            }

            // Task 5
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


            // Task 6
            Console.Write("Enter Temperature in Celsius: ");
            float temperature = float.Parse(Console.ReadLine());

            float fahrenheit = (temperature * 9 / 5) + 32;
            Console.WriteLine("Temperature in Fahrenheit: " + fahrenheit);
            if (fahrenheit < 10)
            {
                Console.WriteLine("Cold");
            }
            else if (fahrenheit >= 10 && fahrenheit <= 30)
            {
                Console.WriteLine("Mid");
            }
            else
            {
                Console.WriteLine("Hot");
            }

            // Task 7
            Console.Write("Enter your Age: ");
            int age2 = int.Parse(Console.ReadLine());

            int price = 0;
            string category = "";
            if (age2 <= 12)
            {
                price = 2000;
                category = "Children";
            }
            else if (age2 >= 13 && age2 <= 59)
            {
                price = 5000;
                category = "Adults";
            }
            else
            {
                price = 3000;
                category = "Seniors";
            }

            Console.WriteLine("Category: " + category + ", Price: " + price);

            // Task 8
            Console.Write("Enter total bill amount: ");
            float billAmount = float.Parse(Console.ReadLine());
            Console.Write("Are you loyalty memeber? (yes/no)");
            string loyaltyMember = Console.ReadLine();

            double discount = 0;
            double finalAmount = 0;
            if (billAmount > 20 && loyaltyMember == "yes")
            {
                discount = billAmount * 0.15;
                finalAmount = billAmount - discount;
            }

            Console.WriteLine("Original Bill Amount: " + billAmount);
            Console.WriteLine("Discount: " + discount);
            Console.WriteLine("Final Bill Amount: " + finalAmount);

            // Task 9
            Console.Write("Enter number form 1 to 7: ");
            int day = int.Parse(Console.ReadLine());

            switch (day)
            {
                case 1:
                    Console.WriteLine("Sunday");
                    break;
                case 2:
                    Console.WriteLine("Monday");
                    break;
                case 3:
                    Console.WriteLine("Tuesday");
                    break;
                case 4:
                    Console.WriteLine("Wednesday");
                    break;
                case 5:
                    Console.WriteLine("Thursday");
                    break;
                case 6:
                    Console.WriteLine("Friday");
                    break;
                case 7:
                    Console.WriteLine("Saturday");
                    break;
                default:
                    Console.WriteLine("Invalid day number");
                    break;
            }

            // Task 10
            Console.Write("Enter a number one: ");
            int number1 = int.Parse(Console.ReadLine());
            Console.Write("Enter a number two: ");
            int number2 = int.Parse(Console.ReadLine());
            Console.Write("Enter an operator character (+, -, *, /, %): ");
            char operatorChar = char.Parse(Console.ReadLine());

            switch (operatorChar)
            {
                case '+':
                    Console.WriteLine("Result: " + (number1 + number2));
                    break;
                case '-':
                    Console.WriteLine("Result: " + (number1 - number2));
                    break;
                case '*':
                    Console.WriteLine("Result: " + (number1 * number2));
                    break;
                case '/':
                    if (number2 != 0)
                    {
                        Console.WriteLine("Result: " + (number1 / number2));
                    }
                    else
                    {
                        Console.WriteLine("Error: Division by zero");
                    }
                    break;
                case '%':
                    if (number2 != 0)
                    {
                        Console.WriteLine("Result: " + (number1 % number2));
                    }
                    else
                    {
                        Console.WriteLine("Error: Division by zero");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid operator");
                    break;
            }

            // Task 11
            Console.Write("Enter your age: ");
            int age3 = int.Parse(Console.ReadLine());
            Console.Write("Enter your monthly income: ");
            double income = double.Parse(Console.ReadLine());
            Console.Write("Do you have any exiting loans? (yes/no): ");
            string loans = Console.ReadLine();

            bool haveLoans = false;
            if (loans == "yes")
            {
                haveLoans = true;
            }
            else if (loans == "no")
            {
                haveLoans = false;
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }

            bool eligible = false;
            if ((age3 >= 21 && age3 <= 60) && (income > 400) && !haveLoans)
            {
                eligible = true;
            }
            else
            {
                eligible = false;
            }

            if (eligible)
            {
                Console.WriteLine("Eligible for loan");

            }
            else
            {
                if (age3 < 21 || age3 > 60)
                {
                    Console.WriteLine("Not Eligible for loan due to age");
                }
                else if (income <= 400)
                {
                    Console.WriteLine("Not Eligible for loan due to income");
                }
                else if (haveLoans)
                {
                    Console.WriteLine("Not Eligible for loan due to existing loans");
                }
            }
        }
    }
}
