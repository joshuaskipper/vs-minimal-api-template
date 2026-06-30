using WebApplication1.Models.Models.Dtos;

namespace WebApplication1.Services.Interface
{
    public interface IWeatherForecast
    {
        public Task<List<WeatherForecast>> GetAsync(); 
    }
}
