using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace WeatherApp.Core
{
    public class WeatherService
    {

        WeatherAppConfig config = new WeatherAppConfig();

        static HttpClient client = new HttpClient();
         

        //get Latitude and longitude
        public  async Task<(double lat, double lon)> GetCityLatLong(string city)
        {
            string queryParams = $"?q={city}&limit=5&appid={config.GetApiKey()}";
            string url = $"{WeatherAppConfig.FINDLatLongURL}{queryParams}";
           
            client.DefaultRequestHeaders.Accept.Clear(); // optional to avoid duplicate headers
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            try
            {
                HttpResponseMessage response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();

                    //Console.WriteLine(jsonString);
                    var datas = JsonSerializer.Deserialize<List<LocationInfo>>(jsonString);
                    
                    if(datas != null && datas.Count > 0)
                    {
                        var data = datas[0];
                        Console.WriteLine($"City: {data.name}, Lat: {data.lat}, Lon: {data.lon}");
                        return (data.lat, data.lon);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Data not fetched " + e);
            }

            return (0, 0);
        }

        //get weather data
        public async Task<(string description, double temp, double temp_feel)> GetWeatherDetailAsync(double lat, double lon)
        {
            string queryParams = $"?lat={lat}&lon={lon}&appid={config.GetApiKey()}";
            string url = $"{WeatherAppConfig.BASEURL}{queryParams}";

            client.DefaultRequestHeaders.Accept.Clear(); 
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            try
            {
                HttpResponseMessage res = await client.GetAsync(url);
                if (res.IsSuccessStatusCode)
                {
                    var resJson = await res.Content.ReadAsStringAsync();
                    
                    var datas = JsonDocument.Parse(resJson);
                    var root = datas.RootElement;
                    //Console.WriteLine(root);

                    double temp = root.GetProperty("main").GetProperty("temp").GetDouble();
                    double temp_feel = root.GetProperty("main").GetProperty("feels_like").GetDouble();
                    string description = root.GetProperty("weather")[0].GetProperty("description").GetString();
                    double minTemp = root.GetProperty("main").GetProperty("temp_min").GetDouble();
                    double maxTemp = root.GetProperty("main").GetProperty("temp_max").GetDouble();

                    //Console.WriteLine($"Weater condition: {description}, Tempertaure: {ConvertToCelsius(temp)}," +
                    //    $" Feels Like: {ConvertToCelsius(temp_feel)}");
                    
                    return (description, ConvertToCelsius(temp), ConvertToCelsius(temp_feel));
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Error "+e);
            }
            return("", 0, 0);

        }

        public double ConvertToCelsius(double temp)
        {
            return Math.Round(temp-273.15, 2);
        }

    //end class
    }
}
