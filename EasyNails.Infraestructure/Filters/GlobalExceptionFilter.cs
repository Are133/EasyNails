using EasyNails.Core.Exceptions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Net;

namespace EasyNails.Infraestructure.Filters
{
    public class GlobalExceptionFilter : IExceptionFilter
    {
        //TODO : Aplicar esta validation a donde ocupemos custom exceptions
        public void OnException(ExceptionContext context)
        {
            if (context.Exception.GetType() == typeof(BusinessException))
            {
                var exception = (BusinessException)context.Exception;
                var validation = new
                {
                    Status = 400,
                    Title = "Bad Request",
                    Detail = exception.Message
                };

                var json = new
                {
                    errors = new[]
                    {
                        validation
                    }
                };

                context.Result = new BadRequestObjectResult(json);
                context.HttpContext.Response.StatusCode = (int)HttpStatusCode.BadRequest;
                context.ExceptionHandled = true;
            }
        }
    }
}
