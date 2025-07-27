using SmartServiceHub.Data;
using SmartServiceHub.Model;

namespace SmartServiceHub.Repository
{
    public class ServiceTypeRepository : GenericRepository<ServiceType>, IServiceTypeRepository
    {
        public ServiceTypeRepository(AppDbContext context) : base(context)
        {
        }
    }
}
