using Azure.Core;
using ECommerce.API.Dtos.CategoryDto;
using ECommerce.API.Shared.Paging;
using ECommerce.API.Shared.Parameter;

namespace ECommerce.API.Services.Abstract
{
    public interface ICategoryManager
    {
        IEnumerable<GetCategoryDto> GetCategories();

        void CreateCategory(CreateCategoryDto categoryDto);

        void UpdateCategory(int id, UpdateCategoryDto categoryDto);

        void DeleteCategory(int id);

        GetCategoryDto? GetCategory(int id);
        PagedList<GetCategoryDto> GetCategoryPaged(RequestParameter parameter);
    }
}
