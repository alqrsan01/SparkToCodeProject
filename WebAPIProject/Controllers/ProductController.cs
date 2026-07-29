using WebAPIProject.Models;

namespace WebAPIProject.Controllers
{
    public class ProductController
    {
        private ProjectContext context;
        public ProductController(ProjectContext _context)
        {
            context = _context;
        }

        public void AddProduct(Product p)
        {
            context.Products.Add(p);
            context.SaveChanges();
        }

        public void RemoveProduct(int id)
        {
            Product product = context.Products.FirstOrDefault(p => p.ProductId == id);
            if (product == null)
            {
                
            }
            else
            {
                context.Products.Remove(product);
                context.SaveChanges();
            }
        }

        public Product GetProduct(int id)
        {
            Product product = context.Products.FirstOrDefault(p => p.ProductId == id);
            return product;
        }

        public List<Product> GetAllProducts()
        {
            List<Product> products = context.Products.ToList();
            return products;
        }

        public List<Product> GetByName(string name)
        {
            List<Product> products = context.Products.Where(p => p.ProductName.Contains(name)).ToList();
            return products;
        } 
    }
}
