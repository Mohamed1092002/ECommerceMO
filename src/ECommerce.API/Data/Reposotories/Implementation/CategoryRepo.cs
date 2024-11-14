using ECommerce.API.Data.Models;
using ECommerce.API.Data.Reposotories.Abstract;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.API.Data.Reposotories.Implementation
{
    public class CategoryRepo:Repo<Category>,ICategoryRepo
    {
        private readonly ECommerceDbContext _context;
        public CategoryRepo(ECommerceDbContext context):base(context) 
        {
            _context = context;
        }

        public IEnumerable<Category> GetCategoriesWithProducts()
        {
            return _context.categories.Include(c => c.Products);
        }
    }
}
