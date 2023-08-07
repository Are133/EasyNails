using AutoMapper;
using EasyNail.Services.Interfaces;
using EasyNaills.Api.Responses;
using EasyNails.Core.CustomEntities;
using EasyNails.Core.DTOs;
using EasyNails.Core.Entities;
using EasyNails.Core.QueryFilters;
using EasyNails.Infraestructure.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace EasyNaills.Api.Controllers
{
    [Authorize]
    [Produces("application/json")]
    [Route("api/v1/[controller]")]
    [ApiController]

    public class EmployeeController : ControllerBase
    {
        #region Attributtes
        private readonly IEmployeeService _employeeService;
        private readonly IMapper _iMapper;
        private readonly IUriService _iUriService;
        #endregion

        #region Builder
        public EmployeeController(IEmployeeService employeeService, IMapper iMapper, IUriService uriService)
        {
            _employeeService = employeeService;
            _iMapper = iMapper;
            _iUriService = uriService;
        }
        #endregion

        #region PublicMethods
        /// <summary>
        /// Regresa todos los empleados, con un paginado por default.
        /// Al enviarle los parametros regresara la informacion tal como la pide el cliente
        /// </summary>
        /// <param name="filters">Filtros que resive la funcion</param>
        /// <returns></returns>
        [HttpGet(Name = nameof(GetEmployees))]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(BaseApiResponse<IEnumerable<EmployeeDto>>))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public IActionResult GetEmployees([FromQuery] EmployeeQueryFilter filters)
        {
            var employees = _employeeService.GetEmployeesAsync(filters);
            var employeesDto = _iMapper.Map<IEnumerable<EmployeeDto>>(employees);


            var metadata = new Metadata
            {
                TotalCount = employees.TotalCount,
                PageSize = employees.PageSize,
                CurrentPage = employees.CurrentPage,
                TotalPages = employees.TotalPages,
                HasNextPages = employees.HasNextPage,
                HasPreviusPage = employees.HasPreviusPage,
                NextPageUrl = _iUriService.GetEmployeePaginationUri(filters, Url.RouteUrl(nameof(GetEmployee))).ToString(),
                PreviusPageUrl = _iUriService.GetEmployeePaginationUri(filters, Url.RouteUrl(nameof(GetEmployee))).ToString(),
            };

            var response = new BaseApiResponse<IEnumerable<EmployeeDto>>(employeesDto)
            {
                Meta = metadata
            };

            Response.Headers.Add("X-Pagination", JsonConvert.SerializeObject(metadata));

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
