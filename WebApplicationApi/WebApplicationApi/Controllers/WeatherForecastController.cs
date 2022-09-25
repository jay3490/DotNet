using Microsoft.AspNetCore.Mvc;

namespace WebApplicationApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ValuesController : ControllerBase
    {
        [HttpGet()]
        public Jay Get()
        {
            Jay obj = new Jay(100, "Jay");
            return obj;
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