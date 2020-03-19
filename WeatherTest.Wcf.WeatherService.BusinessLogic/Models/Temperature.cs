using System;

namespace WeatherTest.Wcf.WeatherService.BusinessLogic.Models
{
    public class Temperature
    {
        public Temperature(int degree, DateTime dateTime)
        {
            Degree = degree;
            DateTime = dateTime;
        }

        public int Degree { get; }
        public DateTime DateTime { get; }
    }
}