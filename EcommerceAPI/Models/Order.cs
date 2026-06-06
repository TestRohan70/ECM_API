using System;
using System.Collections.Generic;

namespace EcommerceAPI.Models;

public partial class Order
{
    public int Id { get; set; }

    public int StoreId { get; set; }

    public int? CustomerId { get; set; }

    public string? OrderNo { get; set; }

    public decimal? TotalAmount { get; set; }

    public string? OrderStatus { get; set; }

    public string? PaymentStatus { get; set; }

    public string? PaymentMethod { get; set; }

    public string? ShippingAddress { get; set; }

    public DateTime? CreatedDate { get; set; }
}
