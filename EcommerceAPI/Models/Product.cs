using System;
using System.Collections.Generic;

namespace EcommerceAPI.Models;

public partial class Product
{
    public int Id { get; set; }

    public int? CategoryId { get; set; }

    public string ProductName { get; set; } = null!;

    public string? Slug { get; set; }

    public string? Description { get; set; }

    public decimal Price { get; set; }

    public decimal? DiscountPrice { get; set; }

    public string? Sku { get; set; }

    public string? ImageUrl { get; set; }

    public bool? IsFeatured { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? Brand { get; set; }

    public decimal? Weight { get; set; }

    public bool IsDeleted { get; set; }

    public virtual ICollection<ProductInventory> ProductInventories { get; set; } = new List<ProductInventory>();
}
