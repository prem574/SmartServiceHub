using SmartServiceHub.Model;
using System.Globalization;

namespace SmartServiceHub.Repository
{
    public interface IUserRepository: IRepository<User>
    {
        Task<User> GetByEmailAsync(string email);

    }
}
