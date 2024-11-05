using Microsoft.AspNetCore.Mvc;

namespace GamataAPI.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class ValuesController : ControllerBase
    {
        [HttpGet("test-one")]
        public IActionResult TestOne()
        {
            return Ok("TestOne response");
        }
    }

}
