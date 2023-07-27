using AutoMapper;
using EasyNails.Core.DTOs;
using EasyNails.Core.Entities;

namespace EasyNails.Infraestructure.Mappings
{
    public class AutoMapperProfile : Profile
    {
        #region Builder
        public AutoMapperProfile()
        {
            #region EmployeeProfile
            CreateMap<Employee, EmployeeDto>();
            CreateMap<EmployeeDto, Employee>();
            #endregion
        }
        #endregion

    }
}
