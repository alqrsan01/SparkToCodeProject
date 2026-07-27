using ECommerceApp.Models;
using Microsoft.EntityFrameworkCore;

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
            Product product = new Product();
            Console.WriteLine("=====Add New Product=====");
            Console.Write("Enter product name: ");
            product.ProductName = Console.ReadLine();
            Console.Write("Enter product price: ");
            product.Price = double.Parse(Console.ReadLine());
            Console.Write("Enter product stock: ");
            product.Stock = int.Parse(Console.ReadLine());

            List<Category> allCateg = context.Ccategory.ToList();
            foreach (Category cat in allCateg)
            {
                Console.WriteLine($"Category ID: {cat.CategoryId}, Name: {cat.Name}");
            }

            Console.Write("Pick any category ID: ");
            string categoryId = Console.ReadLine();
            Category category = context.Ccategory.FirstOrDefault(c => c.CategoryId == int.Parse(categoryId));
            if (category == null)
            {
                Console.WriteLine("Category not found. Please add the category first.");
                return;
            }
            product.CategoryId = category.CategoryId;

            context.Product.Add(product);
            context.SaveChanges();

            Console.WriteLine("Product added successfully!");
        }

        static void ViewAllProducts()
        {
            Console.WriteLine("=====All Products=====");
            Console.WriteLine("ID\tName\tPrice\tCategory");
            Console.WriteLine("--------------------------------------------------");
            List<Product> allProducts = context.Product.ToList();
            foreach (Product product in allProducts)
            {
                Category category = context.Ccategory.FirstOrDefault(c => c.CategoryId == product.CategoryId);
                Console.WriteLine($"{product.ProductId}\t{product.ProductName}\t{product.Price}\t{category?.Name}");
            }
            Console.WriteLine("--------------------------------------------------");
        }

        static void PlaceOrder()
        {
            if (loggedInUserId == 0)
            {
                Console.WriteLine("You must be logged in to place an order.");
                return;
            }
            else
            {
                Console.WriteLine("=====Place an Order=====");
                ViewAllProducts();
                
                List<Order_Product> order_Products = new List<Order_Product>();
                while (true)
                {
                    Console.Write("Enter product ID to add to order (or type '0' to finish): ");
                    int productId = int.Parse(Console.ReadLine());
                    Product product = context.Product.FirstOrDefault(p => p.ProductId == productId);
                    if (productId == 0)
                    {
                        Console.WriteLine("Order placement cancelled.");
                        break;
                    }
                    else if (product == null)
                    {
                        Console.WriteLine("Product not found. Please try again.");
                        continue;
                    }
                    else
                    {
                        Console.Write("Enter quantity: ");
                        int quantity = int.Parse(Console.ReadLine());
                        if (quantity <= 0 || quantity > product.Stock)
                        {
                            Console.WriteLine("Invalid quantity. Please try again.");
                            continue;   
                        }
                        Order_Product item = new Order_Product();
                        item.ProductId = productId;
                        item.quantity = quantity;

                        order_Products.Add(item);
                        
                        product.Stock -= quantity;
                    }

                    Order order = new Order();
                    order.OrderDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    order.Status = "Pending";
                    order.UserId = loggedInUserId;
                    order.OrderProducts = order_Products;

                    context.Oorder.Add(order);
                    context.SaveChanges();
                }
            }
        }

        static void ViewMyOrders()
        {
            Console.WriteLine("=====My Orders=====");
            if (loggedInUserId == 0)
            {
                Console.WriteLine("You must be logged in to view your orders.");
                return;
            }
            else
            {
                Console.WriteLine("ID\tDate\t\tStatus");
                List<Order> myOrders = context.Oorder.Where(o => o.UserId == loggedInUserId).ToList();
                Console.WriteLine("--------------------------------------------------");
                foreach (Order order in myOrders)
                {
                    Console.WriteLine($"{order.OrderId}\t{order.OrderDate}\t{order.Status}");
                }
                Console.WriteLine("--------------------------------------------------");
            }
        }

        static void ViewOrderDetails()
        {
            Console.WriteLine("=====Order Details=====");
            Console.Write("Enter order ID to view details: ");
            int orderId = int.Parse(Console.ReadLine());
            Order order = context.Oorder.Include(o => o.OrderProducts).FirstOrDefault(o => o.OrderId == orderId);
            if (order == null)
            {
                Console.WriteLine("Order not found or you do not have permission to view this order.");
                return;
            }
            Console.WriteLine("Product Name\tQuantity\tPrice");
            Console.WriteLine("--------------------------------------------------");
            foreach (Order_Product op in order.OrderProducts)
            {
                Product product = context.Product.FirstOrDefault(p => p.ProductId == op.ProductId);
                Console.WriteLine($"{product.ProductName}\t{op.quantity}\t{product.Price}");
            }
        }

        static void AddReview()
        {
            if (loggedInUserId == 0)
            {
                Console.WriteLine("You must be logged in to add a review.");
                return;
            }
            Console.WriteLine("=====Add a Review=====");    
            Console.Write("Enter order ID to review: ");
            int orderId = int.Parse(Console.ReadLine());
            Order order = context.Oorder.FirstOrDefault(o => o.OrderId == orderId && o.UserId == loggedInUserId);
            if (order == null) 
            { 
                Console.WriteLine("Order not found or you do not have permission to review this order.");
                return;
            }

            Review existing = context.Review.FirstOrDefault(r => r.OrderId == orderId);
            if (existing != null)
            {
                Console.WriteLine("You have already reviewed this order.");
                return;
            }
            Console.Write("Enter your review: ");
            string reviewText = Console.ReadLine();

            Review review = new Review();
            review.OrderId = orderId;
            review.Comment = reviewText;
            review.CreatedAt = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            context.Review.Add(review);
            context.SaveChanges();
        }

        static void ViewReviewsForProduct()
        {
        }

        static void Logout()
        {
            if (loggedInUserId == 0)
            {
                loggedInUserId = 0;
                Console.WriteLine("You have been logged out successfully.");
            }
        }
    }
}
