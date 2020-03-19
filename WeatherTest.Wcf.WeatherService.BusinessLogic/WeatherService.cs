using System.Collections.Generic;
using System.Linq;
using WeatherTest.Wcf.WeatherService.BusinessLogic.Models;
using WeatherTest.Wcf.WeatherService.DataAccess;

namespace WeatherTest.Wcf.WeatherService.BusinessLogic
{
    public class WeatherService : IWeatherService
    {
        private readonly WeatherRepository _repository;

        public WeatherService()
        {
            _repository = new WeatherRepository();
        }

        public IEnumerable<City> GetCities()
        {
            var result = _repository.GetCities();
            return result
                .Select(c => new City(c.Id, c.Name))
                .ToList();
        }

        public IEnumerable<Temperature> GetCityWeather(int cityId)
        {
            var result = _repository.GetCityWeather(cityId);
            return result
                .Select(t => new Temperature(t.Degree, t.DateTime))
                .ToList();
        }
    }
}