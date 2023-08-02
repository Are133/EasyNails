using EasyNails.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EasyNails.Core.Interfaces
{
    public interface IUserRepository
    {
        Task<User> GetUserAsync(int id);
        Task<IEnumerable<User>> GetUsersAsync();
    }
}
