namespace WebApplicationApi
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }
    }

    public class Jay
    {
        public int id {get; set;}
        public string name {get; set;}  

        public Jay(int id, string name)
        {
            this.id = id;
            this.name = name;
        }   
    }

    
}