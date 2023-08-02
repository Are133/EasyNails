using EasyNails.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EasyNail.Services.Interfaces
{
    public interface IEmployeeService
    {
        Task<IEnumerable<Employee>> GetEmployeesAsync();
        Task<Employee> GetEmployeeAsync(int id);
        Task<bool> AddOrUpdatedEmployeeAsync(Employee employee);
        Task<bool> DeleteEmployeeAsync(int id);
    }
}
