using ECommerce.API.Dtos.ProductDto;

namespace ECommerce.API.Services.Abstract
{
    public interface IProductManager
    {
        IEnumerable<GetProductDto> GetProducts();

        void CreateProduct(CreateProductDto productDto);

        void UpdateProduct(int id, UpdateProductDto productDto);

        void DeleteProduct(int id);

        GetProductDto? GetProduct(int id);
    }
}
