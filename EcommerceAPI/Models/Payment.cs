using System;
using System.Collections.Generic;

namespace EcommerceAPI.Models;

public partial class Payment
{
    public int Id { get; set; }

    public int OrderId { get; set; }

    public string? PaymentGateway { get; set; }

    public string? TransactionId { get; set; }

    public decimal? Amount { get; set; }

    public string? PaymentStatus { get; set; }

    public DateTime? CreatedDate { get; set; }
}
