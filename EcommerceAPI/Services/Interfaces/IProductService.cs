using EcommerceAPI.DTOs;
using EcommerceAPI.Models;

namespace EcommerceAPI.Services.Interfaces
{
    public interface IProductService
    {
        Task<int> CreateProductAsync(CreateProductDto dto);

        Task<ProductDetailDto?> GetProductByIdAsync(int id);

        Task<List<ProductListDto>> GetAllProductsAsync();
    }
}
