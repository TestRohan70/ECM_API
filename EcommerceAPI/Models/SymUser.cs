using System;
using System.Collections.Generic;

namespace EcommerceAPI.Models;

public partial class SymUser
{
    public int Id { get; set; }

    public string? UserName { get; set; }

    public string? Password { get; set; }

    public string Role { get; set; }


}
