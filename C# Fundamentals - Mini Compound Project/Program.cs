namespace C__Fundamentals___Mini_Compound_Project
{
    internal class Program
    {
        static List<string> customerNames = new List<string>();
        static List<string> accountNumbers = new List<string>();
        static List<double> balances = new List<double>();
        static void Main(string[] args)
        {
            bool exitApp = false;

            while (!exitApp)
            {
                Console.WriteLine("\n===== Welcome to Spark Bank =====");
                Console.WriteLine("1. Add New Account");
                Console.WriteLine("2. Deposit Money");
                Console.WriteLine("3. Withdraw Money");
                Console.WriteLine("4. Show Balance");
                Console.WriteLine("5. Transfer Amount");
                Console.WriteLine("6. <your 1st custom service - choose a name>");
                Console.WriteLine("7. <your 2nd custom service - choose a name>");
                Console.WriteLine("8. Exit");
                Console.Write("Choose an option: ");

                int choice;
                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Invalid input. Please enter a number from 1 to 8.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        AddAccount();
                        break;
                    case 2:
                        DepositMoney();
                        break;
                    case 3:
                        WithdrawMoney();
                        break;
                    case 4:
                        ShowBalance();
                        break;
                    case 5:
                        TransferAmount();
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    case 8:
                        exitApp = true;
                        Console.WriteLine("Thank you for banking with Spark Bank. Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid option, please choose between 1 and 8.");
                        break;
                }
            }
        }
        static void AddAccount()
        {
            Console.Write("Enter customer name: ");
            string customerName = Console.ReadLine();
            Console.Write("Enter account number: ");
            string accountNumber = Console.ReadLine();

            if (accountNumbers.Contains(accountNumber))
            {
                Console.WriteLine("Account number already exists. Please try again.");
                return;
            }
            try
            {
                Console.Write("Enter initial deposit amount: ");
                double initialDeposit = double.Parse(Console.ReadLine());
                if (initialDeposit < 0)
                {
                    Console.WriteLine("Initial deposit cannot be negative. Please try again.");
                    return;
                }
                customerNames.Add(customerName);
                accountNumbers.Add(accountNumber);
                balances.Add(initialDeposit);
                Console.WriteLine("Customer details added successfully");
            }
            catch
            {
                Console.WriteLine("Invalid amount. Please enter a number.");
                return;
            }
        }
        static void DepositMoney()
        {
            Console.Write("Enter account number: ");
            string accountNumber = Console.ReadLine();
            int index = accountNumbers.IndexOf(accountNumber);
            if (index == -1)
            {
                Console.WriteLine("Account number not found. Please try again.");
                return;
            }
            try
            {
                Console.Write("Enter deposit amount: ");
                double depositAmount = double.Parse(Console.ReadLine());
                if (depositAmount < 0)
                {
                    Console.WriteLine("Deposit amount cannot be negative. Please try again.");
                    return;
                }
                balances[index] += depositAmount; 
                Console.WriteLine($"Deposit amount is updated successfully. New balance: {balances[index]}");
            }
            catch
            {
                Console.WriteLine("Invalid amount. Please enter a number.");
                return;
            }
        }
        static void WithdrawMoney()
        {
            // TODO: implement this service (see Section 3 requirements)
        }
        static void ShowBalance()
        {
            // TODO: implement this service (see Section 3 requirements)
        }
        static void TransferAmount()
        {
            // TODO: implement this service (see Section 3 requirements)
        }

    }
}
