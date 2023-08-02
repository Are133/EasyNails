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
        private readonly IUnitOfWork _unitOfWork;
        #endregion

        #region Builder
        public EmployeeService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        #endregion

        #region PublicMethos

        public IEnumerable<Employee> GetEmployeesAsync()
        {
            return _unitOfWork.EmployeeRepository.GetAll();
        }

        public async Task<Employee> GetEmployeeAsync(int id)
        {
            return await _unitOfWork.EmployeeRepository.GetByIdAsync(id);
        }

        public async Task<bool> AddOrUpdatedEmployeeAsync(Employee employee)
        {
            //TODO: Validar que el usuario este autorizado y activo para registrar empleados y ademas validar que sea admin
            if(employee.Id is 0)
            {
                await _unitOfWork.EmployeeRepository.SaveAsync(employee);
                return true;
            }
            else
            {
                _unitOfWork.EmployeeRepository.Update(employee);
                await _unitOfWork.SaveChangesAsync();
                return true;
            }
        }

        public async Task<bool> DeleteEmployeeAsync(int id)
        {
            await _unitOfWork.EmployeeRepository.DeleteAsync(id);
            return true;
        }
        #endregion
    }
}
