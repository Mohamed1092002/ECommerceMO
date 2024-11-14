using ECommerce.API.Data.Reposotories.Abstract;
using ECommerce.API.Data.Reposotories.Implementation;
using ECommerce.API.Services.Abstract;

namespace ECommerce.API.Services.Implementation
{
    public class ServiceManager : IServiceManager
    {
        private readonly IRepoManager _repoManager;
        private readonly Lazy<ICategoryManager> _categoryManager;
        private readonly Lazy<IProductManager> _productManager;
        public ServiceManager(IRepoManager repo) 
        {
            _repoManager = repo;
            _categoryManager = new(() => new CategoryManager(repo));
            _productManager = new (()=> new ProductManager(repo));
        }
        public ICategoryManager CategoryManager => _categoryManager.Value;

        public IProductManager ProductManager => _productManager.Value;
    }
}
