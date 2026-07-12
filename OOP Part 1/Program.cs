namespace OOP_Part_1
{
    public class BankAccount
    {
        public int AccountNumber { get; set; }
        public string HolderName { get; set; }
        public double Balance { get; set; }
        
        public void Deposit(double amount)
        {
            Balance += amount;
            SendEmail();
        }
        public void Withdraw(double amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                SendEmail();
            }
        }
        public double CheckBalance()
        {
            PrintInformation();
            return Balance;
        }
        private void PrintInformation()
        {
            Console.WriteLine($"Holder Name: {HolderName}");
            Console.WriteLine($"Balance: {Balance}");
        }
        private void SendEmail()
        {
            Console.WriteLine("Email notification sent.");
        }
    }

    public class Student
    {
        public int Grade { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        private string Email { get; set; }
        int Age { get; set; }

        public void Register(string email)
        {
            this.Email = email;
            SendEmail();
        }
        private void SendEmail()
        {
            Console.WriteLine("Email notification sent.");
        }
    }

    public class Product
    {
        public string ProductName { get; set; }
        public double Price { get; set; }
        public int StockQuantity { get; set; }

        public void Sell(int quantity)
        {
            if (StockQuantity >= quantity)
            {
                StockQuantity -= quantity;
            }
            else
            {
                Console.WriteLine("not enough stock");
            }
            LogTransaction();
        }
        public void Restock(int quantity)
        {
            StockQuantity += quantity;
            LogTransaction();
        }
        public double GetInventoryValue()
        {
            PrintDetails();
            return Price * StockQuantity;
        }
        private void PrintDetails()
        {
            Console.WriteLine($"Product Name: {ProductName}");
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine($"Stock Quantity: {StockQuantity}");
        }
        private void LogTransaction()
        {
            Console.WriteLine("Transaction logged.");
        }
    }

    public class Program
    {
        static BankAccount account1 = new BankAccount { AccountNumber = 1163, HolderName = "Hassan", Balance = 5000.00 };
        static BankAccount account2 = new BankAccount { AccountNumber = 15203, HolderName = "Ali", Balance = 3000.00 };

        static Student student1 = new Student { Name = "Ali", Address = "Muscat", Grade = 65 };
        static Student student2 = new Student { Name = "Mohammed", Address = "Salalah", Grade = 75 };

        static Product product1 = new Product { ProductName = "Laptop", Price = 1000.00, StockQuantity = 10 };
        static Product product2 = new Product { ProductName = "Smartphone", Price = 500.00, StockQuantity = 20 };
        static void Main(string[] args)
        {
            bool exitApp = false;

            while (exitApp == false)
            {
                Console.WriteLine("\n===== OOP Part 1 - Bank / Student / Product Manager =====");
                Console.WriteLine(" 1. View Account Details");
                Console.WriteLine(" 2. Update Student Address");
                Console.WriteLine(" 3. Make a Deposit");
                Console.WriteLine(" 4. Make a Withdrawal");
                Console.WriteLine(" 5. View Product Details");
                Console.WriteLine(" 6. Register a Student");
                Console.WriteLine(" 7. Compare Two Account Balances");
                Console.WriteLine(" 8. Restock Product & Stock Level Check");
                Console.WriteLine(" 9. Transfer Between Accounts");
                Console.WriteLine("10. Update Student Grade (Validated)");
                Console.WriteLine("11. Student Report Card");
                Console.WriteLine("12. Account Health Status");
                Console.WriteLine("13. Bulk Sale With Revenue Calculation");
                Console.WriteLine("14. Scholarship Eligibility Check");
                Console.WriteLine("15. Full Balance Top-Up Flow");
                Console.WriteLine("16. Quick Account Opening (Parameterized Constructor)");
                Console.WriteLine("17. Total Students Counter (Static Field & Method)");
                Console.WriteLine("18. Overdrawn Account Check (Read-Only Property)");
                Console.WriteLine("19. Set Student Security PIN (Write-Only Property)");
                Console.WriteLine("20. Exit");
                Console.Write("Choose an option: ");

                int choice;
                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input. Please enter a number from 1 to 20.");
                    continue;
                }

                switch (choice)
                {
                    case 1: ViewAccountDetails(); break;
                    case 2: UpdateStudentAddress(); break;
                    case 3: MakeDeposit(); break;
                    case 4: MakeWithdrawal(); break;
                    case 5: ViewProductDetails(); break;
                    case 6: RegisterStudent(); break;
                    case 7: CompareAccountBalances(); break;
                    case 8: RestockProduct(); break;
                    case 9: TransferBetweenAccounts(); break;
                    case 10: UpdateStudentGrade(); break;
                    case 11: StudentReportCard(); break;
                    case 12: AccountHealthStatus(); break;
                    case 13: BulkSaleWithRevenue(); break;
                    case 14: ScholarshipEligibilityCheck(); break;
                    case 15: FullBalanceTopUpFlow(); break;
                    case 16: QuickAccountOpening(); break;
                    case 17: TotalStudentsCounter(); break;
                    case 18: OverdrawnAccountCheck(); break;
                    case 19: SetStudentSecurityPin(); break;
                    case 20:
                        exitApp = true;
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid option, please choose between 1 and 20.");
                        break;
                }
            }
        }
        static void ViewAccountDetails()
        {
            Console.Write("Pick one account to view details(1, 2): ");
            try
            {
                int accountChoice = int.Parse(Console.ReadLine());
                if (accountChoice == 1)
                {
                    account1.CheckBalance();
                }
                else if (accountChoice == 2) 
                {
                    account2.CheckBalance();
                }
                else
                {
                    Console.WriteLine("Invalid account choice. Please enter 1 or 2.");
                }
            } 
            catch
            {
                Console.WriteLine("Invalid input. Please enter 1 or 2.");
            }
        }
        static void UpdateStudentAddress()
        {
            Console.Write("Pick one student to update address(1, 2): ");
            try
            {
                int studentChoice = int.Parse(Console.ReadLine());
                if (studentChoice == 1)
                {
                    Console.Write("Enter new address for student 1: ");
                    string newAddress = Console.ReadLine();
                    student1.Address = newAddress;
                    Console.WriteLine($"Address updated successfully. New Address: {student1.Address}");
                }
                else if (studentChoice == 2)
                {
                    Console.Write("Enter new address for student 2: ");
                    string newAddress = Console.ReadLine();
                    student2.Address = newAddress;
                    Console.WriteLine($"Address updated successfully. New Address: {student2.Address}");
                }
                else
                {
                    Console.WriteLine("Invalid student choice. Please enter 1 or 2.");
                }
            }
            catch
            {
                Console.WriteLine("Invalid input. Please enter 1 or 2.");
            }
        }

        static void MakeDeposit()
        {
            Console.Write("Pick one account to make a deposit(1, 2): ");
            try
            {
                int accountChoice = int.Parse(Console.ReadLine());
                if (accountChoice == 1)
                {
                    Console.Write("Enter deposit amount for account 1: ");
                    double amount = double.Parse(Console.ReadLine());
                    account1.Deposit(amount);
                    account1.CheckBalance();
                }
                else if (accountChoice == 2)
                {
                    Console.Write("Enter deposit amount for account 2: ");
                    double amount = double.Parse(Console.ReadLine());
                    account2.Deposit(amount);
                    account2.CheckBalance();
                }
                else
                {
                    Console.WriteLine("Invalid account choice. Please enter 1 or 2.");
                }
            }
            catch
            {
                Console.WriteLine("Invalid input. Please enter 1 or 2.");
            }
        }

        static void MakeWithdrawal()
        {
            Console.Write("Pick one account to make a withdrawal(1, 2): ");
            try
            {
                int accountChoice = int.Parse(Console.ReadLine());
                if (accountChoice == 1)
                {
                    Console.Write("Enter withdrawal amount for account 1: ");
                    double amount = double.Parse(Console.ReadLine());
                    account1.Withdraw(amount);
                    account1.CheckBalance();
                }
                else if (accountChoice == 2)
                {
                    Console.Write("Enter withdrawal amount for account 2: ");
                    double amount = double.Parse(Console.ReadLine());
                    account2.Withdraw(amount);
                    account2.CheckBalance();
                }
                else
                {
                    Console.WriteLine("Invalid account choice. Please enter 1 or 2.");
                }
            }
            catch
            {
                Console.WriteLine("Invalid input. Please enter 1 or 2.");
            }
        }

        static void ViewProductDetails()
        {
            Console.Write("Pick one product to view details(1, 2): ");
            try
            {
                int productChoice = int.Parse(Console.ReadLine());
                if (productChoice == 1)
                {
                    product1.GetInventoryValue();
                }
                else if (productChoice == 2)
                {
                    product2.GetInventoryValue();
                }
                else
                {
                    Console.WriteLine("Invalid product choice. Please enter 1 or 2.");
                }
            }
            catch
            {
                Console.WriteLine("Invalid input. Please enter 1 or 2.");
            }
        }

        static void RegisterStudent()
        {
            Console.Write("Pick one student to register(1, 2): ");
            try
            {
                int studentChoice = int.Parse(Console.ReadLine());
                if (studentChoice == 1)
                {
                    Console.Write("Enter email for student 1: ");
                    string studentEmail = Console.ReadLine();
                    student1.Register(studentEmail);
                }
                else if (studentChoice == 2)
                {
                    Console.Write("Enter email for student 2: ");
                    string studentEmail = Console.ReadLine();
                    student2.Register(studentEmail);
                }
                else
                {
                    Console.WriteLine("Invalid student choice. Please enter 1 or 2.");
                }
            }
            catch
            {
                Console.WriteLine("Invalid input. Please enter 1 or 2.");
            }
        }

        static void CompareAccountBalances()
        {
            double balance1 = account1.Balance;
            double balance2 = account2.Balance;
            if (balance1 == balance2)
            {
                Console.WriteLine("Both accounts have same balance.");
            }
            else if (balance1 > balance2)
            {
                Console.WriteLine("Account 1 has a higher balance.");
            }
            else
            {
                Console.WriteLine("Account 2 has a higher balance.");
            }
        }

        static void RestockProduct()
        {
            Console.Write("Pick one product to restock(1, 2): ");
            try
            {
                int productChoice = int.Parse(Console.ReadLine());
                if (productChoice == 1)
                {
                    Console.Write("Enter quantity to restock: ");
                    int quantity = int.Parse(Console.ReadLine());
                    product1.Restock(quantity);
                    int currentStock = product1.StockQuantity;
                    if (currentStock < 10)
                    {
                        Console.WriteLine("Low");
                    }
                    else if (currentStock >= 10 && currentStock < 50)
                    {
                        Console.WriteLine("Moderate");
                    }
                    else
                    {
                        Console.WriteLine("Well Stocked");
                    }
                }
                else if (productChoice == 2)
                {
                    Console.Write("Enter quantity to restock: ");
                    int quantity = int.Parse(Console.ReadLine());
                    product2.Restock(quantity);
                    int currentStock = product2.StockQuantity;
                    if (currentStock < 10)
                    {
                        Console.WriteLine("Low");
                    }
                    else if (currentStock >= 10 && currentStock < 50)
                    {
                        Console.WriteLine("Moderate");
                    }
                    else
                    {
                        Console.WriteLine("Well Stocked");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid product choice. Please enter 1 or 2.");
                }
            }
            catch
            {
                Console.WriteLine("Invalid input. Please enter 1 or 2.");
            }
        }

        static void TransferBetweenAccounts()
        {

        }

        static void UpdateStudentGrade()
        {

        }

        static void StudentReportCard()
        {

        }

        static void AccountHealthStatus()
        {

        }

        static void BulkSaleWithRevenue()
        {

        }

        static void ScholarshipEligibilityCheck()
        {

        }

        static void FullBalanceTopUpFlow()
        {

        }

        static void QuickAccountOpening()
        {

        }

        static void TotalStudentsCounter()
        {

        }

        static void OverdrawnAccountCheck()
        {

        }

        static void SetStudentSecurityPin()
        {

        }
    }
}
