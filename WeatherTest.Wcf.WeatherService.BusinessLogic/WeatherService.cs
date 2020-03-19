using System;
using System.Collections.Generic;
using WeatherTest.Wcf.WeatherService.BusinessLogic.Models;

namespace WeatherTest.Wcf.WeatherService.BusinessLogic
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class WeatherService : IWeatherService
    {
        public IEnumerable<City> GetCities()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Temperature> GetCityWeather(int cityId)
        {
            throw new NotImplementedException();
        }
    }
}
