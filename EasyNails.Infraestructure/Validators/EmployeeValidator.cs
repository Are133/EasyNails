using EasyNails.Core.DTOs;
using FluentValidation;


namespace EasyNails.Infraestructure.Validators
{
    public class EmployeeValidator : AbstractValidator<EmployeeDto>
    {
        #region Builder
        public EmployeeValidator()
        {
            // TODO: Agregar el resto de validaciones para los campos de la entidad empleados
            RuleFor(employeeDto => employeeDto.FirstName)
                .NotEmpty().WithMessage("Error al ingresar un nombre vacio");
        }
        #endregion
    }
}
