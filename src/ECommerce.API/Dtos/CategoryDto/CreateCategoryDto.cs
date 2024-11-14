using ECommerce.API.Attributes;
using System.ComponentModel.DataAnnotations;

namespace ECommerce.API.Dtos.CategoryDto
{
    public record CreateCategoryDto : ICommandDto
    {
        [MaxLength(50)]
        [Required]
        [IsCapital]
        public string Name { get; init; }

        [MaxLength(200)]
        public string? Description { get; init; }
    }
}
