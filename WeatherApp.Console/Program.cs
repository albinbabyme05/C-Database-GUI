using WeatherApp.Core;

public class Program
{
    static async Task Main(string[] args)
    {
        WeatherService service = new WeatherService();
        var (lat, lon) = await service.GetCityLatLong("Stuttgart");

         await service.GetWeatherDetailAsync(lat, lon);
       
    }
}
