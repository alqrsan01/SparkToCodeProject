namespace C__Fundamentals___Part_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1: Fixed Grades Array
            int[] grades = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Enter grade {i + 1}: ");
                int grade = int.Parse(Console.ReadLine());
                grades[i] = grade;
            }
            foreach (int grade in grades)
            {
                Console.WriteLine($"Grade: {grade}");
            }

            // Task 2: Dynamic To-Do List
            List<string> toDo = new List<string>();
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Enter task number {i + 1}: ");
                string task = Console.ReadLine();
                toDo.Add(task);
            }
            int j = 1;
            foreach (string task in toDo)
            {
                Console.WriteLine($"Task number {j}: {task}");
                j++;
            }

            // Task 3: Browsing History Stack
            Stack<string> browsingHistory = new Stack<string>();
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Enter URL {i + 1}: ");
                string url = Console.ReadLine();
                browsingHistory.Push(url);
            }
            string currentURL = browsingHistory.Pop();

            Console.WriteLine($"Last page: {currentURL}");

            // Task 4: Customer Service Queue
            Queue<string> customers = new Queue<string>();
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Enter customer name {i + 1}: ");
                string customer = Console.ReadLine();
                customers.Enqueue(customer);
            }
            string currentCustomer = customers.Dequeue();

            Console.WriteLine($"Serving customer: {currentCustomer}");

            // Task 5: Array Grade Range
            int[] grades1 = new int[5];
            double sum = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Enter grade {i + 1}: ");
                int grade = int.Parse(Console.ReadLine());
                grades1[i] = grade;
                sum += grade;
            }
            Array.Sort(grades1);
            Console.WriteLine($"Lowest grade: {grades1[0]}");
            Console.WriteLine($"Highest grade: {grades1[grades1.Length - 1]}");
            Console.WriteLine($"Average grade: {sum / 5}");
        }
    }
}
