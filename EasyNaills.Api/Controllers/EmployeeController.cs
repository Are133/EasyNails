using AutoMapper;
using EasyNaills.Api.Responses;
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
            var employees = await _iEmployeeRepository.GetEmployeesAsync();
            var employeesDto = _iMapper.Map<IEnumerable<EmployeeDto>>(employees);
            var response = new BaseApiResponse<IEnumerable<EmployeeDto>>(employeesDto);
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetEmployee(int id)
        {
            var employee = await _iEmployeeRepository.GetEmployeeAsync(id);
            var employeeDto = _iMapper.Map<EmployeeDto>(employee);
            var response = new BaseApiResponse<EmployeeDto>(employeeDto);
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> AddEmployee(EmployeeDto employeeDto)
        {
            var employee = _iMapper.Map<Employee>(employeeDto);
            await _iEmployeeRepository.AddOrUpdatedEmployeeAsync(employee);
            var response = new BaseApiResponse<EmployeeDto>(employeeDto);
            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateEmployee(int id, EmployeeDto employeeDto)
        {
            var employee = _iMapper.Map<Employee>(employeeDto);
            employee.Id = id;
            var result = await _iEmployeeRepository.AddOrUpdatedEmployeeAsync(employee);
            var response = new BaseApiResponse<bool>(result);
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmployee(int id)
        {
            var result = await _iEmployeeRepository.DeleteEmployeeAsync(id);
            var response = new BaseApiResponse<bool>(result);
            return Ok(response);
        }
        #endregion

    }
}
