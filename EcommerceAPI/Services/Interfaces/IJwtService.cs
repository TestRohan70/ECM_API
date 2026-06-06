using EcommerceAPI.Models;

namespace EcommerceAPI.Services.Interfaces
{
    public interface IJwtService
    {
        string GenerateToken(SymUser user);
    }
}
