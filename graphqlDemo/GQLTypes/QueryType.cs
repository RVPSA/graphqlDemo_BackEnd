namespace graphqlDemo.GQLTypes
{
    public class QueryType
    {
        public WeatherForecast GetWeatherForecast() { 
            WeatherForecast _weather = new WeatherForecast();
            _weather.Date = DateTime.Now;
            _weather.TemperatureC = 10;
            _weather.Summary = "cold";



            return _weather;
        }

    }
}
