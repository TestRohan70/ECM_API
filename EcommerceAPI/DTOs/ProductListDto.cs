namespace EcommerceAPI.DTOs
{
    public class ProductListDto
    {
        public int Id { get; set; }

        public string ProductName { get; set; } = string.Empty;

        public decimal Price { get; set; }

        public string? ImageUrl { get; set; }
    }
}