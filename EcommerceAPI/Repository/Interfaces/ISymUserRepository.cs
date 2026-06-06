using EcommerceAPI.Models;

namespace EcommerceAPI.Repository.Interfaces
{
    public interface ISymUserRepository
    {
        Task<List<SymUser>> GetAllUsersAsync();
        Task<SymUser?> GetUserByID(int ID);
        Task<SymUser?> ValidateUser(string userName, string password);
    }
}
