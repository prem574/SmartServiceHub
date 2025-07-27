using SmartServiceHub.Model;
using SmartServiceHub.Repository;

namespace SmartServiceHub.Services
{
    public class ServiceTypeService : IServiceTypeservice

    { 
        private readonly IServiceTypeRepository _serviceTypeRepository;

        public ServiceTypeService(IServiceTypeRepository serviceTypeRepository)
        {
            _serviceTypeRepository = serviceTypeRepository;
        }

        public async Task AddServiceTypeAsync(ServiceType serviceType)
        {
            await _serviceTypeRepository.AddAsync(serviceType);
        }

        public async Task<IEnumerable<ServiceType>> GetAllServiceTypesAsync()
        {
            return await _serviceTypeRepository.GetAllAsync();
        }

        public async Task<ServiceType> GetServiceTypeByIdAsync(int id)
        {
            return await _serviceTypeRepository.GetByIdAsync(id);        }
    }
}
