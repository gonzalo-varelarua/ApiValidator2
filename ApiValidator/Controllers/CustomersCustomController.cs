using ApiValidator.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Threading.Tasks;

namespace ApiValidator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersCustomController : Controller
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.ModelState.IsValid)
            {
                context.Result = new ValidationFailedResult(context.ModelState);
            }
            base.OnActionExecuting(context);
        }

        [HttpPost("custom")]
        public ActionResult PostCustomResult([FromBody] CreateCustomer create)
        {

            return Created("uri", create);
        }

    }
}
