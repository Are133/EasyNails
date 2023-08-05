using EasyNails.Core.CustomEntities;
using EasyNails.Core.Entities;
using EasyNails.Core.QueryFilters;
using System.Threading.Tasks;

namespace EasyNail.Services.Interfaces
{
    public interface IEmployeeService
    {
        PagesList<Employee> GetEmployeesAsync(EmployeeQueryFilter filters);
        Task<Employee> GetEmployeeAsync(int id);
        Task<bool> AddOrUpdatedEmployeeAsync(Employee employee);
        Task<bool> DeleteEmployeeAsync(int id);
    }
}
