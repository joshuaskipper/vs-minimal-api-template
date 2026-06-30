using WebApplication1.Services.Interface;

namespace WebApplication1.Services.Repository
{
    public class WeatherForecastRepository : IWeatherForecast
    {
        public Task<List<WeatherForecast>> GetAsync()
        {
            throw new NotImplementedException();
        }
    }
}
