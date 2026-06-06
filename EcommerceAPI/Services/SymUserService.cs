using EcommerceAPI.Models;
using EcommerceAPI.Repository.Interfaces;
using EcommerceAPI.Services.Interfaces;

namespace EcommerceAPI.Services
{
    public class SymUserService: ISymUserService
    {
        private readonly ISymUserRepository _repository;
        public SymUserService(ISymUserRepository repo) { 
            _repository = repo;
        }

        public async Task<List<SymUser>> GetAllUsersAsync()
        {
            return await _repository.GetAllUsersAsync();
        }
        public async Task<SymUser> GetUserByID(int ID)
        {
            return await _repository.GetUserByID(ID);
        }

        public async Task<SymUser?> ValidateUser(string userName, string password)
        {
            return await _repository.ValidateUser(userName, password);
        }
    }
}
