using System;

namespace WeatherTest.Wcf.WeatherService.DataAccess.Models
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
