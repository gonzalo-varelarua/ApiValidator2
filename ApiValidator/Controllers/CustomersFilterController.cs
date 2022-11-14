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
    public class CustomersFilterController : ControllerBase
    {
        [HttpPost("withfilter")]
        [CustomResult(Order = int.MinValue)]
        public ActionResult PostFilterResult([FromBody] CreateCustomer create)
        {

            return Created("uri", create);
        }

    }

}
