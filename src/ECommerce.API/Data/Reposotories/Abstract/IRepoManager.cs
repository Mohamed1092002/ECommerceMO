namespace ECommerce.API.Data.Reposotories.Abstract
{
    public interface IRepoManager:IDisposable
    {
        int? SaveChanges();
        ICategoryRepo categories { get; }
        IProductRepo products { get; }
    }
}
