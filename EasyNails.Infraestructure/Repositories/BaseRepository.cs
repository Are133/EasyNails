using EasyNails.Core.Entities;
using EasyNails.Core.Interfaces;
using EasyNails.Infraestructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyNails.Infraestructure.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : EntityBase
    {
        #region Attributtes
        private readonly DataContext _dataContext;
        private  readonly DbSet<T> _entities;
        #endregion

        #region Builder
        public BaseRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
            _entities = dataContext.Set<T>();   
        }
        #endregion

        #region PublicMethods
        public IEnumerable<T> GetAll()
        {
            return _entities.AsEnumerable();
        }
        public async Task<T> GetByIdAsync(int id)
        {
            return await _entities.FindAsync(id);
        }
        public async Task SaveAsync(T entity)
        {
           await _entities.AddAsync(entity);
        }
        public void Update(T entity)
        {
            _entities.Update(entity);
        }
        public async Task DeleteAsync(int id)
        {
            T entity = await GetByIdAsync(id);
            entity.IsActive = false;
            _entities.Update(entity);
        }
        #endregion

    }
}
