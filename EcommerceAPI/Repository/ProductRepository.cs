using EcommerceAPI.Models;
using EcommerceAPI.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EcommerceAPI.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly EcommerceDbContext _context;

        public ProductRepository(EcommerceDbContext context)
        {
            _context = context;
        }

        public async Task<Product?> GetBySkuAsync(string sku)
        {
            return await _context.Products
                .FirstOrDefaultAsync(x => x.Sku == sku);
        }

        public async Task<Product?> GetByIdAsync(int id)
        {
            return await _context.Products
                .Include(x => x.ProductInventories)
                .Include(x => x.ProductImages)
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<Product>> GetAllAsync()
        {
            return await _context.Products
                .OrderByDescending(x => x.Id)
                .ToListAsync();
        }

        public async Task AddProductAsync(Product product)
        {
            await _context.Products.AddAsync(product);
        }

        public async Task AddInventoriesAsync(List<ProductInventory> inventories)
        {
            await _context.ProductInventories.AddRangeAsync(inventories);
        }

        public async Task AddImagesAsync(List<ProductImage> images)
        {
            await _context.ProductImages.AddRangeAsync(images);
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}