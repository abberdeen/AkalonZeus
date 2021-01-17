using Nominatim.API.Geocoders;
using Nominatim.API.Models;
using OpenWeatherMapClient.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZeusHelper
{
    class Program
    {
        static void Main(string[] args)
        {
            //var apiKey = "68247420ccab2971c4ef714b3cdefe68";
            //var oneCallApi = new OpenWeatherMapClient.OneCallRequest(apiKey);
            //for (int i = 0; i < 100; i++)
            //{
            //    var weather = oneCallApi.GetCurrentAndForecastWeather(new Coordinates(new Random().Next(10, 90), new Random().Next(-90, 90)));
            //    Console.WriteLine("{4} | {0} [{1} {2}]: {3}", weather.Timezone, weather.Longitude, weather.Latitude, weather.CurrentWeather.Temp.Celsius, i);
            //}

            var apiKey = "68247420ccab2971c4ef714b3cdefe68";
            var oneCallApi = new OpenWeatherMapClient.OneCallRequest(apiKey);

            var sino = Task.Run<Coordinates>(async () => await GetCoordinatesAsync("Сино, Душанбе, Тоҷикистон")).Result;
           
            var weather = oneCallApi.GetCurrentAndForecastWeather(sino);
            Console.WriteLine("{0} [{1} {2}]: {3}", weather.Timezone, weather.Longitude, weather.Latitude, weather.CurrentWeather.Temp.Celsius);

            var shohmansur = Task.Run<Coordinates>(async () => await GetCoordinatesAsync("Вахдат, Тоҷикистон")).Result;

            weather = oneCallApi.GetCurrentAndForecastWeather(shohmansur);
            Console.WriteLine("{0} [{1} {2}]: {3}", weather.Timezone, weather.Longitude, weather.Latitude, weather.CurrentWeather.Temp.Celsius );


            Console.ReadLine();
        }
        static async Task<Coordinates> GetCoordinatesAsync(string query)
        {
            var geocoder = new ForwardGeocoder();
            var request = new ForwardGeocodeRequest()
            {
                queryString = query
            };

            var result = await geocoder.Geocode(request);
            if (result.Length > 0)
            {
                var geocodeResponse = result.First();
                var tags = geocodeResponse.ExtraTags;
                return new Coordinates(geocodeResponse.Latitude, geocodeResponse.Longitude);
            }
            return null;
        }
    }
}
