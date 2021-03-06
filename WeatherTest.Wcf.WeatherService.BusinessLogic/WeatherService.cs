﻿using System;
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
                .Select(c => new City
                {
                    Id = c.Id,
                    Name = c.Name
                })
                .ToList();
        }

        public IEnumerable<Temperature> GetCityWeather(int cityId, DateTime dateTime)
        {
            var result = _repository.GetCityWeather(cityId, dateTime);
            return result
                .Select(t => new Temperature
                {
                    Degree = t.Degree,
                    DateTime = t.DateTime
                })
                .ToList();
        }
    }
}