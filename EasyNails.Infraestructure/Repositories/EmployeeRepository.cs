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
        private readonly DataContext _dataContext;
        public EmployeeRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<IEnumerable<Employee>> GetEmployees()
        {
            var employees = await _dataContext.Employees.ToListAsync();
            return employees;
        }

        public async Task<Employee> GetEmployee(int id)
        {
            Employee employee = await _dataContext.Employees.FirstOrDefaultAsync(em => em.Id == id);
            return employee;
        }

        public async Task AddEmployee(Employee employee)
        {
            _dataContext.Employees.Add(employee);
            await _dataContext.SaveChangesAsync();
        }
    }
}
