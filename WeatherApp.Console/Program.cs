using WeatherApp.Core;

public class Program
{
    static async Task Main(string[] args)
    {
        WeatherService service = new WeatherService();
        var result = await service.GetCityLatLong("Stuttgart");
        Console.WriteLine(result);
    }
}
