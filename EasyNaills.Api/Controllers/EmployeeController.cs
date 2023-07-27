using EasyNails.Core.Entities;
using EasyNails.Core.Interfaces;
using EasyNails.Infraestructure.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace EasyNaills.Api.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository _iEmployeeRepository;
        public EmployeeController(IEmployeeRepository iEmployeeRepository)
        {
            _iEmployeeRepository = iEmployeeRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetEmployees()
        {
            var employees = await _iEmployeeRepository.GetEmployees();

            return Ok(employees);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetEmployee(int id)
        {
            var employees = await _iEmployeeRepository.GetEmployee(id);

            return Ok(employees);
        }

        [HttpPost]
        public async Task<IActionResult> AddEmployee(Employee employee)
        {
             await _iEmployeeRepository.AddEmployee(employee);

            return Ok(employee);
        }
    }
}
