using System.ComponentModel.DataAnnotations;

namespace SmartServiceHub.Model
{
    public class ServiceRequest
    {
        public int Id { get; set; }

        [Required]
        public string  Description { get; set; }
        public DateTime CreatedAt { get; set; }

        [MaxLength(50)]
        public string Status { get; set; } // eg . "Pending , "resloved" , "Inprocess"

        public int UserId { get; set; }
        public User User { get; set; }

        public int ServiceTypeId { get; set; }
        public ServiceType ServiceType { get; set; }

    }
}
