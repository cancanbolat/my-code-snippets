using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Blog.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SnippetTestsController : ControllerBase
    {
        //getasync
        [HttpGet]
        public async System.Threading.Tasks.Task<IActionResult> EndpointName1()
        {


            return Ok();
        }

        //getparamsasync
        [HttpGet("{example}")]
        public async Task<IActionResult> EndpointName2(example)
        {


            return Ok();
        }

        //postasync
        [HttpPost]
        public async Task<IActionResult> EndpointName3([FromBody] Model model)
        {


            return Created("", model);
        }


    }
}
