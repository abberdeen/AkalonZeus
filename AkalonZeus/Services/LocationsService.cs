using OpenWeatherMapClient.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AkalonZeus.Services
{
    public class LocationsService
    {
        private static List<Place> _cities;

        public static List<Place> GetPlaces()
        {
            _cities = new List<Place>() {
                new Place(){
                    Id = 1,
                    Coordinates = new Coordinates(69.627922, 40.285271),
                    Name = "Khujand"
                },
                 new Place(){
                    Id = 1,
                    Coordinates = new Coordinates(68.779053, 38.535751),
                    Name = "Dushanbe"
                }
            };
            return _cities;
        }
    }

    public class Place
    {
        public int Id { get; set; }
        public Coordinates Coordinates { get; set; }
        public string Name { get; set; }
        public string NameEn { get; set; }
        public string NameRu { get; set; }
        public string Type { get; set; }

    }
}
