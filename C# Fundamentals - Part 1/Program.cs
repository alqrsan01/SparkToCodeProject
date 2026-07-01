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
        }
    }
}
