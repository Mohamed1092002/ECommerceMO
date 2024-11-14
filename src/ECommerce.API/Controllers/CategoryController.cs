using ECommerce.API.Dtos.CategoryDto;
using ECommerce.API.Services.Abstract;
using ECommerce.API.Services.Implementation;
using ECommerce.API.Shared.Paging;
using ECommerce.API.Shared.Parameter;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace ECommerce.API.Controllers
{
    [Route(ApiRoute.ApiRoute.Category.BaseUrl)]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;
        public CategoryController(IServiceManager serviceManager)

        {
            _serviceManager = serviceManager;
        }
        [HttpGet(ApiRoute.ApiRoute.Category.List)]
        public ActionResult<IEnumerable<GetCategoryDto>> GetAllCategories()
        {
            var res = _serviceManager.CategoryManager.GetCategories();
            return Ok(res);
        }
        [HttpGet(ApiRoute.ApiRoute.Category.GetById)]
        public ActionResult GetCategoryById(int id) 
        {
            var res=_serviceManager.CategoryManager.GetCategory(id);
            return Ok(res);
        }
        [HttpGet("paged")]
        public ActionResult<PagedList<GetCategoryDto>> GetAllCategories([FromQuery] RequestParameter parameter)
        {
            var result = _serviceManager.CategoryManager.GetCategoryPaged(parameter);
            var metadata = result.MetaData;
            HttpContext.Response.Headers.Add("X-Pagination", JsonSerializer.Serialize(metadata));
            return Ok(result);
        }
        [HttpPost(ApiRoute.ApiRoute.Category.Create)]
        public ActionResult CreateCategory([FromBody] CreateCategoryDto categoryDto) 
        {
             _serviceManager.CategoryManager.CreateCategory( categoryDto);
            return Ok();
            
        }
        [HttpPut(ApiRoute.ApiRoute.Category.Update)]
        public ActionResult UpdateCategory(int id, [FromBody] UpdateCategoryDto dto)
        {
            _serviceManager.CategoryManager.UpdateCategory(id, dto);
            return Ok("Updated Successfully");
        }
        [HttpDelete(ApiRoute.ApiRoute.Category.Delete)]
        public ActionResult DeleteCategory(int id) 
        {
            _serviceManager.CategoryManager.DeleteCategory(id);
            return Ok();
        }

    }
}

