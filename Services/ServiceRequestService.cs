using SmartServiceHub.Model;
using SmartServiceHub.Repository;

namespace SmartServiceHub.Services
{
    public class ServiceRequestService : IServiceRequestService
    {
        private readonly IServiceRequestRepository _serviceRequestRepository;
        public ServiceRequestService(IServiceRequestRepository serviceRequestRepository)
        {
            _serviceRequestRepository = serviceRequestRepository;
        }

        public async Task CreateRequestAsync(ServiceRequest serviceRequest)
        {
            await _serviceRequestRepository.AddAsync(serviceRequest);
            await _serviceRequestRepository.SaveChangesAsync();
        }

        public async Task<IEnumerable<ServiceRequest>> GetAllRequestAsync()
        {
            return await _serviceRequestRepository.GetAllAsync();
        }

        public async Task<ServiceRequest> GetRequestByIdAsync(int id)
        {
           return await _serviceRequestRepository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<ServiceRequest>> GetRequestsbyuserIdAsync(int userId)
        {
            return await _serviceRequestRepository.GetRequestByUserIdAsync(userId);
        }
    }
}
