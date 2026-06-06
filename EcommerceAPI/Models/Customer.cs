using System;
using System.Collections.Generic;

namespace EcommerceAPI.Models;

public partial class Customer
{
    public int Id { get; set; }

    public int StoreId { get; set; }

    public string? FullName { get; set; }

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public string? Address { get; set; }

    public DateTime? CreatedDate { get; set; }
}
