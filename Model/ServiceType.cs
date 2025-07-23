using System.ComponentModel.DataAnnotations;

namespace SmartServiceHub.Model
{
    public class ServiceType
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [MaxLength]
        public string description { get; set; }

        public ICollection<ServiceRequest> ServiceRequests { get; set; }
    }
}
