using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using WeatherTest.DataContext;
using WeatherTest.Wcf.WeatherService.DataAccess.Models;

namespace WeatherTest.Wcf.WeatherService.DataAccess
{
    public class WeatherRepository
    {
        private readonly WeatherTestDbContext _dbContext;

        public WeatherRepository()
        {
            var optionsBuilder = new DbContextOptionsBuilder<WeatherTestDbContext>();
            var connectionString = "server=localhost;user id=user;password=123456;database=weathertest";
            optionsBuilder.UseMySql(connectionString);
            _dbContext = new WeatherTestDbContext(optionsBuilder.Options);
        }

        public IEnumerable<City> GetCities()
        {
            using (_dbContext)
            {
                return _dbContext.Cities
                    .Select(c => new City(c.Id, c.Name))
                    //.Select(c => new City())
                    .ToList();
            }
        }

        public IEnumerable<Temperature> GetCityWeather(int cityId)
        {
            using (_dbContext)
            {
                return _dbContext.Temperatures
                    .Where(t => t.CityId == cityId)
                    .Select(t =>  new Temperature(t.Degree, t.DateTime))
                    .ToList();
            }
        }
    }
}
