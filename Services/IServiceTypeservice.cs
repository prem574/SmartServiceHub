using SmartServiceHub.Model;

namespace SmartServiceHub.Services
{
    public interface IServiceTypeservice
    {
        Task<IEnumerable<ServiceType>> GetAllServiceTypesAsync();
        Task<ServiceType> GetServiceTypeByIdAsync(int id);
        Task AddServiceTypeAsync(ServiceType serviceType);
        //Task UpdateServiceTypeAsync(ServiceType serviceType);
        //Task DeleteServiceTypeAsync(int id);
    }
}
