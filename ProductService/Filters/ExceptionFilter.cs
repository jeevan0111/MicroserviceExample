using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using ProductService.Contracts;

namespace ProductService.Filters
{
    public class ExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            var error = new Error
            {
                StatusCode = "500",
                Message = context.Exception.Message
            };

            context.Result = new JsonResult(error);
        }
    }
}

