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
        }
    }
}
