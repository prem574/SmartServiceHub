using System.ComponentModel.DataAnnotations;

namespace SmartServiceHub.Model
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string FullName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string PasswordHash { get; set; }

        [Required]
        public string Role { get; set; }

        public ICollection<ServiceRequest> ServiceRequests { get; set; }


    }
}
