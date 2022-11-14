using ApiValidator.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Linq;

namespace ApiValidator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersCustomController : Controller
    {
        [HttpPost("custom")]
        public ActionResult PostCustomResult([FromBody] CreateCustomer create)
        {

            return Created("uri", create);
        }
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
