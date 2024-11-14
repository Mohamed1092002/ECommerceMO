namespace ECommerce.API.Dtos.CategoryDto
{
    public record GetCategoryDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
    }
}
