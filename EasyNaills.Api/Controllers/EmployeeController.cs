using AutoMapper;
using EasyNails.Core.DTOs;
using EasyNails.Core.Entities;
using EasyNails.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EasyNaills.Api.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    
    public class EmployeeController : ControllerBase
    {
        #region Attributtes
        private readonly IEmployeeRepository _iEmployeeRepository;
        private readonly IMapper _iMapper;
        #endregion

        #region Builder
        public EmployeeController(IEmployeeRepository iEmployeeRepository, IMapper iMapper)
        {
            _iEmployeeRepository = iEmployeeRepository;
            _iMapper = iMapper;

        }
        #endregion

        #region PublicMethods
        [HttpGet]
        public async Task<IActionResult> GetEmployees()
        {
            var employees = await _iEmployeeRepository.GetEmployees();
            var employeesDto = _iMapper.Map<IEnumerable<EmployeeDto>>(employees);
            return Ok(employeesDto);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetEmployee(int id)
        {
            var employee = await _iEmployeeRepository.GetEmployee(id);
            var employeeDto = _iMapper.Map<EmployeeDto>(employee);
            return Ok(employeeDto);
        }

        [HttpPost]
        public async Task<IActionResult> AddEmployee(EmployeeDto employeeDto)
        {
            var employee = _iMapper.Map<Employee>(employeeDto);
            await _iEmployeeRepository.AddEmployee(employee);
            return Ok(employee);
        }
        #endregion

    }
}
