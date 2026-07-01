namespace CsharpSession2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // looping
            // 1- for loop
            // 2- while  loop

            int count = 0;
            for (count = 10; count >= 5; count ++)
            {
                Console.WriteLine("Certain message loop number: " + count);
            }

            bool exitDecision = false;
            string userinput;
            while (exitDecision == false)
            {
                Console.WriteLine("Print Menu");
                Console.Write("Do you want to exit? (y/n)");
                userinput = Console.ReadLine();
                if (userinput == "y")
                {
                    exitDecision = true;
                } 
            }

            bool exitDecision1 = false;
            string userInput1;
            int userChoice;
            do
            {
                Console.WriteLine("Print Menu");
                try
                {
                    Console.WriteLine("Do you want to exit? (1/2)");
                    userChoice = int.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Invalid input. Please wnter a valid number.");
                }
                Console.WriteLine("Do you want to exit (y/n)");
                userInput1 = Console.ReadLine();
                if (userInput1 == "y")
                {
                    exitDecision1 = true;
                }
            } while (exitDecision1 == false);
        }
    }
}
