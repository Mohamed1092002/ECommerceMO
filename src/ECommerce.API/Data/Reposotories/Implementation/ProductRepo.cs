using ECommerce.API.Data.Models;
using ECommerce.API.Data.Reposotories.Abstract;

namespace ECommerce.API.Data.Reposotories.Implementation
{
    public class ProductRepo:Repo<Product>,IProductRepo
    {
        private readonly ECommerceDbContext _context;
        public ProductRepo(ECommerceDbContext context):base(context) 
        {
            _context = context;
        }
    }
}
