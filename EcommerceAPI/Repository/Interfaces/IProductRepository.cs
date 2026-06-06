using EcommerceAPI.DTOs;
using EcommerceAPI.Models;

namespace EcommerceAPI.Repository.Interfaces
{
    public interface IProductRepository
    {
        Task<Product?> GetBySkuAsync(string sku);

        Task<Product?> GetByIdAsync(int id);

        Task<List<Product>> GetAllAsync();

        Task AddProductAsync(Product product);

        Task AddInventoriesAsync(List<ProductInventory> inventories);

        Task AddImagesAsync(List<ProductImage> images);

        Task SaveChangesAsync();
    }
}
