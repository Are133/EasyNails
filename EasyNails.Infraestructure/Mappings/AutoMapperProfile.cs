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
            //TODO: AGregar los mappings del restp de entidades
            #region EmployeeProfile
            CreateMap<Employee, EmployeeDto>();
            CreateMap<EmployeeDto, Employee>();
            #endregion
        }
        #endregion

    }
}
