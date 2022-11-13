using ApiValidator.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Threading.Tasks;

namespace ApiValidator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersStandardController : ControllerBase
    {

        [HttpPost("standard")]
        public ActionResult PostStandardResult([FromBody] CreateCustomer create)
        {

            return Created("uri", create);
        }

    }
}
