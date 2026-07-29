using WebAPIProject.Models;

namespace WebAPIProject.Controllers
{
    public class CategoryController
    {
        private ProjectContext context;
        public CategoryController(ProjectContext _context)
        {
            context = _context;
        }

        public void AddCategory(Category p)
        {
            context.Categories.Add(p);
            context.SaveChanges();
        }

        public void RemoveCategory(int id)
        {
            Category category = context.Categories.FirstOrDefault(c => c.CategoryId == id);
            if (category == null)
            {

            }
            else
            {
                context.Categories.Remove(category);
                context.SaveChanges();
            }
        }

        public Category GetCategory(int id)
        {
            Category category = context.Categories.FirstOrDefault(c => c.CategoryId == id);
            return category;
        }

        public List<Category> GetAllCategories()
        {
            List<Category> categories = context.Categories.ToList();
            return categories;
        }
    }
}
