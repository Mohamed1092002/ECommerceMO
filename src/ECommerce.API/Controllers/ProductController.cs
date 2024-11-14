using ECommerce.API.Dtos.ProductDto;
using ECommerce.API.Services.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.API.Controllers
{
    [Route(ApiRoute.ApiRoute.Product.BaseUrl)]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;
        public ProductController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }
        [HttpGet(ApiRoute.ApiRoute.Product.List)]
        public ActionResult<IEnumerable<GetProductDto>> GetAllProducts()
        {
            var res = _serviceManager.ProductManager.GetProducts();
            return Ok(res);
        }
        [HttpGet(ApiRoute.ApiRoute.Product.GetById)]
        public ActionResult GetById(int id)
        {
            var res = _serviceManager.ProductManager.GetProduct(id);
            return Ok(res);
        }
        [HttpPost(ApiRoute.ApiRoute.Product.Create)]
        public ActionResult CreateProduct([FromBody] CreateProductDto productDto)
        {
            _serviceManager.ProductManager.CreateProduct(productDto);
            return Ok();

        }
        [HttpPut(ApiRoute.ApiRoute.Product.Update)]
        public ActionResult UpdateProduct(int id, [FromBody] UpdateProductDto dto)
        {
            _serviceManager.ProductManager.UpdateProduct(id, dto);
            return Ok("Updated Successfully");
        }
        [HttpDelete(ApiRoute.ApiRoute.Product.Delete)]
        public ActionResult DeleteProduct(int id)
        {
            _serviceManager.ProductManager.DeleteProduct(id);
            return Ok();
        }

    }
}
