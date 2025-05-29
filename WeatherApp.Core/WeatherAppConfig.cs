using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.Core
{
    public class WeatherAppConfig
    {
        private static string APIKEY = "b5502b837151f5e3ac23f305e2dadb1d";
        public static string BASEURL = "https://api.openweathermap.org/data/2.5/weather";

        public static string FINDLatLongURL = "http://api.openweathermap.org/geo/1.0/direct";

        public string GetApiKey() => APIKEY;


    //end class
    }
}
