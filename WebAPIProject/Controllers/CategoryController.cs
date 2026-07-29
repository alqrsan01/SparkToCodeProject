using Microsoft.AspNetCore.Mvc;
using WebAPIProject.Models;

namespace WebAPIProject.Controllers
{
    [ApiController]
    [Route("Category")]
    public class CategoryController : ControllerBase
    {
        private ProjectContext context;
        public CategoryController(ProjectContext _context)
        {
            context = _context;
        }

        [HttpPost("AddCategory")]
        public IActionResult AddCategory(Category c)
        {
            context.Categories.Add(c);
            context.SaveChanges();

            return Ok($"Category added successfully with id: {c.CategoryId}");
        }

        [HttpDelete("RemoveCategory")]
        public IActionResult RemoveCategory(int id)
        {
            Category category = context.Categories.FirstOrDefault(c => c.CategoryId == id);
            if (category == null)
            {
                return NotFound("Category not found");
            }
            else
            {
                context.Categories.Remove(category);
                context.SaveChanges();

                return Ok($"Category with id: {id} removed successfully");
            }
        }

        [HttpGet("GetCategory")]
        public IActionResult GetCategory(int id)
        {
            Category category = context.Categories.FirstOrDefault(c => c.CategoryId == id);
            if (category == null)
            {
                return NotFound("Category not found");
            }
            else
            {
                return Ok(category);
            }
        }

        [HttpGet("GetAllCategories")]
        public IActionResult GetAllCategories()
        {
            List<Category> categories = context.Categories.ToList();
            return Ok(categories);
        }

        
    }
}
