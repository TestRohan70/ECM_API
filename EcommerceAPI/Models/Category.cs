using System;
using System.Collections.Generic;

namespace EcommerceAPI.Models;

public partial class Category
{
    public int Id { get; set; }

    public int StoreId { get; set; }

    public string CategoryName { get; set; } = null!;

    public string? ImageUrl { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedDate { get; set; }
}
