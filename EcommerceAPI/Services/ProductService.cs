using EcommerceAPI.DTOs;
using EcommerceAPI.DTOs.Product;
using EcommerceAPI.Models;
using EcommerceAPI.Repository.Interfaces;
using EcommerceAPI.Services.Interfaces;

namespace EcommerceAPI.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repository;

        public ProductService(IProductRepository repository)
        {
            _repository = repository;
        }

        public async Task<int> CreateProductAsync(CreateProductDto dto)
        {
            if (!string.IsNullOrWhiteSpace(dto.Sku))
            {
                var existingProduct =
                    await _repository.GetBySkuAsync(dto.Sku);

                if (existingProduct != null)
                {
                    throw new Exception("SKU already exists.");
                }
            }

            var product = new Product
            {
                CategoryId = dto.CategoryId,
                ProductName = dto.ProductName,
                Description = dto.Description,
                Brand = dto.Brand,
                Price = dto.Price,
                DiscountPrice = dto.DiscountPrice,
                Weight = dto.Weight,
                Sku = dto.Sku,
                IsFeatured = dto.IsFeatured,
                IsActive = true,
                CreatedDate = DateTime.UtcNow
            };

            await _repository.AddProductAsync(product);

            await _repository.SaveChangesAsync();

            var inventories = dto.Inventories.Select(x =>
                new ProductInventory
                {
                    ProductId = product.Id,
                    StoreId = x.StoreId,
                    StockQty = x.StockQty
                }).ToList();

            var images = dto.Images.Select(x =>
                new ProductImage
                {
                    ProductId = product.Id,
                    ImageUrl = x.ImageUrl,
                    DisplayOrder = x.DisplayOrder
                }).ToList();

            await _repository.AddInventoriesAsync(inventories);

            await _repository.AddImagesAsync(images);

            await _repository.SaveChangesAsync();

            return product.Id;
        }

        public Task<ProductDetailDto?> GetProductByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ProductListDto>> GetAllProductsAsync()
        {
            throw new NotImplementedException();
        }
    }
}