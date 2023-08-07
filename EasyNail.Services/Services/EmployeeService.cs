using EasyNail.Services.Interfaces;
using EasyNails.Core.CustomEntities;
using EasyNails.Core.Entities;
using EasyNails.Core.Interfaces;
using EasyNails.Core.QueryFilters;
using EasyNails.Infraestructure.Options;
using Microsoft.Extensions.Options;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EasyNail.Services.Services
{
    public class EmployeeService : IEmployeeService
    {
        #region Atributtes
        private readonly IUnitOfWork _unitOfWork;
        private readonly PaginationOptions _paginationOptions;
        #endregion

        #region Builder
        public EmployeeService(IUnitOfWork unitOfWork, IOptions<PaginationOptions> paginationOptions)
        {
            _unitOfWork = unitOfWork;
            _paginationOptions = paginationOptions.Value;
        }
        #endregion

        #region PublicMethos

        public PagesList<Employee> GetEmployeesAsync(EmployeeQueryFilter filters)
        {
            var employees = _unitOfWork.EmployeeRepository.GetAll();

            filters.PageNumber = filters.PageNumber == 0 ? _paginationOptions.DefaultPageNumbber : filters.PageNumber;
            filters.PageSize = filters.PageSize == 0 ? _paginationOptions.DefaultPageSize : filters.PageSize;

            var pagedEmployees = PagesList<Employee>.Create(employees, filters.PageNumber, filters.PageSize);

            return pagedEmployees;
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
