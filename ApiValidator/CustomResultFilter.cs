using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;
using System.Buffers;
using System.Collections.Generic;
using System.Security.Claims;
using System;

namespace ApiValidator
{

    public class CustomResultAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.ModelState.IsValid)
            {
                context.Result = new ValidationFailedResult(context.ModelState);
            }
            base.OnActionExecuting(context);
        }
    }

}
