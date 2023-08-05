using System;
using System.Collections.Generic;
using System.Text;

namespace EasyNails.Core.QueryFilters
{
    public class EmployeeQueryFilter
    {
        public int? EmployeeId { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public int PageSize { get; set; }
        public int PageNumber { get; set; }

    }
}
