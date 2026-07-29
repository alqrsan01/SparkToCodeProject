using Microsoft.AspNetCore.Mvc;
using WebAPIProject.Models;

namespace WebAPIProject.Controllers
{
    [ApiController]
    [Route("Product")]
    public class ProductController : ControllerBase
    {
        private ProjectContext context;
        public ProductController(ProjectContext _context)
        {
            context = _context;
        }

        [HttpPost("AddProduct")]
        public IActionResult AddProduct(Product p)
        {
            context.Products.Add(p);
            context.SaveChanges();

            return Ok($"Product added successfully with id: {p.ProductId}"); 
        }

        [HttpDelete("RemoveProduct/{id}")]
        public IActionResult RemoveProduct(int id)
        {
            Product product = context.Products.FirstOrDefault(p => p.ProductId == id);
            if (product == null)
            {
                return NotFound("Product not found");
            }
            else
            {
                context.Products.Remove(product);
                context.SaveChanges();

                return Ok("Product removed successfully");
            }
        }

        [HttpGet("GetProduct/{id}")]
        public IActionResult GetProduct(int id)
        {
            Product product = context.Products.FirstOrDefault(p => p.ProductId == id);
            return Ok(product);
        }

        [HttpGet("GetAllProducts")]
        public IActionResult GetAllProducts()
        {
            List<Product> products = context.Products.ToList();
            return Ok(products);
        }

        [HttpGet("GetByName/{name}")]
        public IActionResult GetByName(string name)
        {
            List<Product> products = context.Products.Where(p => p.ProductName.Contains(name)).ToList();
            return Ok(products);
        }

        [HttpGet("UpdateProduct/{prductId}")]
        public IActionResult UpdateProduct(int id, Product newProduct)
        {
            Product product = context.Products.FirstOrDefault(p => p.ProductId == id);

            if ( product == null) 
            {
                return NotFound("product not found");
            }
            else
            {
                product.ProductName = newProduct.ProductName;
                product.ProductDescription = newProduct.ProductDescription;
                product.ProductPrice = newProduct.ProductPrice;

                context.SaveChanges();
                return Ok("Product updated successfully");  
            }
        }

        [HttpGet("UpdateProductPrice/{productId}")]
        public IActionResult UpdateProductPrice(int id, double newPrice)
        {
            Product product = context.Products.FirstOrDefault(p => p.ProductId == id);
            if (product == null)
            {
                return NotFound("Product not found");
            }
            else
            {
                product.ProductPrice = newPrice;
                context.SaveChanges();

                return Ok("Product price updated successfully");
            }
        }

        [HttpGet("UpdateProductName/{productId}")]
        public IActionResult UpdateProductName(int id, string newName)
        {
            Product product = context.Products.FirstOrDefault(p => p.ProductId == id);
            if (product == null)
            {
                return NotFound("Product not found");
            }
            else
            {
                product.ProductName = newName;
                context.SaveChanges();

                return Ok("Product name updated successfully");
            }
        }
    }
}
