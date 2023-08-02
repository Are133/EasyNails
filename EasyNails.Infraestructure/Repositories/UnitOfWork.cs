using EasyNails.Core.Entities;
using EasyNails.Core.Interfaces;
using EasyNails.Infraestructure.Data;
using System.Threading.Tasks;

namespace EasyNails.Infraestructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        #region Attributtes
        private readonly DataContext _dataContext;
        private readonly IBaseRepository<Employee> _iBaseRepository;
        #endregion

        #region Builder
        public UnitOfWork(DataContext dataContext, IBaseRepository<Employee> iBaseRepository)
        {
            _dataContext = dataContext;
            _iBaseRepository = iBaseRepository;

        }
        #endregion

        #region Properties
        public IBaseRepository<Employee> EmployeeRepository => _iBaseRepository ?? new BaseRepository<Employee>(_dataContext);
        #endregion


        #region PublicMethods
        public void Dispose()
        {
            if (_dataContext != null)
                _dataContext.Dispose();
        }

        public void SaveChanges()
        {
            _dataContext.SaveChanges();
        }

        public async Task SaveChangesAsync()
        {
            await _dataContext.SaveChangesAsync();
        }
        #endregion

    }
}
