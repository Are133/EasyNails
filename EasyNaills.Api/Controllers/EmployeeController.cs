using AutoMapper;
using EasyNail.Services.Interfaces;
using EasyNaills.Api.Responses;
using EasyNails.Core.DTOs;
using EasyNails.Core.Entities;
using EasyNails.Core.QueryFilters;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace EasyNaills.Api.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]

    public class EmployeeController : ControllerBase
    {
        #region Attributtes
        private readonly IEmployeeService _employeeService;
        private readonly IMapper _iMapper;
        #endregion

        #region Builder
        public EmployeeController(IEmployeeService employeeService, IMapper iMapper)
        {
            _employeeService = employeeService;
            _iMapper = iMapper;

        }
        #endregion

        #region PublicMethods
        [HttpGet]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public IActionResult GetEmployees([FromQuery] EmployeeQueryFilter filters)
        {
            var employees = _employeeService.GetEmployeesAsync(filters);
            var employeesDto = _iMapper.Map<IEnumerable<EmployeeDto>>(employees);
            var response = new BaseApiResponse<IEnumerable<EmployeeDto>>(employeesDto);
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetEmployee(int id)
        {
            var employee = await _employeeService.GetEmployeeAsync(id);
            var employeeDto = _iMapper.Map<EmployeeDto>(employee);

            var response = new BaseApiResponse<EmployeeDto>(employeeDto);
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> AddEmployee(EmployeeDto employeeDto)
        {
            var employee = _iMapper.Map<Employee>(employeeDto);
            await _employeeService.AddOrUpdatedEmployeeAsync(employee);
            var response = new BaseApiResponse<EmployeeDto>(employeeDto);
            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateEmployee(int id, EmployeeDto employeeDto)
        {
            var employee = _iMapper.Map<Employee>(employeeDto);
            employee.Id = id;
            var result = await _employeeService.AddOrUpdatedEmployeeAsync(employee);
            var response = new BaseApiResponse<bool>(result);
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmployee(int id)
        {
            var result = await _employeeService.DeleteEmployeeAsync(id);
            var response = new BaseApiResponse<bool>(result);
            return Ok(response);
        }
        #endregion

    }
}
