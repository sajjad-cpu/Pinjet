using Microsoft.AspNetCore.Mvc;
using Pinjet.Application.Interface;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Pinjet.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WelcomeController : ControllerBase
    {
        private readonly IWelcomeService _welcomeService;
        public WelcomeController(IWelcomeService welcomeService)
        {
            _welcomeService = welcomeService;
        }

        // GET: api/<WelcomeController>
        [HttpGet]
        public IActionResult Get()
        {
            var message = _welcomeService.GetMessage();
            return Ok(message);
        }

        // GET api/<WelcomeController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<WelcomeController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<WelcomeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<WelcomeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
