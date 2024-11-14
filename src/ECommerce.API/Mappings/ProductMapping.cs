using ECommerce.API.Data.Models;
using ECommerce.API.Dtos.ProductDto;

namespace ECommerce.API.Mappings
{
    public static class ProductMapping
    {
        public static GetProductDto ToProductDto (this Product product)
        {
            return new GetProductDto
            {
                Id = product.Id,
                Name = product.Name,
                Description = product.Description,
                Price = product.Price,
            };
        }
    }
}
