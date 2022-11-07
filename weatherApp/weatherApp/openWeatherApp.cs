using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.Net.Http;

namespace weatherApp
{
    class openWeatherApp
    {
        public class OpenWeatherMap<T>
        {
            private const string OpenWeatherApi = "http://api.openweathermap.org/data/2.5/weather?q=";
            private const string Key = "653b1f0bf8a08686ac505ef6f05b94c2";
            HttpClient _httpClient = new HttpClient();

            public async Task<T> GetAllWeathers(string city)
            {
                var json = await _httpClient.GetStringAsync(OpenWeatherApi + city + "&APPID=" + Key);
                var getWeatherModels = JsonConvert.DeserializeObject<T>(json);
                return getWeatherModels;
            }
        }
    }
}
