using System;
using System.Collections.Generic;

namespace EcommerceAPI.Models;

public partial class ProductInventory
{
    public int Id { get; set; }

    public int ProductId { get; set; }

    public int StoreId { get; set; }

    public int StockQty { get; set; }

    public DateTime CreatedDate { get; set; }

    public virtual Product Product { get; set; } = null!;

    public virtual Store Store { get; set; } = null!;
}
