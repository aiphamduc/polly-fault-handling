using Microsoft.AspNetCore.Mvc;

namespace ResponseService.Controllers
{
    
    [ApiController]
    [Route("api/[controller]")]
    public class ResponseController : ControllerBase
    {
        [Route("{id:int}")]
        [HttpGet]
        public ActionResult GiveAResponse(int id)
        {
            Random rnd = new Random();
            int rndInteger = rnd.Next(1, 101);
            if (rndInteger >= id)
            {
                Console.WriteLine($"--> Failure - Generate HTTP 500");
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
            else
            {
                Console.WriteLine($"--> Success - Return 200");
                return Ok();
            }
        }
    }
}
