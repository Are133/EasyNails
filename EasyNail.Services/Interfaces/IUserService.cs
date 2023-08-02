using EasyNails.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EasyNail.Services.Interfaces
{
    public interface IUserService
    {
        Task<User> GetUserAsync(int id);
        Task<IEnumerable<User>> GetUsersAsync();
    }
}
