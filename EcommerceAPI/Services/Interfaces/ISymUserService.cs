using EcommerceAPI.Models;

namespace EcommerceAPI.Services.Interfaces
{
    public interface ISymUserService
    {
        Task<List<SymUser>> GetAllUsersAsync();
        Task<SymUser> GetUserByID(int  ID);
        Task<SymUser?> ValidateUser(string userName, string password);

    }
}
