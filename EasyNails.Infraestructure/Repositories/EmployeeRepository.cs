using EasyNails.Core.Entities;
using System.Collections.Generic;
using System.Linq;

namespace EasyNails.Infraestructure.Repositories
{
    public class EmployeeRepository
    {
        public IEnumerable<Employee> GetEmployees()
        {
            var employees = Enumerable.Range(1, 10).Select(e => new Employee
            {
                Id = e,
                Name = e,
                LastName = e
            });

            return employees;
        }
    }
}
