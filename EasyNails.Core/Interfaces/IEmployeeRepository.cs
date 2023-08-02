using EasyNails.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EasyNails.Core.Interfaces
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<Employee>> GetEmployeesAsync();
        Task<Employee> GetEmployeeAsync(int id);
        Task<bool> AddOrUpdatedEmployeeAsync(Employee employee);
        Task<bool> DeleteEmployeeAsync(int id);
    }
}
