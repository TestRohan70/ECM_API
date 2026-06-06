using System;
using System.Collections.Generic;

namespace EcommerceAPI.Models;

public partial class ProductImage
{
    public int Id { get; set; }

    public int ProductId { get; set; }

    public string ImageUrl { get; set; } = null!;

    public int? DisplayOrder { get; set; }
}
