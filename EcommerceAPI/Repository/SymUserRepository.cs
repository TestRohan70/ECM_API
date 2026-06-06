
using EcommerceAPI.Models;
using EcommerceAPI.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EcommerceAPI.Repository
{
    public class SymUserRepository:ISymUserRepository
    {
        private readonly EcommerceDbContext _context;

        public SymUserRepository(EcommerceDbContext ctx)        
        {
            _context = ctx;
        }

    
        public async Task<List<SymUser>> GetAllUsersAsync()
        {
            return await _context.SymUsers.ToListAsync();
        }

        public async Task<SymUser?> GetUserByID(int ID)
        {
            return await _context.SymUsers.FindAsync(ID);
        }
        public async Task<SymUser?> ValidateUser(string userName, string password)
        {
            return await _context.SymUsers
                .FirstOrDefaultAsync(x =>
                    x.UserName == userName &&
                    x.Password == password);
        }
    }
}
