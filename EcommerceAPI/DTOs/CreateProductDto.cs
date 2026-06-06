namespace EcommerceAPI.DTOs
{
    public class CreateProductDto
    {
        public int CategoryId { get; set; }

        public string ProductName { get; set; } = string.Empty;

        public string? Description { get; set; }

        public string? Brand { get; set; }

        public decimal Price { get; set; }

        public decimal? DiscountPrice { get; set; }

        public decimal? Weight { get; set; }

        public string? Sku { get; set; }

        public bool IsFeatured { get; set; }

        public List<ProductInventoryDto> Inventories { get; set; } = [];

        public List<string> Images { get; set; } = [];
    }
}
