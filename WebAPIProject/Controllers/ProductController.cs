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
    }
}
