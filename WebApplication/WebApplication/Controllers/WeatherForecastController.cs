using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ValuesController : ControllerBase
    {
        [HttpGet()]
        public string Get([FromQuery] int id)
        {
            return $"ID: {id}";
        }

        [HttpPost]
        public string Post([FromBody] string value)
        {
            return $"Value: {value}";
        }

        [HttpPut()]
        public string Put([FromQuery] string value)
        {
            return $"Value: {value}";
        }

        [HttpDelete()]
        public string Delete([FromQuery] int id)
        {
            return $"Deleted ID: {id}";
        }
    }
}