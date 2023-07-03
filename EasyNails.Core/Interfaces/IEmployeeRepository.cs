using EasyNails.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EasyNails.Core.Interfaces
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<Employee>> GetEmployees();
    }
}
