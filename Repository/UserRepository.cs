using Microsoft.EntityFrameworkCore;
using SmartServiceHub.Data;
using SmartServiceHub.Model;

namespace SmartServiceHub.Repository
{
    public class UserRepository : GenericRepository<User> , IUserRepository
    {
        private readonly AppDbContext _context;

        public UserRepository(AppDbContext context): base(context)
        {
            _context = context;
        }

        public async Task<User> GetByEmailAsync(string email)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.Email == email);
        }
    }
    
}
