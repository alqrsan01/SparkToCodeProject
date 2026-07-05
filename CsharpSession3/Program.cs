namespace CsharpSession3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // built-in functions

            Math.Cos(90);
            Math.Pow(2, 3);
            Console.WriteLine("Hello");
            Console.Clear();

            double r = Math.Cos(90);
            Console.WriteLine(r);
            Console.WriteLine(Math.Pow(2, 3));

            Console.Write("Enter number: ");
            float userInput = float.Parse(Console.ReadLine());
            double result = Math.Cos(userInput);

            Console.WriteLine(result);
            ///////////////////

            DateTime currentTiming = DateTime.Now;
            Console.WriteLine(currentTiming);

            DateTime timing = DateTime.Today;
            Console.WriteLine(timing);

            DateTime startSubscription = DateTime.Today;
            DateTime endSubscription = startSubscription.AddDays(30);
            Console.WriteLine("Your subscription ends on: " + endSubscription);
            //////////////////

            Console.Write("Enetr a word: ");
            string word = Console.ReadLine();

            int length = word.Length;
            word.Substring(7, 5);
            string upperedWord = word.ToUpper();
            string loweredWord = word.ToLower();
            string name = "Hassan";

            Console.Write("Enter your name: ");
            string name1 = Console.ReadLine();

            if (name1.ToUpper() == name.ToUpper())
            {
                Console.WriteLine("Welcome to application, successfull signed on");
            }
            else
            {
                Console.WriteLine("Invalid name, please try again");
            }

            bool containsResult = word.Contains("hi");
        }
    }
}
