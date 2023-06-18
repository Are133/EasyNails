using EasyNails.Infraestructure.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EasyNaills.Api.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        public IActionResult Get()
        {
            EmployeeRepository employeeRepository = new EmployeeRepository();

            return Ok(employeeRepository.GetEmployees());
        }
    }
}
