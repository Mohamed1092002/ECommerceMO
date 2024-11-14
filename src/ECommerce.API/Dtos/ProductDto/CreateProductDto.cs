using ECommerce.API.Attributes;
using System.ComponentModel.DataAnnotations;

namespace ECommerce.API.Dtos.ProductDto
{
    public record CreateProductDto
    {
        [MaxLength(50)]
        [Required]
        [IsCapital]
        public string Name { get; set; }
        [MaxLength(200)]
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}
