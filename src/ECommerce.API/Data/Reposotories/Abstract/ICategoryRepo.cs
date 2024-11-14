using ECommerce.API.Data.Models;

namespace ECommerce.API.Data.Reposotories.Abstract
{
    public interface ICategoryRepo:IRepo<Category>
    {
        IEnumerable<Category> GetCategoriesWithProducts();
    }
}
