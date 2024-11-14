using ECommerce.API.Data.Models;
using ECommerce.API.Data.Reposotories.Abstract;
using ECommerce.API.Dtos.CategoryDto;
using ECommerce.API.Mappings;
using ECommerce.API.Services.Abstract;
using ECommerce.API.Shared.Paging;
using ECommerce.API.Shared.Parameter;

namespace ECommerce.API.Services.Implementation
{
    public class CategoryManager : ICategoryManager
    {
        private readonly IRepoManager _repoManager;
        public CategoryManager(IRepoManager repoManager) 
        {
            _repoManager = repoManager;
        }
        public void CreateCategory(CreateCategoryDto categoryDto)
        {
            var category = new Category
            {
                Name = categoryDto.Name,
                Description = categoryDto.Description
            };
            _repoManager.categories.Create(category);
            var res=_repoManager.SaveChanges();
            if (res == 0)
            {
                throw new Exception("Failed to create Category");
            }
        }
     

        public void DeleteCategory(int id)
        {
            var category=_repoManager.categories.GetById(id);
            if (category is null) 
            {
                throw new Exception("Category does not exict");
            }
            _repoManager.categories.Delete(category);
            var res = _repoManager.SaveChanges();
            if (res == 0)
            {
                throw new Exception("Failed to create Category");
            }
        }

        public IEnumerable<GetCategoryDto> GetCategories()
        {
            var categories=_repoManager.categories.GetQueryable().Select(x=>x.ToCategoryDto());
            return categories;
        }

        public GetCategoryDto? GetCategory(int id)
        {
            var category = _repoManager.categories.GetById(id);
            return category?.ToCategoryDto();
        }

        public void UpdateCategory(int id, UpdateCategoryDto categoryDto)
        {
            var category = _repoManager.categories.GetById(id);
            if (category is null) 
            {
                throw new Exception("Category doesn't Exict");
            }
            category.Name = categoryDto.Name;
            category.Description = categoryDto.Description;
            _repoManager.categories.Update(category);
            var res = _repoManager.SaveChanges();
            if (res == 0)
            {
                throw new Exception("Failed to create Category");
            }

        }

        public PagedList<GetCategoryDto> GetCategoryPaged(RequestParameter parameter)
        {
            var categories = _repoManager.categories.GetQueryable();

            var pagedCategories = categories
                .OrderBy(x => x.Name)
                .Skip((parameter.PageNumber - 1) * parameter.PageSize)
                .Take(parameter.PageSize)
                .Select(x => x.ToCategoryDto());

            var count = categories.Count();

            return PagedList<GetCategoryDto>.ToPagedList(pagedCategories.ToList(), parameter.PageNumber, parameter.PageSize, count);
        }
    }
}
