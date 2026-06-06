using System;
using System.Collections.Generic;

namespace EcommerceAPI.Models;

public partial class Cart
{
    public int Id { get; set; }

    public int StoreId { get; set; }

    public int? CustomerId { get; set; }

    public DateTime? CreatedDate { get; set; }
}
