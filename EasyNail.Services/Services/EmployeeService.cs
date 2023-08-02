using EasyNail.Services.Interfaces;
using EasyNails.Core.Entities;
using EasyNails.Core.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EasyNail.Services.Services
{
    public class EmployeeService : IEmployeeService
    {
        #region Atributtes
        private readonly IEmployeeRepository _iEmployeeRepository;
        private readonly IUserRepository _iUserRepository;
        #endregion

        #region Builder
        public EmployeeService(IEmployeeRepository iEmployeeRepository, IUserRepository iUserRepository)
        {
            _iEmployeeRepository = iEmployeeRepository;
            _iUserRepository = iUserRepository;
        }
        #endregion

        #region PublicMethos
        public async Task<bool> AddOrUpdatedEmployeeAsync(Employee employee)
        {
            
            
            //TODO: Validar que el usuario este autorizado y activo para registrar empleados y ademas validar que sea admin
            return await _iEmployeeRepository.AddOrUpdatedEmployeeAsync(employee);
        }

        public async Task<bool> DeleteEmployeeAsync(int id)
        {
            return await _iEmployeeRepository.DeleteEmployeeAsync(id);
        }

        public async Task<Employee> GetEmployeeAsync(int id)
        {
            return await _iEmployeeRepository.GetEmployeeAsync(id);
        }

        public async Task<IEnumerable<Employee>> GetEmployeesAsync()
        {
            return await _iEmployeeRepository.GetEmployeesAsync();
        }
        #endregion
    }
}
