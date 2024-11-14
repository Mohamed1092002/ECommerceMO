namespace ECommerce.API.Services.Abstract
{
    public interface IServiceManager
    {
        ICategoryManager CategoryManager { get; }
        IProductManager ProductManager { get; }
    }
}
