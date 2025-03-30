using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SumApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SumController : ControllerBase
    {
        [HttpGet("add")]
        public IActionResult Add(int firstNumber, int secondNumber)
        {
            int result = firstNumber + secondNumber;

            return Ok(result);
        }
    }
}

