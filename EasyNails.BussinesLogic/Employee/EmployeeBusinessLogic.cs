using EasyNails.Core.Entities;
using EasyNails.Core.Interfaces;
using System.Threading.Tasks;

namespace EasyNails.BussinesLogic.Employee
{
    public class EmployeeBusinessLogic
    {
        private readonly IEmployeeRepository _employeeRepository;
        public EmployeeBusinessLogic(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        
    }
}
