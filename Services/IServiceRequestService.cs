using SmartServiceHub.Model;

namespace SmartServiceHub.Services
{
    public interface IServiceRequestService
    {
        Task<IEnumerable<ServiceRequest>> GetAllRequestAsync();
        Task<IEnumerable<ServiceRequest>> GetRequestsbyuserIdAsync(int userId);

        Task<ServiceRequest> GetRequestByIdAsync(int id);
        Task CreateRequestAsync(ServiceRequest serviceRequest); 

    }
}
