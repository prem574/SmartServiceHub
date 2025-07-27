using SmartServiceHub.Model;

namespace SmartServiceHub.Repository
{
    public interface IServiceRequestRepository : IRepository<ServiceRequest>
    {
        Task<IEnumerable<ServiceRequest>> GetRequestByUserIdAsync(int userId);
    }
}
