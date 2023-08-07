using EasyNails.Core.QueryFilters;
using System;

namespace EasyNails.Infraestructure.Interfaces
{
    public interface IUriService
    {
        Uri GetEmployeePaginationUri(EmployeeQueryFilter filters, string actionUrl);
    }
}
