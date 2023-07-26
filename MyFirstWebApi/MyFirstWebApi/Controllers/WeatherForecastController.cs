using Microsoft.AspNetCore.Mvc;

namespace MyFirstWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;
            
        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }


        [HttpPost]

        public IActionResult Post(string name, string value)
        {
            return Ok("Hey, Its my first Api");
        }

        [HttpPut]
        public IActionResult Put()
        {
            var yes = Request.Form["Id"];
            //var no = Request.ReadFormAsync["Id"]; 
            return Ok(yes); 
        }

        [HttpDelete]

        public IActionResult Delete()
        {
            //string Hey = "New";
            return Ok("Hey Deleteddddddddddddddddddddddddddddd");
        }

        [HttpPatch]
        public IActionResult Patch(int rep, int hey)
        {
            Dictionary<string, int> result = new Dictionary<string, int>();
            result.Remove("Jay");
            //result.Any("Jay", 2);
            result.Add("Ahir", 2);
            result.Clear(); 
            var show = result["Ahir"];
            return Ok(result);  

        }

    }
}