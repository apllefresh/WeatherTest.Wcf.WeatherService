using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeatherTest.Wcf.WeatherService.BusinessLogic.Models;
using WeatherTest.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using WeatherTest.Wcf.WeatherService.DataAccess;

namespace WeatherTest.Wcf.WeatherService.BusinessLogic
{
    public class WeatherService : IWeatherService
    {
        private readonly WeatherRepository _repository;

        public WeatherService()
        {
            //var optionsBuilder = new DbContextOptionsBuilder<WeatherTestDbContext>();

            //var connectionString = "server=localhost;user id=user;password=123456;database=weathertest";

            //optionsBuilder.UseMySql(connectionString);

            //_dbContext = new WeatherTestDbContext(optionsBuilder.Options);
            _repository = new WeatherRepository();
        }

        public IEnumerable<City> GetCities()
        {
            var result = _repository.GetCities();
            return result.Select(c => new City()).ToList();
            //return new List<City>();
            //using (_dbContext)
            //{
            //    return _dbContext.Cities
            //        .Select(c => new City())
            //        .ToList();
            //}
        }

        public IEnumerable<Temperature> GetCityWeather(int cityId)
        {
            //            var result = _repository.GetCityWeather(cityId);
            //            return result.Select(c => new Temperature()).ToList();
            return new List<Temperature>();
        }
    }
}