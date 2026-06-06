using System;
using System.Collections.Generic;

namespace EcommerceAPI.Models;

public partial class User
{
    public int Id { get; set; }

    public int StoreId { get; set; }

    public string FullName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string PasswordHash { get; set; } = null!;

    public string? Role { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedDate { get; set; }
}
