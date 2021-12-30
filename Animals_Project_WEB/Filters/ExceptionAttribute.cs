using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;

namespace Animals_Project_WEB.Validators
{
    public class MyExceptionFilter : ExceptionFilterAttribute
    {
        public override void OnException(ExceptionContext context)
        {
            context.Result = new ContentResult() { Content = "Got exception. Message: " + context.Exception.Message };
            context.ExceptionHandled = true;
        }
    }
}