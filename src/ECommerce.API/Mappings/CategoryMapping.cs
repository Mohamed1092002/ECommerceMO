using ECommerce.API.Data.Models;
using ECommerce.API.Dtos.CategoryDto;

namespace ECommerce.API.Mappings
{
    public static class CategoryMapping
    {
        public static GetCategoryDto ToCategoryDto (this Category category)
        {
            return new GetCategoryDto
            {
                Id = category.Id,
                Description = category.Description,
                Name = category.Name,
            };
        }
    }
}
