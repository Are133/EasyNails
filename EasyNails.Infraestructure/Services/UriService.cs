using EasyNails.Core.QueryFilters;
using EasyNails.Infraestructure.Interfaces;
using System;

namespace EasyNails.Infraestructure.Services
{
    public class UriService : IUriService
    {
        private readonly string _baseUri;
        public UriService(string baseUri)
        {
            _baseUri = baseUri;
        }

        public Uri GetEmployeePaginationUri(EmployeeQueryFilter filters, string actionUrl)
        {
            string baseUrl = $"{_baseUri}{actionUrl}";
            return new Uri(baseUrl);
        }
    }
}
