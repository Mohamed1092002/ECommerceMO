using ECommerce.API.Data.Models;
using ECommerce.API.Data.Reposotories.Abstract;
using ECommerce.API.Dtos.ProductDto;
using ECommerce.API.Mappings;
using ECommerce.API.Services.Abstract;

namespace ECommerce.API.Services.Implementation
{
    public class ProductManager : IProductManager
    {
        private readonly IRepoManager _repoManager;

        public ProductManager(IRepoManager repoManager)
        {
            _repoManager = repoManager;
        }

        public void CreateProduct(CreateProductDto productDto)
        {
            var product = new Product
            {
                Name = productDto.Name,
                Description = productDto.Description,
                Price = productDto.Price,
            };
            _repoManager.products.Create(product);
            var res=_repoManager.SaveChanges();
            if (res == 0)
            {
                throw new Exception("cannot to save");
            }
            
        }

        public void DeleteProduct(int id)
        {
            var product=_repoManager.products.GetById(id);
            if (product == null) 
            {
                throw new Exception("Product doesn't exict");
            }
            _repoManager.products.Delete(product);
            var res = _repoManager.SaveChanges();
            if (res == 0)
            {
                throw new Exception("cannot to save");
            }

        }

        public GetProductDto? GetProduct(int id)
        {
            var category=_repoManager.products.GetById(id);
            return category?.ToProductDto();
        }

        public IEnumerable<GetProductDto> GetProducts()
        {
            var products= _repoManager.products.GetQueryable().Select(x=>x.ToProductDto());
            return products;
        }

        public void UpdateProduct(int id, UpdateProductDto productDto)
        {
            var product = _repoManager.products.GetById(id);
            if (product == null)
            {
                throw new Exception("the product doesn't exict ");
            }
            product.Name = productDto.Name;
            product.Description = productDto.Description;
            product.Price = productDto.Price;
            _repoManager.products.Update(product);
            var res = _repoManager.SaveChanges();
            if (res == 0)
            {
                throw new Exception("cannot to save");
            }
        }
    }
}
