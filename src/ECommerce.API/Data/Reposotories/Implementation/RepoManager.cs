using ECommerce.API.Data.Reposotories.Abstract;

namespace ECommerce.API.Data.Reposotories.Implementation
{
    public class RepoManager : IRepoManager
    {
        private readonly ECommerceDbContext _context;
        private readonly Lazy<ICategoryRepo> _categories;
        private readonly Lazy<IProductRepo> _products;

        public RepoManager(ECommerceDbContext context)
        {
            _context = context;
            _categories=new (()=> new CategoryRepo(_context));
            _products=new (()=> new ProductRepo(_context));
        }

        public ICategoryRepo categories => _categories.Value;

        public IProductRepo products => _products.Value;

        public void Dispose()
        {
            _context.Dispose();
        }

        public int? SaveChanges()
        {
            return _context.SaveChanges();
        }
    }
}
