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
        public async Task<IActionResult> Get()
        {
            var employees = await _iEmployeeRepository.GetEmployees();

            return Ok(employees);
        }
    }
}
