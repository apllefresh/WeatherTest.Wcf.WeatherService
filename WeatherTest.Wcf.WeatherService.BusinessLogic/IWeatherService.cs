using System.Collections.Generic;
using System.ServiceModel;
using WeatherTest.Wcf.WeatherService.BusinessLogic.Models;

namespace WeatherTest.Wcf.WeatherService.BusinessLogic
{
    [ServiceContract]
    public interface IWeatherService
    {
        [OperationContract]
        IEnumerable<City> GetCities();

        [OperationContract]
        IEnumerable<Temperature> GetCityWeather(int cityId);
    }
}