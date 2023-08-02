using EasyNails.Core.Entities;
using EasyNails.Core.Interfaces;
using EasyNails.Infraestructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EasyNails.Infraestructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        #region Attributtes
        private readonly DataContext _dataContext;
        #endregion

        #region Builder
        public UserRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        #endregion

        #region PublicMethods
        public async Task<IEnumerable<User>> GetUsersAsync()
        {
            var users = await _dataContext.Users.ToListAsync();
            return users;
        }

        public async Task<User> GetUserAsync(int id)
        {
            var user = await _dataContext.Users.FirstOrDefaultAsync(em => em.Id == id);
            return user;
        }
        #endregion

    }
}
