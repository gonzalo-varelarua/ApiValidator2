using ApiValidator.DTOs;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ApiValidator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {

        [HttpPost("standard")]
        public async Task<ActionResult> PostStandardResult([FromBody] CreateCustomer create)
        {

            return Created("uri", create);
        }

        [HttpPost("custom")]
        [ValidateModel]
        public async Task<ActionResult> PostCustomResult([FromBody] CreateCustomer create)
        {

            return Created("uri", create);
        }

    }
}
