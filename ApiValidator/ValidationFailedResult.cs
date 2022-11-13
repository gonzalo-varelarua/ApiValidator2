using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ApiValidator
{

    public class ValidationResultModel
    {
        public bool Status { get; set; }
        public string Message { get; set; }
        public string Data { get; set; }

        public ValidationResultModel(ModelStateDictionary modelState)
        {
            var list = modelState.Values.Where(v => v.Errors.Count > 0)
                        .SelectMany(v => v.Errors)
                        .Select(v => v.ErrorMessage)
                        .ToList();
            var n = list.Count;
            if (n == 1)
            {
                Message = "Hay un error";
                Data = list[0];
            } else
            {
                Message = $"Hay {n} errores";
                Data = string.Join("; ", list);
            }
        }
    }

    public class ValidationFailedResult : ObjectResult
    {
        public ValidationFailedResult(ModelStateDictionary modelState)
            : base(new ValidationResultModel(modelState))
        {
            StatusCode = StatusCodes.Status400BadRequest;
        }
    }

}
