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
    [CustomResultFilter]
    public class CustomersFilterController : ControllerBase
    {
        [HttpPost("withfilter")]
        public ActionResult PostFilterResult([FromBody] CreateCustomer create)
        {

            return Created("uri", create);
        }

    }

}
