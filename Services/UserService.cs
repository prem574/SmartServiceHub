using AutoMapper;
using SmartServiceHub.DTOs;
using SmartServiceHub.Model;
using SmartServiceHub.Repository;
using BCrypt.Net;




namespace SmartServiceHub.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserService(IUserRepository userRepository , IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<User>> GetAllUsersAsync()
        {
            return await _userRepository.GetAllAsync();
        }

        public async Task<User> GetUserByIdAsync(int id)
        {
            return await _userRepository.GetByIdAsync(id);
        }

        public async Task<UserResponseDto> RegisterUserAsync(UserRegisterDto userDto)
        {
            // check if email is taken or not 
            var existingUser = await _userRepository.GetByEmailAsync(userDto.Email);
            if(existingUser != null)
            {
                throw new Exception("Email is already taken.");
            }

            // Map DTO to entity
            var user = _mapper.Map<User>(userDto);

            //Hash Password
            user.PasswordHash = BCrypt.Net.BCrypt.HashPassword(userDto.Password);

            await _userRepository.AddAsync(user);
            await _userRepository.SaveChangesAsync();

            return _mapper.Map<UserResponseDto>(user);  
        }

        
    }
}
