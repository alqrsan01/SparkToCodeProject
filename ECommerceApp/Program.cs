using ECommerceApp.Models;

namespace ECommerceApp
{
    public class Program
    {
        static ProjectContext context = new ProjectContext();
        static int loggedInUserId = 0;
        static void Main(string[] args)
        {
            bool exitApp = false;
            while (!exitApp)
            {
                Console.WriteLine("\n===== E-Commerce Console App =====");
                Console.WriteLine(" 1. Register New User");
                Console.WriteLine(" 2. Login");
                Console.WriteLine(" 3. Add New Category");
                Console.WriteLine(" 4. Add New Product");
                Console.WriteLine(" 5. View All Products");
                Console.WriteLine(" 6. Place an Order");
                Console.WriteLine(" 7. View My Orders");
                Console.WriteLine(" 8. View Order Details");
                Console.WriteLine(" 9. Add a Review for an Order");
                Console.WriteLine("10. View All Reviews for a Product");
                Console.WriteLine("11. Logout");
                Console.WriteLine(" 0. Exit");
                Console.Write("Enter your choice: ");

                int choice;
                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input. Please enter a number between 0 and 11.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        RegisterUser();
                        break;
                    case 2:
                        Login();
                        break;
                    case 3:
                        AddCategory();
                        break;
                    case 4:
                        AddProduct();
                        break;
                    case 5:
                        ViewAllProducts();
                        break;
                    case 6:
                        PlaceOrder();
                        break;
                    case 7:
                        ViewMyOrders();
                        break;
                    case 8:
                        ViewOrderDetails();
                        break;
                    case 9:
                        AddReview();
                        break;
                    case 10:
                        ViewReviewsForProduct();
                        break;
                    case 11:
                        Logout();
                        break;
                    case 0:
                        exitApp = true;
                        Console.WriteLine("Exiting the application. Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 0 and 11.");
                        break;
                }
            }
        }

        static void RegisterUser()
        {
            User user = new User();
            Console.WriteLine("=====Registration=====");
            Console.Write("Enter your name: ");
            user.Name = Console.ReadLine();
            Console.Write("Enter email address:");
            user.Email = Console.ReadLine();
            Console.Write("Enter password: ");
            user.Password = Console.ReadLine();

            context.Uuser.Add(user);
            context.SaveChanges();

            Console.WriteLine("User registered successfully!");
        }

        static void Login()
        {
            Console.WriteLine("=====Login=====");
            Console.Write("Enter email address: ");
            string email = Console.ReadLine();
            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            User user = context.Uuser.FirstOrDefault(u => u.Email == email && u.Password == password);
            if (user == null)
            {
                Console.WriteLine("Invalid email or password. Please try again.");
            }
            else
            {
                Console.WriteLine("Login successful! Welcome, " + user.Name);
                loggedInUserId = user.UserId;
            }
        }

        static void AddCategory()
        {
            Category category = new Category();
            Console.WriteLine("=====Add New Category=====");
            Console.Write("Enter category name: ");
            category.Name = Console.ReadLine();
            Console.Write("Enter category description: ");
            category.Description = Console.ReadLine();

            context.Ccategory.Add(category);
            context.SaveChanges();

            Console.WriteLine("Category added successfully!");
        }

        static void AddProduct()
        {
        }

        static void ViewAllProducts()
        {
        }

        static void PlaceOrder()
        {
        }

        static void ViewMyOrders()
        {
        }

        static void ViewOrderDetails()
        {
        }

        static void AddReview()
        {
        }

        static void ViewReviewsForProduct()
        {
        }

        static void Logout()
        {
        }
    }
}
