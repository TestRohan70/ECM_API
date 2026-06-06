namespace EcommerceAPI.DTOs
{
    public class ProductDetailDto
    {
        public int Id { get; set; }

        public string ProductName { get; set; } = string.Empty;

        public string? Description { get; set; }

        public decimal Price { get; set; }

        public decimal? DiscountPrice { get; set; }

        public string? ImageUrl { get; set; }

        public string? Brand { get; set; }
    }
}