using System;
using System.Collections.Generic;

namespace EcommerceAPI.Models;

public partial class Store
{
    public int Id { get; set; }

    public string StoreName { get; set; } = null!;

    public string? SubDomain { get; set; }

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public string? Address { get; set; }

    public string? LogoUrl { get; set; }

    public string? ThemeColor { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedDate { get; set; }

    public virtual ICollection<ProductInventory> ProductInventories { get; set; } = new List<ProductInventory>();
}
