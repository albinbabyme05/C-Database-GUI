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

        WeatherInfo weatherInfo;
        WeatherAppConfig config = new WeatherAppConfig();

        static HttpClient client = new HttpClient();
         

        public  async Task<(double lat, double lon)> GetCityLatLong(string city)
        {
            List<string> latlonlist = new List<string>();
            //var queryParams = $"";
            string url = $"http://api.openweathermap.org/geo/1.0/direct?q={city}&limit=5&appid={config.GetApiKey()}"
;
            //string url = $"{WeatherAppConfig.FINDLatLongURL}?q={city},{state},{zipcode}&appid={config.GetApiKey()}";


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
    }
}
