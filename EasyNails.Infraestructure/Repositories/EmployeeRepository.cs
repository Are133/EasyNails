using EasyNails.Core.Entities;
using EasyNails.Core.Interfaces;
using EasyNails.Infraestructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
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
    }
}
