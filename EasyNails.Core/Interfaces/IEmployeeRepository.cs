using EasyNails.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EasyNails.Core.Interfaces
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<Employee>> GetEmployees();
        Task<Employee> GetEmployee(int id);
        Task AddEmployee(Employee employee);
    }
}
