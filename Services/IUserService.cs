using SmartServiceHub.DTOs;
using SmartServiceHub.Model;

namespace SmartServiceHub.Services
{
    public interface IUserService
    {
        Task<IEnumerable<User>> GetAllUsersAsync();
        Task<User> GetUserByIdAsync(int id);
        Task<UserResponseDto> RegisterUserAsync(UserRegisterDto userDto);
    }
}
