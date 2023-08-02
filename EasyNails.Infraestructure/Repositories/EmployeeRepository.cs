using EasyNails.Core.Entities;
using EasyNails.Core.Interfaces;
using EasyNails.Infraestructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EasyNails.Infraestructure.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        #region Attributes
        private readonly DataContext _dataContext;
        #endregion

        #region Builder
        public EmployeeRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        #endregion


        #region Properties

        #endregion

        #region PrivateMethods

        #endregion

        #region PublicMethods
        public async Task<IEnumerable<Employee>> GetEmployeesAsync()
        {
            var employees = await _dataContext.Employees.ToListAsync();
            return employees;
        }

        public async Task<Employee> GetEmployeeAsync(int id)
        {
            Employee employee = await _dataContext.Employees.FirstOrDefaultAsync(em => em.Id == id);
            return employee;
        }

        public async Task<bool> AddOrUpdatedEmployeeAsync(Employee employee)
        {
            if (employee.Id is 0)
            {
                _dataContext.Employees.Add(employee);
                await _dataContext.SaveChangesAsync();
                return true;
            }
            else
            {
                var currentEmployee = await GetEmployeeAsync(employee.Id);
                //TODO: Agregar el resto de campos a actualizar.
                currentEmployee.FirstName = employee.FirstName;
                _dataContext.Employees.Update(currentEmployee);
                int rows = await _dataContext.SaveChangesAsync();
                return rows > 0;
            }

        }

        public async Task<bool> DeleteEmployeeAsync(int id)
        {
            var currentEmployee = await GetEmployeeAsync(id);
            currentEmployee.IsActive = false;
            _dataContext.Employees.Update(currentEmployee);
            int rows = await _dataContext.SaveChangesAsync();
            return rows > 0;
        }
        #endregion



    }
}
