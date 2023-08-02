using EasyNails.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EasyNails.Core.Interfaces
{
    public interface IBaseRepository<T> where T : EntityBase
    {
        IEnumerable<T> GetAll();
        Task<T> GetByIdAsync(int id);
        Task SaveAsync(T entity);
        void Update(T entity);
        Task DeleteAsync(int id);
    }
}
