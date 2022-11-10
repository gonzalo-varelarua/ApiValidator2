using ApiValidator.DTOs;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ApiValidator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] CreateCustomer create)
        {

            return Created("uri", create);
        }

    }
}
