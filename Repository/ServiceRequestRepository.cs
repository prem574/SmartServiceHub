using Microsoft.EntityFrameworkCore;
using SmartServiceHub.Data;
using SmartServiceHub.Model;

namespace SmartServiceHub.Repository
{
    public class ServiceRequestRepository : GenericRepository<ServiceRequest>, IServiceRequestRepository
    {
        private readonly AppDbContext _context;
        public ServiceRequestRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ServiceRequest>> GetRequestByUserIdAsync(int userId)
        {
            return await _context.ServiceRequests
                .Where(sr => sr.UserId == userId)
                .ToListAsync();
        }
    }
}
