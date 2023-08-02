using EasyNails.Core.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasyNails.Infraestructure.Validators
{
    public class UserValidator:AbstractValidator<UserDto>
    {
        #region Builder
        public UserValidator()
        {
            // TODO: Agregar el resto de validaciones para los campos de la entidad empleados
            RuleFor(employeeDto => employeeDto.FirstName)
                .NotNull().NotEmpty().Length(5, 50);
        }
        #endregion
    }
}
