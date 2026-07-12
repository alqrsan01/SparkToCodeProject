namespace OOP_Part_1
{
    public class BankAccount
    {
        public int AccountNumber { get; set; }
        public string HolderName { get; set; }
        public double Balance { get; set; }
        
        public void Deposit(double amount)
        {

        }
        public void Withdraw(double amount)
        {

        }
        public double CheckBalance()
        {
            return Balance;
        }
        private void PrintInformation()
        {

        }
        private void SendEmail()
        {

        }
    }

    public class Student
    {
        public int Grade { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        private string Email { get; set; }
        int age { get; set; }

        public void Register(string Email)
        {

        }
        private void SendEmail()
        {

        }
    }

    public class Product
    {
        public string ProductName { get; set; }
        public double Price { get; set; }
        public int StockQuantity { get; set; }

        public void Sell(int quantity)
        {

        }
        public void Restock(int quantity)
        {

        }
        public double GetInventoryValue()
        {
            return Price * StockQuantity;
        }
        private void PrintDetails()
        {

        }
        private void LogTransaction()
        {

        }
    }

    public class Program
    {
        static BankAccount account1 = new BankAccount { AccountNumber = 1163, HolderName = "Hassan", Balance = 5000.00 };
        static BankAccount account2 = new BankAccount { AccountNumber = 15203, HolderName = "Ali", Balance = 3000.00 };

        static Student srudent1 = new Student { Name = "Ali", Address = "Muscat", Grade = 65 };
        static Student srudent2 = new Student { Name = "Mohammed", Address = "Salalah", Grade = 75 };

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

        }
        static void UpdateStudentAddress()
        {

        }

        static void MakeDeposit()
        {

        }

        static void MakeWithdrawal()
        {

        }

        static void ViewProductDetails()
        {

        }

        static void RegisterStudent()
        {

        }

        static void CompareAccountBalances()
        {

        }

        static void RestockProduct()
        {

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
